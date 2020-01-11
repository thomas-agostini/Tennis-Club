using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisClub.Activites;
using TennisClub.Evenements;

namespace TennisClub.Acteur
{
    public class Membre : Personne
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Attribut pour savoir si un membre fait de la competition ou non
        /// </summary>
        public bool Competition { get; set; }
        /// <summary>
        /// Liste des cours du membre
        /// </summary>
        public List<Cours> Cours { get; set; }
        /// <summary>
        ///  Classement du membre dans les competitions
        /// </summary>
        public ClassementCompetition Classement { get; set; }
        /// <summary>
        ///  Si le membre est résident de la ville  du club
        /// </summary>
        public bool Habitant { get; set; }
        /// <summary>
        ///  Cotisation du membre envers le club pour les competitions
        /// </summary>
        public int Cotisation { get; set; }
        /// <summary>
        /// Liste des competitions d'un joueur
        /// </summary>
        public List<Competition> Competitions { get; set; }
        /// <summary>
        /// Score du joueur
        /// </summary>
        public int Score { get; set; }


        /// <summary>
        ///  Constructeur de la classe
        /// </summary>
        public Membre()
        {
            Competitions = new List<Competition>();
        }



        /// <summary>
        /// Methode pour ajouter un cours à un membre
        /// </summary>
        /// <param name="cours"></param>
        public void AjouterCours(Cours cours)
        {
            Cours.Add(cours);
        }
    }
}
