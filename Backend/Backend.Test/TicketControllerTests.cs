using Backend.Controllers;
using Backend.Dtos;
using Backend.Entities;
using Backend.Enums;
using Backend.Exceptions;
using Backend.Services.Interfaces;
using Backend.ViewModel;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Backend.Test;

public class TicketControllerTests
{
    private readonly Mock<ITicketService> _ticketServiceMock;
    private readonly TicketController _ticketController;

    public TicketControllerTests()
    {
        _ticketServiceMock = new Mock<ITicketService>();
        _ticketController = new TicketController(_ticketServiceMock.Object);
    }
    
    [Fact]
    public async Task GetAllTickets_ReturnsOkResult_WhenTicketsExist()
    {
        // Arrange
        List<Ticket> tickets = new List<Ticket> { new Ticket { TicketId = 1, Description = "Test Ticket", Status = Status.Open, Date = DateTime.Now } };
        ListTickets expectedListTickets = new ListTickets { Tickets = tickets, PagesCount = 1 };
        
        _ticketServiceMock.Setup(service => service.GetAllTickets(1, 10, null, null, null, null))
            .ReturnsAsync(expectedListTickets);

        // Act
        var result = await _ticketController.GetAllTickets(1, 10);

        // Assert
        var okResult = result as OkObjectResult;
        okResult.StatusCode.Should().Be(200); 
        okResult.Value.Should().BeEquivalentTo(expectedListTickets); 
    }

    [Fact]
    public async Task GetTicket_ReturnsOkResult_WhenTicketExists()
    {
        // Arrange
        Ticket expectedTicket = new Ticket { TicketId = 1, Description = "Test Ticket", Status = Status.Open, Date = DateTime.Now };
        
        _ticketServiceMock.Setup(service => service.GetTicket(1))
            .ReturnsAsync(expectedTicket);

        // Act
        var result = await _ticketController.GetTicket(1);

        // Assert
        var okResult = result as OkObjectResult;

        okResult.StatusCode.Should().Be(200); 
        okResult.Value.Should().BeEquivalentTo(expectedTicket);
    }

    [Fact]
    public async Task GetTicket_ReturnsNotFound_WhenTicketDoesNotExist()
    {
        // Arrange
        int id = 1;
        _ticketServiceMock.Setup(service => service.GetTicket(id))
            .ThrowsAsync(new TicketNotFoundException(id));

        // Act
        var result = await _ticketController.GetTicket(1);

        // Assert
        var notFoundResult = result as NotFoundObjectResult;
        
        notFoundResult.StatusCode.Should().Be(404);
        notFoundResult.Value.Should().Be($"The ticket with the Id {id} is not found");
    }

    [Fact]
    public async Task CreateTicket_ReturnsCreatedAtActionResult()
    {
        // Arrange
        TicketCreateDto createDto = new TicketCreateDto() { Description = "New Ticket", Status = Status.Open, Date = DateTime.Now };
        Ticket expectedTicket = new Ticket { TicketId = 1, Description = "New Ticket", Status = Status.Open, Date = DateTime.Now };

        _ticketServiceMock.Setup(service => service.CreateTicket(createDto))
            .ReturnsAsync(expectedTicket);

        // Act
        var result = await _ticketController.CreateTicket(createDto);

        // Assert
        var createdAtActionResult = result as CreatedAtActionResult;

        createdAtActionResult.StatusCode.Should().Be(201); 
        createdAtActionResult.Value.Should().BeEquivalentTo(expectedTicket);
    }

    [Fact]
    public async Task CreateTicket_ReturnsStatusCode500_WhenExceptionIsThrown()
    {
        // Arrange
        TicketCreateDto createDto = new TicketCreateDto { Description = "New Ticket", Status = Status.Open, Date = DateTime.Now };

        _ticketServiceMock.Setup(service => service.CreateTicket(createDto))
            .ThrowsAsync(new SomethingWentWrongException());

        // Act
        var result = await _ticketController.CreateTicket(createDto);

        // Assert
        var statusCodeResult = result as ObjectResult;

        statusCodeResult.StatusCode.Should().Be(500); 
        statusCodeResult.Value.Should().Be("Something went wrong While trying to do this action.");
    }

    [Fact]
    public async Task UpdateTicket_ReturnsNoContent_WhenUpdateIsSuccessful()
    {
        // Arrange
        Ticket updatedTicket = new Ticket { TicketId = 1, Description = "Updated Ticket", Status = Status.Closed, Date = DateTime.Now };
        _ticketServiceMock.Setup(service => service.UpdateTicket(1, updatedTicket))
            .Returns(Task.CompletedTask);

        // Act
        var result = await _ticketController.UpdateTicket(1, updatedTicket);

        // Assert
        result.Should().BeOfType<NoContentResult>();
    }
    
    [Fact]
    public async Task UpdateTicket_ReturnsNotFound_WhenTicketDoesNotExist()
    {
        // Arrange
        Ticket updatedTicket = new Ticket { TicketId = 1, Description = "Updated Ticket", Status = Status.Closed, Date = DateTime.Now };
        int id = 1;
        _ticketServiceMock.Setup(service => service.UpdateTicket(id, updatedTicket))
            .ThrowsAsync(new TicketNotFoundException(updatedTicket.TicketId));

        // Act
        var result = await _ticketController.UpdateTicket(1, updatedTicket);

        // Assert
        var notFoundResult = result as NotFoundObjectResult;

        notFoundResult.StatusCode.Should().Be(404); 
        notFoundResult.Value.Should().Be($"The ticket with the Id {id} is not found"); 
    }
    
    [Fact]
    public async Task UpdateTicket_ReturnsStatusCode500_WhenSomethingWentWrong()
    {
        // Arrange
        Ticket updatedTicket = new Ticket { TicketId = 1, Description = "Updated Ticket", Status = Status.Closed, Date = DateTime.Now };

        _ticketServiceMock.Setup(service => service.UpdateTicket(1, updatedTicket))
            .ThrowsAsync(new SomethingWentWrongException());

        // Act
        var result = await _ticketController.UpdateTicket(1, updatedTicket);

        // Assert
        var statusCodeResult = result as ObjectResult;

        statusCodeResult.StatusCode.Should().Be(500);
        statusCodeResult.Value.Should().Be("Something went wrong While trying to do this action."); 
    }
    
    [Fact]
    public async Task UpdateTicket_ReturnsBadRequest_WhenExceptionIsThrown()
    {
        // Arrange
        Ticket  updatedTicket = new Ticket { TicketId = 1, Description = "Updated Ticket", Status = Status.Closed, Date = DateTime.Now };

        _ticketServiceMock.Setup(service => service.UpdateTicket(2, updatedTicket))
            .ThrowsAsync(new Exception("Ids don't match"));

        // Act
        var result = await _ticketController.UpdateTicket(2, updatedTicket);

        // Assert
        var badRequestResult = result as BadRequestObjectResult;

        badRequestResult.StatusCode.Should().Be(400); 
        badRequestResult.Value.Should().Be("Ids don't match");
    }

    [Fact]
    public async Task RemoveTicket_ReturnsNoContent_WhenRemoveIsSuccessful()
    {
        // Arrange
        _ticketServiceMock.Setup(service => service.RemoveTicket(1))
            .Returns(Task.CompletedTask);

        // Act
        var result = await _ticketController.RemoveTicket(1);

        // Assert
        result.Should().BeOfType<NoContentResult>();
    }

    [Fact]
    public async Task RemoveTicket_ReturnsNotFound_WhenTicketDoesNotExist()
    {
        // Arrange
        int id = 1;
        _ticketServiceMock.Setup(service => service.RemoveTicket(id))
            .ThrowsAsync(new TicketNotFoundException(id));

        // Act
        var result = await _ticketController.RemoveTicket(1);

        // Assert
        var notFoundResult = result as NotFoundObjectResult;

        notFoundResult.StatusCode.Should().Be(404); // Status code check
        notFoundResult.Value.Should().Be($"The ticket with the Id {id} is not found");
    }
    
    [Fact]
    public async Task RemoveTicket_ReturnsStatusCode500_WhenSomethingWentWrong()
    {
        // Arrange
        _ticketServiceMock.Setup(service => service.RemoveTicket(1))
            .ThrowsAsync(new SomethingWentWrongException());

        // Act
        var result = await _ticketController.RemoveTicket(1);

        // Assert
        var statusCodeResult = result as ObjectResult;

        statusCodeResult.StatusCode.Should().Be(500);
        statusCodeResult.Value.Should().Be("Something went wrong While trying to do this action.");
    }
}