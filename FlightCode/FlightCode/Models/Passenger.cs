using FlightCode.Dtos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlightCode.Models;

public class Passenger
{
    public int Id { get; set; }
    public int FlightId { get; set; }
    public string? FullName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }

    public Flight? Flight { get; set; }
}
