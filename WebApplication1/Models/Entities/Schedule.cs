using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Entities
{
    /// <summary>
    /// working day schedule created by the manager
    /// </summary>
    public class Schedule
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ManagerName { get; set; }
        public Manager Manager { get; set; }
        public int Duration { get; set; }
        public DateTime DataStart { get; set; }
        public DateTime DataEnd { get; set; }
    }
}
