using AutoMapper;
using Backend.Repositories.Interfaces;
using Backend.Services.Interfaces;

namespace Backend.Services;

public class TicketService : ITicketService
{
    private readonly ITicketRepostory _ticketRepostory;
    private readonly IMapper _mapper;

    public TicketService(ITicketRepostory ticketRepostory, IMapper mapper)
    {
        _ticketRepostory = ticketRepostory;
        _mapper = mapper;
    }
}