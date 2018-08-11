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
    public partial class Khachhang : Form
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        private MySqlDataAdapter mySqlDataAdapter;
        MySqlCommandBuilder update;
        public static string hotenkh ;
        public static int sdt;
        public static int cmnd;

        public static string hotennv ;
        public static int manhanvien;


        public Khachhang()
        {
            InitializeComponent();
            server = "localhost";
            database = "lvtn";
            uid = "root";
            password = "vanthinh";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";Charset=utf8;";
            connection = new MySqlConnection(connectionString);
        }
        DataSet DS = new DataSet();
        public void Khachhang_Load(object sender, EventArgs e)
        {
            connection.Open();
            mySqlDataAdapter = new MySqlDataAdapter("select * from lvtn.khachhang", connection);
            
            mySqlDataAdapter.Fill(DS,"lvtn.khachhang");
            dataGridView1.DataSource = DS.Tables[0];
            connection.Close();
        }



        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                connection.Open();
                update = new MySqlCommandBuilder(mySqlDataAdapter);
                mySqlDataAdapter.Update(DS, "lvtn.khachhang");
                MessageBox.Show("Đã Cập Nhật");

            }
        }
    }
}
