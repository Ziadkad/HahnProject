using Backend.Dtos;
using Backend.Entities;
using Backend.Enums;
using Backend.Exceptions;
using Backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;
[ApiController]
[Route("api/[controller]")]
public class TicketController : ControllerBase
{
    private readonly ITicketService _ticketService;

    public TicketController(ITicketService ticketService)
    {
        _ticketService = ticketService;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllTickets(int page, int pageSize, Status? status = null, string? description = null, DateTime? startDate = null, DateTime? endDate = null)
    {
        List<Ticket> tickets = await _ticketService.GetAllTickets(page, pageSize, status, description, startDate, endDate);
        return Ok(tickets);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetTicket(int id)
    {
        try
        {
            var ticket = await _ticketService.GetTicket(id);
            return Ok(ticket);
        }
        catch (TicketNotFoundException e)
        {
            return NotFound(e.Message);
        }
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateTicket([FromBody] TicketCreateDto ticketCreateDto)
    {   try
        {
            Ticket ticket = await _ticketService.CreateTicket(ticketCreateDto);
            return CreatedAtAction(nameof(GetTicket), new { id = ticket.TicketId }, ticket);
        }
        catch (SomethingWentWrongException e)
        {
            return StatusCode(500, e.Message);
        }
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTicket(int id, [FromBody] Ticket newTicket)
    {
        try
        {
            await _ticketService.UpdateTicket(id, newTicket);
            return NoContent();
        }
        catch (TicketNotFoundException e)
        {
            return NotFound(e.Message);
        }
        catch (SomethingWentWrongException e)
        {
            return StatusCode(500, e.Message);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveTicket(int id)
    {
        try
        {
            await _ticketService.RemoveTicket(id);
            return NoContent();
        }
        catch (TicketNotFoundException e)
        {
            return NotFound(e.Message);
        }
        catch (SomethingWentWrongException e)
        {
            return StatusCode(500, e.Message);
        }
    }
}