using Backend.Enums;

namespace Backend.Dtos;

public class TicketCreateDto
{
    public string Description { get; set; } = string.Empty;
    public Status Status { get; set; }
    public DateTime Date { get; set; }
}