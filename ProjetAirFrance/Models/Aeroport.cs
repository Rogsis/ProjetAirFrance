using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirFrance.Models
{
    public class Aeroport: Point
    {
        public int Id { get; set; }
        public String nom { get; set; }
        public String nomCourt { get; set; }
        public String nomVille { get; set; }

    }
}