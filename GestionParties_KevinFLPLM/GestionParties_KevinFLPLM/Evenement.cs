using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Auteur  : Kevin.flplm   
/// Date    : 03.05.2023
/// Projet  : Game Manager
/// Détails : Class Evenement

namespace GestionParties_KevinFLPLM
{
    internal class Evenement
    {
        private string _date;
        private string _name;
        private string _location;
        private string _status;
        private int _maxMorning;
        private int _maxAfternoon;
        private int _minEvening;

        public Evenement(string date, string name, string location, string status, int maxMorning, int maxAfternoon, int minEvening)
        {
            Date = date;
            Name = name;
            Location = location;
            Status = status;
            MaxMorning = maxMorning;
            MaxAfternoon = maxAfternoon;
            MinEvening = minEvening;
        }

        public string Date { get => _date; set => _date = value; }
        public string Name { get => _name; set => _name = value; }
        public string Location { get => _location; set => _location = value; }
        public string Status { get => _status; set => _status = value; }
        public int MaxMorning { get => _maxMorning; set => _maxMorning = value; }
        public int MaxAfternoon { get => _maxAfternoon; set => _maxAfternoon = value; }
        public int MinEvening { get => _minEvening; set => _minEvening = value; }
    }
}
