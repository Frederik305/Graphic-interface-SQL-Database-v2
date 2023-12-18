using MySql.Data.MySqlClient;
using SqlFonctions;
using static DatabaseTools;

namespace Form_Fontions
{
    // Classe ListRequestsForm pour afficher les résultats de requêtes spécifiques dans une DataGridView
    public partial class ListRequestsForm : Form
    {
        private string query;

        private string currentView;

        private string server;
        private string port;
        private string database;
        private string username;
        private string password;

        private MySqlConnection connection;
        private DatabaseTools dbTools;

        // Constructeur de la classe ListRequestsForm qui prend en paramètres les informations de connexion
        public ListRequestsForm(string server, string port, string database, string username, string password)
        {
            InitializeComponent();

            // Create a MySqlConnection using your ConnectionSqlDatabase class
            connection = ConnectionSqlDatabase.GetMySqlConnection(server, port, database, username, password);

            string query = $"SHOW FULL TABLES WHERE TABLE_TYPE = 'VIEW'";
            FillDataGrid.FillDataGridView(dataGridView2, server, port, database, username, password, query);
            ComboBoxUtils.PopulateComboBoxWithColumnData(dataGridView2, 0, comboBox2);

            this.server = server;
            this.port = port;
            this.database = database;
            this.username = username;
            this.password = password;
        }


        private void buttonAfficher_Click(object sender, EventArgs e)
        {
            currentView = comboBox2.SelectedItem as string;
            if (!string.IsNullOrEmpty(currentView))
            {
                // Requête SQL pour récupérer toutes les données de la table "joueur"
                query = $"SELECT * FROM {currentView}";

                // Appel de la fonction FillDataGridView pour remplir la grille de données avec les résultats de la requête
                FillDataGrid.FillDataGridView(dataGridView1, server, port, database, username, password, query);

                //popule combobox avec les columns de la table
                ComboBoxUtils.PopulateComboBoxWithColumnNames(dataGridView1, comboBox1);

                if (currentView == "vainqueur_f_du_tournoi_de_wimbledon")
                {
                    dataGridView1.Columns[0].HeaderText = "Nom";
                    dataGridView1.Columns[1].HeaderText = "Prenom";
                    dataGridView1.Columns[2].HeaderText = "Set 1";
                    dataGridView1.Columns[3].HeaderText = "Set 2";
                    dataGridView1.Columns[4].HeaderText = "Set 3";
                    dataGridView1.Columns[5].HeaderText = "Set 4";
                    dataGridView1.Columns[6].HeaderText = "Set 5";
                    dataGridView1.Columns[7].HeaderText = "Annee du tournoi";
                }
                else if (currentView == "hommes_participe_tournoi_roland_garros")
                {
                    dataGridView1.Columns[0].HeaderText = "Hommes qui ont participe au tournoi de Roland Garros";
                }
                else if (currentView == "nombre_participant_par_tournoi_annee_sexe")
                {
                    dataGridView1.Columns[0].HeaderText = "Nom du Tournoi";
                    dataGridView1.Columns[1].HeaderText = "Annee du Tournoi";
                    dataGridView1.Columns[2].HeaderText = "Sexe";
                    dataGridView1.Columns[3].HeaderText = "Nombre de participants";
                }
                else if (currentView == "joueur_scoretoustournoi_anneetournoi")
                {
                    dataGridView1.Columns[0].HeaderText = "Nom";
                    dataGridView1.Columns[1].HeaderText = "Prenom";
                    dataGridView1.Columns[2].HeaderText = "Nom tournoi";
                    dataGridView1.Columns[3].HeaderText = "Annee";
                    dataGridView1.Columns[4].HeaderText = "Set 1";
                    dataGridView1.Columns[5].HeaderText = "Set 2";
                    dataGridView1.Columns[6].HeaderText = "Set 3";
                    dataGridView1.Columns[7].HeaderText = "Set 4";
                    dataGridView1.Columns[8].HeaderText = "Set 5";
                }
            }
        }


        // Méthode exécutée lorsque le bouton "VainFTourWimbelton" est cliqué
        private void VainFTourWimbelton_Click(object sender, EventArgs e)
        {
            currentView = "vainqueur_f_du_tournoi_de_wimbledon";
            // Requête SQL pour récupérer toutes les données de la table "vainqueur_f_du_tournoi_de_wimbledon"
            string query = $"SELECT * FROM {currentView}";

            // Appel de la fonction FillDataGridView pour remplir la grille de données avec les résultats de la requête
            FillDataGrid.FillDataGridView(dataGridView1, server, port, database, username, password, query);

            ComboBoxUtils.PopulateComboBoxWithColumnNames(dataGridView1, comboBox1);

            dataGridView1.Columns[0].HeaderText = "Nom";
            dataGridView1.Columns[1].HeaderText = "Prenom";
            dataGridView1.Columns[2].HeaderText = "Set 1";
            dataGridView1.Columns[3].HeaderText = "Set 2";
            dataGridView1.Columns[4].HeaderText = "Set 3";
            dataGridView1.Columns[5].HeaderText = "Set 4";
            dataGridView1.Columns[6].HeaderText = "Set 5";
            dataGridView1.Columns[7].HeaderText = "Annee du tournoi";
        }

        // Méthode exécutée lorsque le bouton "Hommes_participe_tournoi_Roland_Garros" est cliqué
        private void Hommes_participe_tournoi_Roland_Garros_Click(object sender, EventArgs e)
        {
            currentView = "Hommes_participe_tournoi_Roland_Garros";
            // Requête SQL pour récupérer toutes les données de la table "Hommes_participe_tournoi_Roland_Garros"
            query = $"SELECT * FROM {currentView}";

            // Appel de la fonction FillDataGridView pour remplir la grille de données avec les résultats de la requête
            FillDataGrid.FillDataGridView(dataGridView1, server, port, database, username, password, query);

            ComboBoxUtils.PopulateComboBoxWithColumnNames(dataGridView1, comboBox1);

            dataGridView1.Columns[0].HeaderText = "Hommes qui ont participe au tournoi de Roland Garros";
        }

        // Méthode exécutée lorsque le bouton "Nombre_Participant_par_Tournoi_Annee_Sexe" est cliqué
        private void Nombre_Participant_par_Tournoi_Annee_Sexe_Click(object sender, EventArgs e)
        {
            currentView = "Nombre_Participant_par_Tournoi_Annee_Sexe";
            // Requête SQL pour récupérer toutes les données de la table "Nombre_Participant_par_Tournoi_Annee_Sexe"
            query = $"SELECT * FROM {currentView}";

            // Appel de la fonction FillDataGridView pour remplir la grille de données avec les résultats de la requête
            FillDataGrid.FillDataGridView(dataGridView1, server, port, database, username, password, query);

            ComboBoxUtils.PopulateComboBoxWithColumnNames(dataGridView1, comboBox1);

            dataGridView1.Columns[0].HeaderText = "Nom du Tournoi";
            dataGridView1.Columns[1].HeaderText = "Annee du Tournoi";
            dataGridView1.Columns[2].HeaderText = "Sexe";
            dataGridView1.Columns[3].HeaderText = "Nombre de participants";
        }

        // Méthode exécutée lorsque le bouton "Joueur_ScoreTousTournoi_AnneeTournoi" est cliqué
        private void Joueur_ScoreTousTournoi_AnneeTournoi_Click(object sender, EventArgs e)
        {
            currentView = "Joueur_ScoreTousTournoi_AnneeTournoi";
            // Requête SQL pour récupérer toutes les données de la table "Joueur_ScoreTousTournoi_AnneeTournoi"
            query = $"SELECT * FROM {currentView}";

            // Appel de la fonction FillDataGridView pour remplir la grille de données avec les résultats de la requête
            FillDataGrid.FillDataGridView(dataGridView1, server, port, database, username, password, query);

            ComboBoxUtils.PopulateComboBoxWithColumnNames(dataGridView1, comboBox1);

            dataGridView1.Columns[0].HeaderText = "Nom";
            dataGridView1.Columns[1].HeaderText = "Prenom";
            dataGridView1.Columns[2].HeaderText = "Nom tournoi";
            dataGridView1.Columns[3].HeaderText = "Annee";
            dataGridView1.Columns[4].HeaderText = "Set 1";
            dataGridView1.Columns[5].HeaderText = "Set 2";
            dataGridView1.Columns[6].HeaderText = "Set 3";
            dataGridView1.Columns[7].HeaderText = "Set 4";
            dataGridView1.Columns[8].HeaderText = "Set 5";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearDataGrid.ClearDataGridView(dataGridView1);
            ClearDataGrid.ClearDataGridView(dataGridView1);
            currentView = "";
            textBox1.Text = string.Empty;
            comboBox1.Text = "Column to seach in...";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string selectedColumnName = comboBox1.SelectedItem as string;
            string inputValue = textBox1.Text;

            if (string.IsNullOrEmpty(inputValue) || (string.IsNullOrEmpty(selectedColumnName))) { FillDataGrid.FillDataGridView(dataGridView1, server, port, database, username, password, query); }
            else
            {
                string whereClause = $"WHERE {selectedColumnName} LIKE '%{inputValue}%';";

                FillDataGrid.FillDataGridView(dataGridView1, server, port, database, username, password, $"SELECT * FROM {currentView}", whereClause);
            }
        }
    }
}