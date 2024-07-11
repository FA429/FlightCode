using FlightCode.Dtos;
using FlightCode.Models;

namespace FlightCode.Repositories.FlightRepository;

public interface IFlightRepository
{

    Task<IEnumerable<Flight>> GetFlightsAsync();
    //Task<IEnumerable<Flight>> GetFlightWithBooking();
    Task<Flight> GetFlightByIdAsync(int id);
    Task AddFlightAsync(Flight flight);
    Task UpdateFlightAsync(Flight flight,int id );
    Task DeleteFlightAsync(int id);

    Task<bool> CheckFlightAsync(int id);
    //search
    Task<IEnumerable<Flight>>SearchFlight(string from ,string to);

    
}
