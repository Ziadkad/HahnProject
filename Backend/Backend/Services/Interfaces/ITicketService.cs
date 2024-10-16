using Backend.Dtos;
using Backend.Entities;
using Backend.Enums;
using Backend.ViewModel;

namespace Backend.Services.Interfaces;

public interface ITicketService
{
    Task<ListTickets> GetAllTickets(int page, int pageSize, Status? status = null, string? description = null, DateTime? startDate = null, DateTime? endDate = null);
    Task<Ticket> GetTicket(int id);
    Task<Ticket> CreateTicket(TicketCreateDto ticketCreateDto);
    Task UpdateTicket(int id, Ticket newticket);
    Task RemoveTicket(int id);
}