using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirFrance.Models
{
    public class Avion : Point
    {

        public int Id { get; set; }
        public float NbPlace { get; set; }

    }
}