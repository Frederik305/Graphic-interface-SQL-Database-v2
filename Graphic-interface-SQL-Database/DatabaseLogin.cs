using MySql.Data.MySqlClient;
using SqlFonctions;

namespace Form_Fontions
{
    public partial class DatabaseLogin : Form
    {
        Main? OpenMain;

        public DatabaseLogin()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            serverTextBox = new TextBox();
            databaseTextBox = new TextBox();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            connectButton = new Button();
            button1 = new Button();
            this.textBox1 = new TextBox();
            SuspendLayout();
            // 
            // serverTextBox
            // 
            serverTextBox.Location = new Point(80, 73);
            serverTextBox.MaximumSize = new Size(220, 23);
            serverTextBox.MinimumSize = new Size(96, 23);
            serverTextBox.Name = "serverTextBox";
            serverTextBox.PlaceholderText = "Server Address";
            serverTextBox.Size = new Size(152, 23);
            serverTextBox.TabIndex = 0;
            // 
            // databaseTextBox
            // 
            databaseTextBox.Location = new Point(80, 102);
            databaseTextBox.MaximumSize = new Size(220, 23);
            databaseTextBox.MinimumSize = new Size(96, 23);
            databaseTextBox.Name = "databaseTextBox";
            databaseTextBox.PlaceholderText = "Database Name";
            databaseTextBox.Size = new Size(220, 23);
            databaseTextBox.TabIndex = 1;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(80, 131);
            usernameTextBox.MaximumSize = new Size(220, 23);
            usernameTextBox.MinimumSize = new Size(96, 23);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PlaceholderText = "Username";
            usernameTextBox.Size = new Size(220, 23);
            usernameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(80, 160);
            passwordTextBox.MaximumSize = new Size(220, 23);
            passwordTextBox.MinimumSize = new Size(96, 23);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.PlaceholderText = "Password";
            passwordTextBox.Size = new Size(220, 23);
            passwordTextBox.TabIndex = 3;
            // 
            // connectButton
            // 
            connectButton.Location = new Point(134, 189);
            connectButton.MaximumSize = new Size(193, 40);
            connectButton.MinimumSize = new Size(75, 23);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(98, 40);
            connectButton.TabIndex = 4;
            connectButton.Text = "Connect";
            connectButton.Click += ConnectButton_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(379, 102);
            button1.Name = "button1";
            button1.Size = new Size(135, 67);
            button1.TabIndex = 5;
            button1.Text = "bouton Nancy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            this.textBox1.Location = new Point(238, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Port";
            this.textBox1.Size = new Size(62, 23);
            this.textBox1.TabIndex = 6;
            // 
            // DatabaseLogin
            // 
            ClientSize = new Size(536, 298);
            Controls.Add(this.textBox1);
            Controls.Add(button1);
            Controls.Add(serverTextBox);
            Controls.Add(databaseTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(connectButton);
            MaximumSize = new Size(552, 337);
            MinimumSize = new Size(507, 292);
            Name = "DatabaseLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            // Récupérer les informations du serveur, de la base de données, de l'utilisateur et du mot de passe depuis les TextBox
            string server = serverTextBox.Text;
            string port = textBox1.Text;
            string database = databaseTextBox.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            // Définir la chaîne de connexion en utilisant les informations ci-dessus
            CreateConnectionString.SetConnectionString(server, port, database, username, password);

            // Obtenir une connexion MySQL
            MySqlConnection connection = ConnectionSqlDatabase.GetMySqlConnection(server, port, database, username, password);

            if (connection != null)
            {
                try
                {
                    // Ouvrir la connexion à la base de données
                    connection.Open();
                    this.Hide();
                    MessageBox.Show($"Connection successful a {database} comme {username}!");
                    if (OpenMain == null)
                    {
                        // Créer une nouvelle instance de la fenêtre Main avec les informations de connexion
                        OpenMain = new Main(server, port, database, username, password);
                    }
                    // Afficher la fenêtre Main
                    OpenMain.ShowDialog();

                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    // Fermer la connexion, quelle que soit l'issue
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Connection failed.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ces actions sont similaires à celles de ConnectButton_Click, mais elles utilisent des valeurs par défaut
            // pour le serveur, la base de données, l'utilisateur et le mot de passe.

            string server = "127.0.0.1";
            string port = "3308";
            string database = "evenementsport";
            string username = "root";
            string password = "";

            // Définir la chaîne de connexion en utilisant les valeurs par défaut
            CreateConnectionString.SetConnectionString(server, port, database, username, password);

            // Obtenir une connexion MySQL
            MySqlConnection connection = ConnectionSqlDatabase.GetMySqlConnection(server, port, database, username, password);

            if (connection != null)
            {
                try
                {
                    // Ouvrir la connexion à la base de données
                    connection.Open();
                    this.Hide();
                    MessageBox.Show($"Connection successful a {database} comme {username}!");
                    if (OpenMain == null)
                    {
                        // Créer une nouvelle instance de la fenêtre Main avec les valeurs par défaut
                        OpenMain = new Main(server, port, database, username, password);
                    }
                    // Afficher la fenêtre Main
                    OpenMain.ShowDialog();

                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    // Fermer la connexion, quelle que soit l'issue
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Connection failed.");
            }
        }
    }
}