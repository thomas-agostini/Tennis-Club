using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisClub.Activites;

namespace TennisClub.Acteur
{
    public class Entraineur
    {
        public bool Competition { get; set; }
        public bool Independant { get; set; }
        public List<Cours> Cours { get; set; }
    }
}
