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
    public partial class DangKy : Form
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        private MySqlDataAdapter mySqlDataAdapter;
        MySqlCommandBuilder update;



        public DangKy()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;


            server = "localhost";
            database = "lvtn";
            uid = "root";
            password = "vanthinh";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";Charset=utf8;";
            connection = new MySqlConnection(connectionString);



        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            connection.Open();

            string query = "INSERT INTO lvtn.khachhang(cmnd, hotenkh, phone) " +
                             "Values('" + Convert.ToInt32(txtcmnd.Text) + "', '" + txtHt.Text + "', '" + txtphone.Text + "')";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            int id = idhoadon();

            DateTime time = new DateTime();
            time = dateTimePicker1.Value;

            query = "INSERT INTO lvtn.hoadon(idhoadon, khachhang_hotenkh, khachhang_cmnd, nhanvien_hotennv, nhanvien_manhanvien, phong_idphong)" +
                            " Value(" + id + ",N'" + txtHt.Text + "'," + txtcmnd.Text + ",'Nguyen A',456789," + cbPhong.Text + ");";


            cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đăng Ký Thành Công");

        }

        private int idhoadon()
        {
            Random get = new Random();
            int so = get.Next(100000, 999999);
            return so;

        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }




    }
}
