using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirFrance.Models
{
    public class Trajet
    {
        public int Id { get; set; }
        public DateTime DateDepart { get; set; }
        public DateTime DateArrive { get; set; }

        public float Prix { get; set; }

        public Aeroport AeroportDepart { get; set; }
        public Aeroport AeroportArrive { get; set; }
        public Avion Avion { get; set; }
        public IEnumerable<Passager> listPassager { get; set; }

    }
}