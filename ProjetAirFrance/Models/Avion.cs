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

        public bool PlaceDisponible<P>(List<P> passagers) where P : List<Passager>
        {
            return (this.NbPlace <= passagers.Count);
        }
    }
}