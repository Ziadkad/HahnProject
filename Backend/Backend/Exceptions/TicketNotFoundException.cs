namespace Backend.Exceptions;

public class TicketNotFoundException : Exception
{
    public TicketNotFoundException(int id) : base($"The ticket with the Id {id} is not found")
    {
    }
}