using AutoMapper;
using Backend.Dtos;
using Backend.Entities;

namespace Backend.Mapper;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Ticket, TicketCreateDto>().ReverseMap();
    }
}