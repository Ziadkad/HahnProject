using System.Linq.Expressions;
using AutoMapper;
using Backend.Dtos;
using Backend.Entities;
using Backend.Enums;
using Backend.Exceptions;
using Backend.Repositories.Interfaces;
using Backend.Services.Interfaces;

namespace Backend.Services;

public class TicketService : ITicketService
{
    private readonly ITicketRepository _ticketRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<TicketService> _logger;

    public TicketService(ITicketRepository ticketRepository, IMapper mapper, ILogger<TicketService> logger)
    {
        _ticketRepository = ticketRepository;
        _mapper = mapper;
        _logger = logger;
    }
    
    //Retrieves all tickets with optional filtering by status, description, and date range.
    public async Task<List<Ticket>> GetAllTickets(int page, int pageSize, Status? status = null, string? description = null, DateOnly? startDate = null, DateOnly? endDate = null)
    {
        List<Expression<Func<Ticket, bool>>> filters = new List<Expression<Func<Ticket, bool>>>();
        
        // Add filters based on provided criteria
        if (status.HasValue)
        {
            filters.Add(t => t.Status == status.Value);
            _logger.LogInformation("Filtering by status: {Status}", status.Value);
        }
        if (!string.IsNullOrEmpty(description))
        {
            filters.Add(t => t.Description.Contains(description));
            _logger.LogInformation("Filtering by description: {Description}", description);
        }
        if (startDate.HasValue && endDate.HasValue)
        {
            filters.Add(t => t.Date >= startDate.Value && t.Date <= endDate.Value);
            _logger.LogInformation("Filtering by date range: {StartDate} to {EndDate}", startDate.Value, endDate.Value);
        }
        else if (startDate.HasValue)
        {
            filters.Add(t => t.Date >= startDate.Value);
            _logger.LogInformation("Filtering by start date: {StartDate}", startDate.Value);
        }
        else if (endDate.HasValue)
        {
            filters.Add(t => t.Date <= endDate.Value);
            _logger.LogInformation("Filtering by end date: {EndDate}", endDate.Value);
        }
        
        // Get filtered tickets
        List<Ticket> tickets = await _ticketRepository.GetAllAsNoTrackingWithPagination(filters, page, pageSize);
        _logger.LogInformation("Retrieved {Count} tickets from page {Page} with page size {PageSize}", tickets.Count, page, pageSize);
        return tickets;
    }
    
    // Retrieves a ticket by its ID.
    public async Task<Ticket> GetTicket(int id)
    {
        _logger.LogInformation("Retrieving ticket with ID: {TicketId}", id);
        return await _ticketRepository.GetAsNoTracking(ti => ti.TicketId == id) ?? throw new TicketNotFoundException(id);;
    }
    
    //Creates a new ticket.
    public async Task<Ticket> CreateTicket(TicketCreateDto ticketCreateDto)
    {
        Ticket ticket = _mapper.Map<Ticket>(ticketCreateDto);
        _logger.LogInformation("Creating a new ticket: {Ticket}", ticket);
        await _ticketRepository.CreateAsync(ticket);
        if (!await _ticketRepository.SaveChangesAsync())
        {
            _logger.LogError("Failed to save new ticket to the database.");
            throw new SomethingWentWrongException();
        }
        _logger.LogInformation("Ticket created successfully with ID: {TicketId}", ticket.TicketId);
        return ticket;
    }
    
    //Updates an existing ticket.
    public async Task UpdateTicket(int id, Ticket newticket)
    {
        if (id != newticket.TicketId)
        {
            _logger.LogError("IDs don't match. Provided ID: {ProvidedId}, Ticket ID: {TicketId}", id, newticket.TicketId);
            throw new Exception("Ids don't match");
        }
        await GetTicket(id);
        _logger.LogInformation("Updating ticket with ID: {TicketId}", id);
        await _ticketRepository.UpdateAsync(newticket);
        if (!await _ticketRepository.SaveChangesAsync())
        {
            _logger.LogError("Failed to save changes while updating ticket ID: {TicketId}", id);
            throw new SomethingWentWrongException();
        }
        _logger.LogInformation("Ticket with ID: {TicketId} updated successfully.", id);
    }
    
    //Removes a ticket by its ID.
    public async Task RemoveTicket(int id)
    {
        Ticket ticket = await GetTicket(id);
        _logger.LogInformation("Removing ticket with ID: {TicketId}", id);
        await _ticketRepository.RemoveAsync(ticket);
        
        if (!await _ticketRepository.SaveChangesAsync())
        {
            _logger.LogError("Failed to save changes while removing ticket ID: {TicketId}", id);
            throw new SomethingWentWrongException();
        }
        _logger.LogInformation("Ticket with ID: {TicketId} removed successfully.", id);
    }
    
}