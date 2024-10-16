using System.Linq.Expressions;
using Backend.Data;
using Backend.Entities;
using Backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repositories;

public class TicketRepository : GenericRepository<Ticket>,ITicketRepository
{
    private readonly AppDbContext _dbSet;
    public TicketRepository(AppDbContext db) : base(db)
    {
        _dbSet = db;
    }
    
    public async Task<List<Ticket>> GetAllAsNoTrackingWithPagination(
        List<Expression<Func<Ticket, bool>>>? filters = null,
        int page = 1,
        int pageSize = 10
    )
    {
        IQueryable<Ticket> query = _dbSet.Tickets.AsNoTracking();
        if (filters != null && filters.Any())
        {
            foreach (var filter in filters)
            {
                query = query.Where(filter);
            }
        }
        query = query.Skip((page - 1) * pageSize).Take(pageSize);
        return await query.ToListAsync();
    }
    
}