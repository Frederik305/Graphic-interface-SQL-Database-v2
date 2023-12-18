using System.Windows.Forms;
using static DatabaseTools;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form_Fontions
{
    public partial class Main : Form
    {
        // Déclaration de variables pour les fenêtres de liste des tables et des requêtes
        ListTablesForm? ListTablesFormTest;
        ListRequestsForm? ListRequestsFormTest;

        // Informations de connexion à la base de données
        private string server;
        private string port;
        private string database;
        private string username;
        private string password;

        // Constructeur de la classe Main qui prend en paramètres les informations de connexion
        public Main(string server, string port, string database, string username, string password)
        {
            InitializeComponent();

            // Initialisation des informations de connexion à partir des paramètres
            this.server = server;
            this.port = port;
            this.database = database;
            this.username = username;
            this.password = password;
        }

        // Méthode exécutée lorsque le bouton "Afficher Tables" est cliqué
        private void afficheTables_Click(object sender, EventArgs e)
        {
            // Vérifie si la fenêtre de liste des tables existe déjà
            if (ListTablesFormTest == null)
            {
                // Si elle n'existe pas, crée une nouvelle instance en passant les informations de connexion
                ListTablesFormTest = new ListTablesForm(server, port, database, username, password);
            }

            // Affiche la fenêtre de liste des tables en mode dialogue
            ListTablesFormTest.ShowDialog();
        }

        // Méthode exécutée lorsque le bouton "Afficher Requêtes" est cliqué
        private void afficheRequests_Click(object sender, EventArgs e)
        {
            // Vérifie si la fenêtre de liste des requêtes existe déjà
            if (ListRequestsFormTest == null)
            {
                // Si elle n'existe pas, crée une nouvelle instance en passant les informations de connexion
                ListRequestsFormTest = new ListRequestsForm(server, port, database, username, password);
            }

            // Affiche la fenêtre de liste des requêtes en mode dialogue
            ListRequestsFormTest.ShowDialog();
        }

        // Méthode exécutée lorsque le bouton "Quitter" est cliqué
        private void Quit_Click(object sender, EventArgs e)
        {
            // Quitte l'application
            Application.Exit();
        }
    }
}