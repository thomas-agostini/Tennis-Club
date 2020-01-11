using System.Collections.Generic;
using TennisClub.Acteur;

namespace TennisClub.Evenements
{
    public class Competition
    {
        public string Nom { get; set; }
        public bool Domicile { get; set; }
        public List<Equipe> Equipes { get; set; }
        /// <summary>
        /// Type = Simple, Double
        /// </summary>
        public TypeCompetition Type { get; set; }
        public TypePersonne TypeJoueur { get; set; }
        public int NbMatch { get; set; }
        public int Duree { get; set; }
        public NiveauCompetition Niveau { get; set; }
        public int nbJoueurMini { get; set; }
        public bool annule { get; set; }

        // Check nbJoueur Mini avec la taille de la liste des joueurs
        // verifier niveau des joueurs avec celle de la compettition

    }
}
