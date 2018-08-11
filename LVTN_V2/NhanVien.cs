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
    public partial class NhanVien : Form
    {
        public static Int32 mathe = 0;
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        private MySqlDataAdapter mySqlDataAdapter;
        MySqlCommandBuilder update;


        public DataSet DS = new DataSet();

        public NhanVien()
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

        private void NhanVien_Load(object sender, EventArgs e)
        {
            connection.Open();
            mySqlDataAdapter = new MySqlDataAdapter("select * from lvtn.nhanvien", connection);

            mySqlDataAdapter.Fill(DS, "lvtn.nhanvien");
            dataGridView1.DataSource = DS.Tables[0];
            connection.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            QuetRFID mau = new QuetRFID();
            mau.ShowDialog();
            while(mau.Visible == true)
            {

            }
            DS.Tables[0].Rows.Add(Convert.ToInt32(txtMaNV.Text),txtHoten.Text,cbBopHan.Text,cbChucVu.Text,mathe);

            connection.Open();
            update = new MySqlCommandBuilder(mySqlDataAdapter);
            mySqlDataAdapter.Update(DS, "lvtn.nhanvien");

        }
        private void AddARow(DataTable table)
        {
            // Use the NewRow method to create a DataRow with 
            // the table's schema.
            DataRow newRow = table.NewRow();

            // Add the row to the rows collection.
            table.Rows.Add(newRow);
        }
    }
}
