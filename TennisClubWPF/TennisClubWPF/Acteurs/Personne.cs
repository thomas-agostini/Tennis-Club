using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisClub.Acteur
{
    public class Personne
    {
        public string Nom { get; set { Nom = value; OnPropertyChanged("Nom")}; }
        public string Prenom { get; set; }
        public TypePersonne Type { get; set; }
        public int Age { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Adresse { get; set; }
    }
}
