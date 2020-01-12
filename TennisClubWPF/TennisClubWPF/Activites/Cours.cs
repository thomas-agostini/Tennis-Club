using System.Collections.Generic;
using TennisClub.Acteur;

namespace TennisClub.Activites
{
    public class Cours
    {
        public List<Membre> Participants;
        public string Nom;

        public Cours ()
        {
            Participants = new List<Membre>();
        }

    }
}
