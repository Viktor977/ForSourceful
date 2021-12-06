using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Entities
{
    /// <summary>
    /// entity "Manager"
    /// </summary>
    public class Manager
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime DateRegistration { get; set; }
        public UserRole Role { get; set; }
        /// <summary>
        /// list of employees registered by this manager
        /// </summary>
        public List<User> Workers { get; set; }
    }
}
