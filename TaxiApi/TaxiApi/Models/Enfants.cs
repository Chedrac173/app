using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TaxiApi.Models
{
    public class Enfants
    {
        public int IdEnfant { get; set; }
        public int ParentID { get; set; }//Foreign key from Users table
        public int ParentPhoneNumber { get; set; } //Foreign key from Users table
        public int NombreEnfants { get; set; }  
        public string AdresseDomicile { get; set; }
        public string AdresseEcole { get; set; }
        public int HeureArriverCours { get; set; }
        public int HeureSortieCours { get; set; }
    }
}
