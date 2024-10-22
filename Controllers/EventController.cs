using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Planning.Data;

namespace Planning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public EventController(ApplicationDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IActionResult GetAllEvents(){
            var events = _context.Events.ToList();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetEventById(int id){
            var foundEvent = _context.Events.Find(id);

            if(foundEvent == null){
                return NotFound();
            }
            return Ok(foundEvent);
        }
    }
}