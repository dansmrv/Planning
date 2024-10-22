using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Planning.Data;
using Planning.Dtos.Process;
using Planning.Mappers;

namespace Planning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ProcessController(ApplicationDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IActionResult GetAllProcesses(){
            var processes = _context.Processes.ToList()
            .Select(s => s.ToProcessDto());

            return Ok(processes);
        }

        [HttpGet("{id}")]
        public IActionResult GetProcessById(int id){
            var process = _context.Processes.Find(id);

            if(process == null){
                return NotFound();
            }
            return Ok(process.ToProcessDto());
        }
        [HttpPost]
        public IActionResult Create([FromBody] CreateProcessRequestDto processDto)
        {
            var processModel = processDto.ToProcessFromCreateDTO();
            _context.Processes.Add(processModel);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetProcessById), new { id = processModel.Id}, processModel.ToProcessDto());
        }
    }
}