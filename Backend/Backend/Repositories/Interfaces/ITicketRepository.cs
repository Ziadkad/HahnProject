using System.Linq.Expressions;
using Backend.Entities;

namespace Backend.Repositories.Interfaces;

public interface ITicketRepository : IGenericRepository<Ticket>
{
    Task<List<Ticket>> GetAllAsNoTrackingWithPagination(List<Expression<Func<Ticket, bool>>>? filters = null, int page = 1, int pageSize = 10);
}