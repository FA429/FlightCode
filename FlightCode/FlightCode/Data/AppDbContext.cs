using FlightCode.Models;
using Microsoft.EntityFrameworkCore;

namespace FlightCode.Data;

public class AppDbContext : DbContext
{
    public DbSet<Flight> Flights { get; set; }
    public DbSet<Passenger> Passengers { get; set; }
    public AppDbContext(DbContextOptions options) : base(options) { }



    // seed data

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


        modelBuilder.Entity<Flight>().HasData(
                       new Flight
                       {
                           Id = 1,
                           From = "RH",
                           To = "JED",
                           Departuer = "12:00",
                           Arrival = "13:00"
                       });

        modelBuilder.Entity<Passenger>().HasData(
                       new Passenger
                       {
                           Id = 1,
                           FlightId = 1,
                           FullName = "Ali",
                           PhoneNumber = "123456789",
                           Email = "test"
                       });
    }




}
