using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisClub.Acteur;

namespace TennisClub.Evenements
{
    public class Equipe
    {
        public List<Membre> Joueurs { get; set; }
        public Competition Competition { get; set; }
        public Membre Capitaine { get; set; }

        /// <summary>
        ///  Constructor
        /// </summary>
        public Equipe()
        {
            Joueurs = new List<Membre>();
        }
    }
}
