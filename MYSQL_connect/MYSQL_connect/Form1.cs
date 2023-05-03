using MySql.Data.MySqlClient;

namespace MYSQL_connect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            lbData.Items.Clear();

            string ConnectionString = "server=localhost;user=root;database=fullstackweb;port=3306;password=janidulnkg1@gmail.com";
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT email FROM user;", conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lbData.Items.Add(reader.GetString(0));
            }
            reader.Close();
            cmd.Dispose();
            conn.Close();

        }
    }
}