using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TaxiApi.Models
{
    public class Conducteurs
    {
        public int IdConducteur { get; set; }
        public int IdConducteurFromUsers { get; set; } //Foreign Keys from Users Id
        public string AdresseStationnement { get; set; }
        public int NumeroCarteIdentite { get; set; }
        public int NumeroAcontacter { get; set; }
        
    }
}
