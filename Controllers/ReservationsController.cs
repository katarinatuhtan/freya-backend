using Api.Database;
using Api.Database.Entities;
using Api.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly FreyaContext _context;

        public ReservationsController(FreyaContext context)
        {
            _context = context;
        }

        // GET: api/<ReservationsController>
        [HttpGet]
        public List<Reservation> Get()
        {
            return _context.Reservations.ToList();
        }

        // GET api/<ReservationsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ReservationsController>
        [HttpPost]
        public IActionResult Post([FromBody] CreateReservationRequest newReservation)
        {
            var reservation = new Reservation
            {
                FirstName = newReservation.FirstName,
                LastName = newReservation.LastName,
                Comment = newReservation.Comment,
                Design = newReservation.Design,
                DateTime = newReservation.DateTime,
                Treatment = newReservation.Treatment
            };

            _context.Reservations.Add(reservation);

            _context.SaveChanges();

            return Ok(reservation);
        }

        // PUT api/<ReservationsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReservationsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
