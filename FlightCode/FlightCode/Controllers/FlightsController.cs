using FlightCode.Models;
using FlightCode.Repositories.FlightRepository;
using FlightCode.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;

namespace FlightCode.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FlightsController : ControllerBase
{

    private readonly IFlightRepository _flightRepository;
    private readonly IMapper _mapper;

    public FlightsController(IFlightRepository flightRepository, IMapper mapper)
    {
        _flightRepository = flightRepository;
        _mapper = mapper;
    }

    // get flights
    [HttpGet]
    [Route("GetFlights")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<GetFlightDTO>>> GetFlights()
    {
        var allflight = await _flightRepository.GetFlightsAsync();
        var mapper = _mapper.Map<IEnumerable<GetFlightDTO>>(allflight);
        return Ok(mapper);
    }

    [HttpGet]
    [Route("GetFlightById/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<GetFlightDTO>> GetFlightById(int id)
    {
        var flight = await _flightRepository.GetFlightByIdAsync(id);
        var mapper = _mapper.Map<GetFlightDTO>(flight);
        return Ok(mapper);
    }

    // add flight
    [HttpPost]
    [Route("AddFlight")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)] // documentation error status code
    public async Task<ActionResult<PostFlightDTO>> AddFlight(PostFlightDTO flight)
    {
        var mapper = _mapper.Map<Flight>(flight);
        await _flightRepository.AddFlightAsync(mapper);
        return Ok();
    }

    [HttpPut]
    [Route("UpdateFlight/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]// documentation error status code
    public async Task<ActionResult<PostFlightDTO>> UpdateFlight(PostFlightDTO flight, int id)
    {
        if (!await _flightRepository.CheckFlightAsync(id))
        {
            return NotFound();
        }
        var mapper = _mapper.Map<Flight>(flight);
        await _flightRepository.UpdateFlightAsync(mapper, id);
        return Ok();
    }
    [HttpDelete]
    [Route("DeleteFlight/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> DeleteFlight(int id)
    {
        if (!await _flightRepository.CheckFlightAsync(id))
        {
            return NotFound();
        }
        await _flightRepository.DeleteFlightAsync(id);
        return Ok();
    }

    // search flight
    [HttpGet]
    [Route("SearchFlight")]
    [ProducesResponseType(StatusCodes.Status200OK)]

    public async Task<ActionResult<IEnumerable<GetFlightDTO>>> SearchFlight(string from, string to)
    {
        var flights = await _flightRepository.SearchFlight(from, to);
        var mapper = _mapper.Map<IEnumerable<GetFlightDTO>>(flights);
        return Ok(mapper);
    }
    
}
