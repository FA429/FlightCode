using FlightCode.Models;

namespace FlightCode.Dtos
{
    public class GetFlightDTO
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Departuer { get; set; }
        public string Arrival { get; set; }

        public ICollection<GetPassengerDTO> Passengers { get; set; }
               = new List<GetPassengerDTO>();

    }
}
