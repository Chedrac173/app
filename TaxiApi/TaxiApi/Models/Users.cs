using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiApi.Models
{
    public class Users
    {
        public int Id { get; set; } 
        public string LastName { get; set; }
        public string  FirstName { get; set; }   
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public int Password { get; set; }
        public string Statut { get; set; }
    }
}
