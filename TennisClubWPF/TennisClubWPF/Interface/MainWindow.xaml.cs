using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
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

        ObservableCollection<Membre> membres;

        public MainWindow()
        {
            membres = new ObservableCollection<Membre>();
            // Remplir combobox typePersonne
            ComboBoxTypePersonne = new System.Windows.Controls.ComboBox(); 

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
                Type = (TypePersonne)Enum.Parse(typeof(TypePersonne), typePersonne),
                Nom = nom,
                Prenom = prenom,
                DateNaissance = DateTime.Parse(naissance),
                Adresse = adresse,
                Competition = bool.Parse(compet.ToString())
            };
            membres.Add(membre);
            Vider_champs();
        }

        /// <summary>
        /// Quand on selectionne un element dans la liste des joueurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListViewJoueur_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var itemSelected = (Membre)ListViewJoueur.SelectedItem;
            if (itemSelected != null)
            {
                ComboBoxTypePersonne.Text = itemSelected.Type.ToString();
                TextBoxNom.Text = itemSelected.Nom;
                TextBoxPrenom.Text = itemSelected.Prenom;
                TextBoxDateNaissance.Text = itemSelected.DateNaissance.ToString("dd/MM/yyyy");
                LabelAge.Content = itemSelected.Age;
                TextBoxAdresse.Text = itemSelected.Adresse;
                LabelCotisation.Content = itemSelected.Cotisation.ToString();
            }
        }

        /// <summary>
        /// Action pour supprimer un joueur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSuppr_Click(object sender, RoutedEventArgs e)
        {
            var itemSelected = (Membre)ListViewJoueur.SelectedItem;

            DialogResult myResult;
            myResult = System.Windows.Forms.MessageBox.Show("Are you really delete the item?", "Delete Confirmation",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (myResult == System.Windows.Forms.DialogResult.OK)
            {
                ListViewJoueur.SelectedItem = null;
                membres.Remove(itemSelected);
            }
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
