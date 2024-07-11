using FlightCode.Models;

namespace FlightCode.Repositories.PassengerRepository;

public interface IPassengerRepository
{
    Task<IEnumerable<Passenger>> GetPassengersAsync();
    Task<Passenger> GetPassengerByIdAsync(int id);
    Task AddPassengerAsync(Passenger passenger, int Flightid);
    Task UpdatePassengerAsync(Passenger passenger, int id);
    Task DeletePassengerAsync(int id);

    Task<bool> CheckPassengerAsync(int id);
}
