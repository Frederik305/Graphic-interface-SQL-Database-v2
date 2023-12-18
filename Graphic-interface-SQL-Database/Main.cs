using System.Windows.Forms;
using static DatabaseTools;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form_Fontions
{
    public partial class Main : Form
    {
        // D�claration de variables pour les fen�tres de liste des tables et des requ�tes
        ListTablesForm? ListTablesFormTest;
        ListRequestsForm? ListRequestsFormTest;

        // Informations de connexion � la base de donn�es
        private string server;
        private string port;
        private string database;
        private string username;
        private string password;

        // Constructeur de la classe Main qui prend en param�tres les informations de connexion
        public Main(string server, string port, string database, string username, string password)
        {
            InitializeComponent();

            // Initialisation des informations de connexion � partir des param�tres
            this.server = server;
            this.port = port;
            this.database = database;
            this.username = username;
            this.password = password;
        }

        // M�thode ex�cut�e lorsque le bouton "Afficher Tables" est cliqu�
        private void afficheTables_Click(object sender, EventArgs e)
        {
            // V�rifie si la fen�tre de liste des tables existe d�j�
            if (ListTablesFormTest == null)
            {
                // Si elle n'existe pas, cr�e une nouvelle instance en passant les informations de connexion
                ListTablesFormTest = new ListTablesForm(server, port, database, username, password);
            }

            // Affiche la fen�tre de liste des tables en mode dialogue
            ListTablesFormTest.ShowDialog();
        }

        // M�thode ex�cut�e lorsque le bouton "Afficher Requ�tes" est cliqu�
        private void afficheRequests_Click(object sender, EventArgs e)
        {
            // V�rifie si la fen�tre de liste des requ�tes existe d�j�
            if (ListRequestsFormTest == null)
            {
                // Si elle n'existe pas, cr�e une nouvelle instance en passant les informations de connexion
                ListRequestsFormTest = new ListRequestsForm(server, port, database, username, password);
            }

            // Affiche la fen�tre de liste des requ�tes en mode dialogue
            ListRequestsFormTest.ShowDialog();
        }

        // M�thode ex�cut�e lorsque le bouton "Quitter" est cliqu�
        private void Quit_Click(object sender, EventArgs e)
        {
            // Quitte l'application
            Application.Exit();
        }
    }
}