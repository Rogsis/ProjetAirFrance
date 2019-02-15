using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirFrance.Models
{
    public class Aeroport: Point
    {
        public int Id { get; set; }
        public string nom { get; set; }
        public string nomCourt { get; set; }
        public string nomVille { get; set; }
    }
}