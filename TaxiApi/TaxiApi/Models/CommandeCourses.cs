using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiApi.Models
{
    public class CommandeCourses
    {
        public int IdCommande { get; set; }
        public int UsersId { get; set; }//Foreign key from Users table 
        public string MoyenDeTransport { get; set; }
        public string TypeDeTransport { get; set; }
        public string AdresseRecuperartion { get; set; }
        public string AdressDestination { get; set; }
        public int Tarif { get; set; } 
    }
}
