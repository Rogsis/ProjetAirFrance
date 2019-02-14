using AirFrance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetAirFrance.Models
{
    public class DataModel
    {
        private static DataModel _instance = null;
        private Random random = new Random();
        public static DataModel Singleton
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataModel();
                }
                return _instance;
            }
        }

        public List<float> latitudes = new List<float>() { };
        public List<float> longitudes = new List<float>() { };
        private List<int> nbPlaces = new List<int>() { 180, 190, 360, 460 };
        private List<string> nomAero = new List<string>() { "Charles de Gaulle", "Pékin-Capitale", "Atlanta H.-Jackson", "Dubaï", "Tokyo-Haneda", "Londres-Heathrow", "Shanghaï - Pudong","Amsterdam-Schiphol","Istanbul-Atatürk","Delhi-Indira Gandhi","Séoul-Incheon","New York-John F. Kennedy", "Dallas / Fort Worth","Singapour-Changi","Chicago O'Hare","Las Vegas-McCarran", "Madrid-Barajas", "Mexico-B. Juárez", "Taïwan-Taoyuan","Los Angeles" };
        private List<string> nomCourtAero = new List<string>() { "CDG", "PCC", "AHJ", "DUB", "THJ", "LHR", "SPC", "ASN", "IAT", "DIG", "SIC", "NYJ", "DFW", "SCS", "COH", "LVM", "MBE", "MBJ", "TTT", "LAU" };
        private List<string> nomVilles = new List<string>() { "Paris FRA", "Pékin CHI", "Atlanta USA", "Dubaï EMA", "Tokyo JPN", "Londres UK", "Shangaï CHI", "Amsterdam NET", "Istambul TUR", "Delhi IND", "Seoul KOR", "New-York USA", "Dallas USA", "Singapour SGP", "Chicago USA", "Las Vegas USA", "Madrid ESP", "Mexico MEX","Dayuan TAI", "Los Angeles USA", };
        static Random randomS = new Random();
        public List<Avion> getAvions ()
        {
            List<Avion> avions = new List<Avion>();
            for (var i =1; i<=50; i++)
            {
                Avion avion = new Avion() { Id = i, NbPlace = nbPlaces[random.Next(0, nbPlaces.Count() - 1)]};
                avions.Add(avion);
            }
            return avions;
        }

        public List<Aeroport> getAeroports()
        {
            List<Aeroport> aeroports = new List<Aeroport>();
            for (var i=1; i<=20; i++)
            {
                Aeroport aeroport = new Aeroport() { Id = i, nom = nomAero[i - 1], nomCourt = nomCourtAero[i - 1], nomVille = nomVilles[i-1] };
                aeroports.Add(aeroport);
            }
            return aeroports;
        }

        public List<Trajet> getTrajets()
        {
            List<Trajet> trajets = new List<Trajet>();
            return trajets;
        }



        private DataModel()
        {

        }
    }
}