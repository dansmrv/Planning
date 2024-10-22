using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planning.Models
{
    public class Event : Process
    {
        public ICollection<Department> Departments { get; set; } = new List<Department>();
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public DateTime Deadline { get; set; }
        public int DocumentNumber { get; set; }
        public DateTime DocumentDate { get; set; }
        public string? CompletionForm { get; set; }
        public int TaskPriority { get; set; }
    }
}