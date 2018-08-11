using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LVTN_V2
{
    public partial class QuetRFID : Form
    {
        public QuetRFID()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if(progressBar1.Value == 10)
            {
                progressBar1.Value = 0;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            

            if(e.KeyCode == Keys.Enter)
            {
                ThanhToan.mathe = NhanVien.mathe = Convert.ToInt32(textBox1.Text);
                
             //   MessageBox.Show("OK");
                Close();
            }
            
        }

        private void QuetRFID_Load(object sender, EventArgs e)
        {

        }
    }
}
