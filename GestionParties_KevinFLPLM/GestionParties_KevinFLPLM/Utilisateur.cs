using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParties_KevinFLPLM
{
    internal class Utilisateur
    {
        private string _prenom;
        private string _nom;
        private string _telephone;
        private string _email;
        private string _pseudo;
        private string _status;
        private string _role;

        public Utilisateur (string prenom, string nom, string telephone, string email, string pseudo, string status, string role)
        { 
            this._prenom = prenom;
            this._nom = nom;
            this._telephone = telephone;
            this._email = email;
            this._pseudo = pseudo;
            this._status = status;
            this._role = role;
        }

        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Telephone { get => _telephone; set => _telephone = value; }
        public string Email { get => _email; set => _email = value; }
        public string Pseudo { get => _pseudo; set => _pseudo = value; }
        public string Status { get => _status; set => _status = value; }
        public string Role { get => _role; set => _role = value; }
    }
}
