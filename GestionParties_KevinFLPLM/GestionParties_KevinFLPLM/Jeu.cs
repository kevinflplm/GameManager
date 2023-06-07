using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Auteur  : Kevin.flplm   
/// Date    : 03.05.2023
/// Projet  : Game Manager
/// Détails : Class Jeu

namespace GestionParties_KevinFLPLM
{
    internal class Jeu
    {
        private string _nomJeu;
        private string _period;
        private string _description;
        private string _image;
        private int _minJoueurs;
        private int _maxJoueurs;
        private int _prix;

        public Jeu(string nomJeu, string period, string description, string image, int minJoueurs, int maxJoueurs, int prix)
        {
            NomJeu = nomJeu;
            Period = period;
            Description = description;
            Image = image;
            MinJoueurs = minJoueurs;
            MaxJoueurs = maxJoueurs;
            Prix = prix;
        }

        public string NomJeu { get => _nomJeu; set => _nomJeu = value; }
        public string Period { get => _period; set => _period = value; }
        public string Description { get => _description; set => _description = value; }
        public string Image { get => _image; set => _image = value; }
        public int MinJoueurs { get => _minJoueurs; set => _minJoueurs = value; }
        public int MaxJoueurs { get => _maxJoueurs; set => _maxJoueurs = value; }
        public int Prix { get => _prix; set => _prix = value; }
    }
}
