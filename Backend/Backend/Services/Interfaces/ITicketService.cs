using Backend.Dtos;
using Backend.Entities;
using Backend.Enums;

namespace Backend.Services.Interfaces;

public interface ITicketService
{
    Task<List<Ticket>> GetAllTickets(int page, int pageSize, Status? status = null, string? description = null, DateOnly? startDate = null, DateOnly? endDate = null);
    Task<Ticket> GetTicket(int id);
    Task<Ticket> CreateTicket(TicketCreateDto ticketCreateDto);
    Task UpdateTicket(int id, Ticket newticket);
    Task RemoveTicket(int id);
}