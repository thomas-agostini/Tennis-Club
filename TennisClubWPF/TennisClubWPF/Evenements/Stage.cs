using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisClub.Acteur;

namespace TennisClub.Evenements
{
    public class Stage
    {
        public Entraineur Encadrant { get; set; }
        public int Age { get; set; }
        public ClassementCompetition Niveau { get; set; }
        public List<Membre> Joueurs { get; set; }

        public Stage (int age)
        {
                Joueurs = new List<Membre>();
                if (age > 18)
                    Console.Write("Age non conforme");
                else
                    Age = age;
        }

        // verifier pas plus de 5 jouerus et le niveau des joueurs
    }
}
