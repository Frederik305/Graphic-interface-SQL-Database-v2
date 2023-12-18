using MySql.Data.MySqlClient;

namespace SqlFonctions
{
    // Classe ConnectionSqlDatabase pour obtenir une connexion MySQL à partir de la chaîne de connexion
    public class ConnectionSqlDatabase
    {
        // Méthode pour obtenir une instance de MySqlConnection à partir des paramètres de connexion
        public static MySqlConnection GetMySqlConnection(string server, string database, string username, string password, string port)
        {
            // Récupère la chaîne de connexion préalablement configurée
            string connectionString = CreateConnectionString.ConnectionString;

            try
            {
                // Crée une nouvelle connexion MySQL en utilisant la chaîne de connexion
                MySqlConnection connection = new MySqlConnection(connectionString);
                return connection; // Retourne la connexion créée
            }
            catch (MySqlException ex)
            {
                // En cas d'erreur lors de la création de la connexion, affiche un message d'erreur
                Console.WriteLine($"Erreur de connection: {ex.Message}");
                return null; // Retourne null pour indiquer qu'il y a eu une erreur
            }
        }
    }
    // Classe statique Configuration pour gérer la chaîne de connexion à la base de données
    public static class CreateConnectionString
    {
        // Propriété pour stocker la chaîne de connexion
        public static string ConnectionString { get; private set; }

        // Méthode pour définir la chaîne de connexion en fonction des paramètres fournis
        public static void SetConnectionString(string server, string port, string database, string username, string password)
        {
            // Construit la chaîne de connexion en utilisant les paramètres fournis
            ConnectionString = $"Server={server};Port={port};Database={database};User={username};Password={password};";
        }
    }
}