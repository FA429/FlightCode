using FlightCode.Data;
using FlightCode.Models;
using Microsoft.EntityFrameworkCore;

namespace FlightCode.Repositories.PassengerRepository
{
    public class PassengerRepository : IPassengerRepository
    {
        private readonly AppDbContext _context;

        public PassengerRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        // get passengers
        public async Task<IEnumerable<Passenger>> GetPassengersAsync()
        {
            return await _context.Passengers.ToListAsync();
        }

        // get passenger by id
        public async Task<Passenger> GetPassengerByIdAsync(int id)
        {
            return await _context.Passengers.FirstOrDefaultAsync(p => p.Id == id);
        }
        // add passenger
        public async Task AddPassengerAsync(Passenger passenger, int FlightId)
        {
            var AddPassenger = new Passenger
            {
                FullName = passenger.FullName,
                Email = passenger.Email,
                PhoneNumber = passenger.PhoneNumber,
                FlightId = FlightId
            };
            _context.Passengers.Add(AddPassenger);
            await _context.SaveChangesAsync();
        }

        // update passenger
        public async Task UpdatePassengerAsync(Passenger passenger, int id)
        {
            var passengerToUpdate = await _context.Passengers.FindAsync(id);
            passengerToUpdate.FullName = passenger.FullName;
            passengerToUpdate.Email = passenger.Email;
            passengerToUpdate.PhoneNumber = passenger.PhoneNumber;
            await _context.SaveChangesAsync();
        }

        // delete passenger
        public async Task DeletePassengerAsync(int id)
        {
            var passengerToDelete = await _context.Passengers.FindAsync(id);
            _context.Passengers.Remove(passengerToDelete);
            await _context.SaveChangesAsync();
        }

        // check passenger
        public async Task<bool> CheckPassengerAsync(int id)
        {
            return await _context.Passengers.AnyAsync(p => p.Id == id);
        }
    }
}
