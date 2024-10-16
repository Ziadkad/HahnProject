using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Backend.Enums;

namespace Backend.Entities;

public class Ticket
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TicketId { get; set; }
    public string Description { get; set; } = string.Empty;
    public Status Status { get; set; }
    public DateTime Date { get; set; }
}