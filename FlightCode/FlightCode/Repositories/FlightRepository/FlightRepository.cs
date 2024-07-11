using FlightCode.Data;
using FlightCode.Dtos;
using FlightCode.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace FlightCode.Repositories.FlightRepository
{
    public class FlightRepository : IFlightRepository
    {

        private readonly AppDbContext _context;

        public FlightRepository(AppDbContext appDbContext)
        {
           _context = appDbContext;
        }

        // git flights
        public async Task<IEnumerable<Flight>> GetFlightsAsync()
        {
            return await _context.Flights.Include(c=>c.Passengers).ToListAsync();
        }



        // get flight by id
        public async Task<Flight> GetFlightByIdAsync(int id)
        {
            return await _context.Flights.Include(c => c.Passengers).Where(c => c.Id == id).FirstOrDefaultAsync();
        }

       
        public async Task AddFlightAsync(Flight flight)
        {
            _context.Flights.Add(flight);
            await _context.SaveChangesAsync();
        }
        // update flight
        public async Task UpdateFlightAsync(Flight flight, int id)
        {
           var flightToUpdate = await _context.Flights.FindAsync(id);
            flightToUpdate.Arrival = flight.Arrival;
            flightToUpdate.Departuer = flight.Departuer;
            flightToUpdate.From = flight.From;
            flightToUpdate.To = flight.To;
            await _context.SaveChangesAsync();
        }

        // delete flight
        public async Task DeleteFlightAsync(int id)
        {
            var flightToDelete = await _context.Flights.FindAsync(id);
            _context.Flights.Remove(flightToDelete);
            await _context.SaveChangesAsync();
        }

        // check flight
        public async Task<bool> CheckFlightAsync(int id)
        {
            return await _context.Flights.AnyAsync(f => f.Id == id);
        }

        // search flight

        public async Task <IEnumerable<Flight>> SearchFlight(string from, string to)
        {
            var flights = await _context.Flights.Where(f=>f.From.Contains(from) && f.To.Contains(to)).ToListAsync();
            return flights;
        }

    }
}
