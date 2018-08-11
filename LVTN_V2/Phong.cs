using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace LVTN_V2
{
    public partial class Phong : Form
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        private MySqlDataAdapter mySqlDataAdapter;
        MySqlCommandBuilder update;

        public DataSet DS = new DataSet();
        public Phong()
        {
            InitializeComponent();

            server = "localhost";
            database = "lvtn";
            uid = "root";
            password = "vanthinh";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);


        }

        private void Phong_Load(object sender, EventArgs e)
        {
            connection.Open();
            mySqlDataAdapter = new MySqlDataAdapter("select * from lvtn.phong", connection);

            mySqlDataAdapter.Fill(DS, "lvtn.phong");
            dataGridView1.DataSource = DS.Tables[0];
            connection.Close();
        }
    }
}
