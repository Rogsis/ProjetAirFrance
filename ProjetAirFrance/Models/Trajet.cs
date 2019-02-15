using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirFrance.Models
{
    public class Trajet
    {
{
        public DateTime DateHeureTrajetDepart { get; set; }
        public DateTime DateHeureTrajetArrive { get; set; }

        public float Prix { get; set; }

        public Aeroport AeroportDepart;
        public Aeroport AeroportArrive;
        public Avion Avion;
        public List<Passager> listPassager;

    }
}