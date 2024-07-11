using FlightCode.Models;
using System.ComponentModel.DataAnnotations;

namespace FlightCode.Dtos
{
    public class GetPassengerDTO
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
     
        public string? PhoneNumber { get; set; }
        
        public string? Email { get; set; }

    }
}
