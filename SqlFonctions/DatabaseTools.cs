using MySql.Data.MySqlClient;
using SqlFonctions;
using System.Data;
using System.Diagnostics;

public class DatabaseTools
{
    public class ComboBoxUtils
    {
        public static void PopulateComboBoxWithColumnNames(DataGridView dataGridView, ComboBox comboBox)
        {
            comboBox.Items.Clear();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                comboBox.Items.Add(column.HeaderText);
            }
        }
        public static void PopulateComboBoxWithColumnData(DataGridView dataGridView, int columnIndex, ComboBox comboBox)
        {
            comboBox.Items.Clear();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[columnIndex].Value != null)
                {
                    comboBox.Items.Add(row.Cells[columnIndex].Value.ToString());
                }
            }
        }
    }

    // Classe FillDataGrid pour remplir une DataGridView avec les résultats d'une requête
    public class FillDataGrid
    {
        // Méthode pour remplir une DataGridView avec les résultats d'une requête SQL
        public static void FillDataGridView(DataGridView dataGridView, string server, string port, string database, string username, string password, string query, string whereClause = null)
        {

            if (!string.IsNullOrEmpty(whereClause))
            {
                query += " " + whereClause;
            }
            // Obtenir une connexion MySQL en utilisant les informations de connexion
            MySqlConnection connection = ConnectionSqlDatabase.GetMySqlConnection(server, port, database, username, password);

            try
            {
                // Vérifier si la connexion est null (non réussie)
                if (connection == null)
                {
                    // Afficher un message de débogage et une boîte de dialogue d'erreur
                    Debug.WriteLine($"Connection status: {connection?.State}");
                    MessageBox.Show("Connection is null. Please check the database connection.");
                    return;
                }

                // Créer une commande MySQL avec la requête SQL et la connexion
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // Créer un adaptateur MySQL pour exécuter la commande
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                // Créer un DataTable pour stocker les résultats de la requête
                DataTable dataTable = new DataTable();

                // Remplir le DataTable avec les résultats de la requête
                adapter.Fill(dataTable);

                // Définir la source de données de la DataGridView sur le DataTable
                dataGridView.DataSource = dataTable;
            }
            catch (MySqlException ex)
            {
                // En cas d'erreur MySQL, afficher un message d'erreur
                // MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                // Assurer la fermeture de la connexion si elle est ouverte
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
    public class ClearDataGrid
    {
        public static void ClearDataGridView(DataGridView dataGridView)
        {
            if (dataGridView.DataSource is DataTable dataTable)
            {
                dataTable.Rows.Clear();
                dataGridView.Columns.Clear();
            }
            else 
            {
                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();
            }
        }
    }
    public class EditData
    {
        public string? EditedColumnName { get; set; }
        public string? ChangedValues { get; set; }
        public string? ColumnNameID { get; set; }
        public string? ValueID { get; set; }
    }
}
