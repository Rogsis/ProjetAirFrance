using AirFrance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetAirFrance.Models
{
    public static class Generics
    {
        public static bool PlaceDisponible<P,A>(List<P> passagers, A avion) where P :List<Passager> where A : Avion
        {
            return avion.PlaceDisponible(passagers);
        }
    }


}