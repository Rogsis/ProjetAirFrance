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
        private List<string> imageAero = new List<string>() { "paris.jpg", "pekin.jpg", "atlanta.jpg", "dubai.jpg", "tokyo.jpg", "londres.jpg", "shangai.jpg", "amsterdam.jpg", "istanbul.jpg", "delhi.jpg", "seoul.jpg", "new-york.jpg", "dallas.jpg", "singapour.jpg", "chicago.jpg", "las-vegas.jpg", "madrid.jpg", "mexico.jpg", "taiwan.jpg", "los-angeles.jpg", };
        private List<string> Prenoms = new List<string>() { "Kevin", "Baptise", "Gaetan", "Julien", "Axel", "Florian", "David", "Victor", "Antoine", "Thomas", "Simon", "Lucas" };
        private List<string> Noms = new List<string>() { "CHAPELET", "FOURRIER", "GOGAIL", "LE PRUNNEC", "LEFEVRE", "MADEC", "MICHEL", "PERROT", "PLUCHON", "TIERCIN", "TOULEC", "TREVEL" };
        private List<DateTime> dateNaissances = new List<DateTime>() {new DateTime(1993,02,24), new DateTime(1993, 06, 10), new DateTime(1996, 02, 24), new DateTime(1993, 03, 20), new DateTime(1990, 08, 24), new DateTime(1985, 11, 10), };
        private List<float> prix = new List<float>() { (float)150.30, (float)185.80, (float)200.30, (float)310.70, (float)440, (float)375.20, (float)125.60, (float)123.80, (float)325.20, (float)345.50 };
        private List<DateTime> datesDepart = new List<DateTime>() { new DateTime(2019, 02, 24, 15,30,0), new DateTime(2019, 04, 10, 15, 30, 0), new DateTime(2019, 05, 4, 15, 30, 0), new DateTime(2019, 06, 20, 15, 30, 0), new DateTime(2019, 07, 24, 15, 30, 0), new DateTime(2019, 09, 10, 15, 30, 0), new DateTime(2019, 10, 16, 15, 30, 0), new DateTime(2019, 11, 15, 15, 30, 0), new DateTime(2019, 12, 17, 15, 30, 0), new DateTime(2020, 1, 8, 15, 30, 0) };
        private List<DateTime> datesArrive = new List<DateTime>() { new DateTime(2019, 02, 24, 21, 30, 0), new DateTime(2019, 04, 10, 23, 30, 0), new DateTime(2019, 05, 4, 18, 30, 0), new DateTime(2019, 06, 21, 02, 30, 0), new DateTime(2019, 07, 25, 15, 30, 0), new DateTime(2019, 09, 10, 23, 0, 0), new DateTime(2019, 10, 16, 22, 15, 0), new DateTime(2019, 11, 16, 4, 30, 0), new DateTime(2019, 12, 17, 20, 30, 0), new DateTime(2020, 1, 9, 3, 30, 0) };
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
                Aeroport aeroport = new Aeroport() { Id = i, nom = nomAero[i - 1], nomCourt = nomCourtAero[i - 1], nomVille = nomVilles[i-1], image = imageAero[i - 1] };
                aeroports.Add(aeroport);
            }
            return aeroports;
        }

        public IEnumerable<Trajet> getTrajets()
        {
            List<Aeroport> aeroports = this.getAeroports();
            List<Avion> avions = this.getAvions();
            List<Passager> passagers = this.getPassagers();
            IEnumerable<Trajet> trajets = new List<Trajet>();
            for (var i =1; i<=10; i++)
            {
                Trajet trajet = new Trajet() { Id = i, Avion = avions[i + 5], AeroportDepart = aeroports[i-1], AeroportArrive = aeroports[aeroports.Count() - i], Prix = prix[i-1], DateDepart = datesDepart[i-1], DateArrive = datesArrive[i-1], listPassager = passagers.Take(180) };
                trajets.ToList().Add(trajet);
            }
            Console.WriteLine("===================="+trajets.ToList().Count());
            return trajets;
        }

        public List<Passager> getPassagers()
        {
            int i = 1;
            List<Passager> passagers = new List<Passager>();
            foreach(string nom in Noms)
            {
                foreach(string prenom in Prenoms)
                {
                    foreach (DateTime dateNaissance in dateNaissances)
                    {
                        Passager passager = new Passager() { Id = i, Nom = nom, Prenom = prenom, dateDeNaissance = dateNaissance };
                        i++;
                        passagers.Add(passager);
                    }
                }
            }
            return passagers;
        }



        private DataModel()
        {

        }
    }
}