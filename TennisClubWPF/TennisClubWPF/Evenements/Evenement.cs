using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisClub.Acteur;

namespace TennisClub.Evenements
{
    public class Evenement
    {
        public List<Membre> Joueurs { get; set; }
        public List<Entraineur> Entraineurs { get; set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        public Evenement()
        {
            Joueurs = new List<Membre>();
            Entraineurs = new List<Entraineur>();
        }

        // Verifier que les deux entraineurs sont présent lors d'une evenement
    }
}
