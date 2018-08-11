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
    public partial class ThanhToan : Form
    {
        public static int mathe;
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        private MySqlDataAdapter mySqlDataAdapter;
        DataSet DS = new DataSet();
        public ThanhToan()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;
            System.Net.ServicePointManager.Expect100Continue = false;


            server = "localhost";
            database = "lvtn";
            uid = "root";
            password = "vanthinh";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
            connection.Open();


        }
        QuetRFID mau1 = new QuetRFID();
            
        private void ThanhToan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.DataTable' table. You can move, or remove it, as needed.
            timer1.Enabled = true;

            mau1.ShowDialog();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mau1.Visible == true)
            {
                ;
            }
            else
            {
                timer1.Enabled = false;

                DS.Clear();
                mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM lvtn.hoadon where idhoadon like " + mathe, connection);

                mySqlDataAdapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];

                backgroundWorker1.RunWorkerAsync();
            }


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            this.DataTableTableAdapter.Fill(this.DataSet1.DataTable, mathe);

            this.reportViewer1.RefreshReport();

            connection.Close();
        }


    }
}
