using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisClub.Acteur
{
    public class Personne : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        string nom;
        string prenom;

        public string Nom
        {
            get { return nom; }
            set
            { 
                nom = value;
                OnPropertyChanged("Nom");
            }
        }

        public string Prenom
        {
            get { return prenom; }
            set
            {
                prenom = value;
                OnPropertyChanged("Prenom");
            }
        }


        //public string Nom { get { return Nom; } set { Nom = value; OnPropertyChanged("Nom"); } }
        //public string Prenom { get { return Prenom; } set { Prenom = value; OnPropertyChanged("Prenom"); } }
        public TypePersonne Type { get; set; }
        public int Age { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Adresse { get; set; }


        protected void OnPropertyChanged(string valeur)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(valeur));
            }
        }
    }
}
