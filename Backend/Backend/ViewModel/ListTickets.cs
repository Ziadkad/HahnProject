using Backend.Entities;

namespace Backend.ViewModel;

public class ListTickets
{
    public List<Ticket> Tickets { get; set; }
    public int PagesCount { get; set; }
}