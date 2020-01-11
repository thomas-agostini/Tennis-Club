using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TennisClub.Acteur;

namespace TennisClubWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Membre> membres;

        public MainWindow()
        {
            membres = new List<Membre>();
            // Remplir combobox typePersonne
            ComboBoxTypePersonne = new ComboBox();
            this.DataContext = membres;

            InitializeComponent();
            
            foreach (var element in Enum.GetValues(typeof(TypePersonne)))
                ComboBoxTypePersonne.Items.Add(element);
            ComboBoxTypePersonne.SelectedIndex = 0;

            ListViewJoueur.ItemsSource = membres;
        }

        #region - Fonctions boutons -

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjouterMembre_Click(object sender, RoutedEventArgs e)
        {
            Vider_champs();
        }

        /// <summary>
        /// Quand on clic sur le bouton "Enregistrer"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEnregistrer_Click(object sender, RoutedEventArgs e)
        {
            var typePersonne = ComboBoxTypePersonne.Text;
            var nom = TextBoxNom.Text;
            var prenom = TextBoxPrenom.Text;
            var naissance = TextBoxDateNaissance.Text;
            var adresse = TextBoxAdresse.Text;
            var compet = CheckBoxCompet.IsChecked;
            var membre = new Membre()
            {
                Nom = nom,
                Prenom = prenom,
                Adresse = adresse,
            };
            membres.Add(membre);
            Vider_champs();
        }

        #endregion

        #region - Fonctions globales -

        public void Vider_champs()
        {
            ComboBoxTypePersonne.SelectedIndex = 0;
            TextBoxNom.Text = "";
            TextBoxPrenom.Text = "";
            TextBoxDateNaissance.Text = "";
            TextBoxAdresse.Text = "";
            LabelCotisation.Content = "";
        }

        #endregion


        #region -Exit-

        /// <summary>
        /// Quand on clic sur le bouton "Quitter"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnQuitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }



        #endregion


        
    }
}
