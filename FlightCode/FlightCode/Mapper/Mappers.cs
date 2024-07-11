using AutoMapper;
using FlightCode.Dtos;
using FlightCode.Models;

namespace FlightCode.Mapper
{
    public class Mappers : Profile
    {
        public Mappers()
        {
            
            CreateMap<PostFlightDTO, Flight>();
            CreateMap<Flight, PostFlightDTO>();
            CreateMap<Flight , GetFlightDTO>();
            CreateMap<GetFlightDTO, Flight>();
        
            CreateMap<GetPassengerDTO, Passenger>();
            CreateMap<Passenger, GetPassengerDTO>();
            CreateMap<PostPassengerDTO, Passenger>();
            CreateMap<Passenger, PostPassengerDTO>();
         
        }

    }
}
