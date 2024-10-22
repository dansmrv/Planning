using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planning.Dtos.Process
{
    public class CreateProcessRequestDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}