using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirFrance.Models
{
    public class Passager
    {
        public int Id { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public DateTime dateDeNaissance { get; set; }
    }
}