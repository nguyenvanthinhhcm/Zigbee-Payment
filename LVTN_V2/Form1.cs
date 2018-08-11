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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Text.Length == 0)
            {
                string s = "BỘ MÔN ĐIỆN TỬ - LUẬN VĂN TỐT NGHIỆP - GVHD: LÊ CHÍ THÔNG - SVTH: NGUYỄN VĂN THỊNH";
                Graphics graphics = this.CreateGraphics();

                while (true)
                {
                    SizeF size = graphics.MeasureString(" " + s, this.Font);
                    if ((int)size.Width > (this.Width - 160))
                        break;
                    else
                        s = " " + s;
                }

                this.Text = s;
            }
            else
            {
                this.Text = this.Text.Substring(1, this.Text.Length - 1);
            }
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panel1.Controls.Clear();
            NhanVien mau = new NhanVien();
            mau.TopLevel = false;
            mau.Dock = System.Windows.Forms.DockStyle.Fill;
            mau.Show();
            panel1.Controls.Add(mau);
         //   panel1.Show();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panel1.Controls.Clear();
            Khachhang mau = new Khachhang();
            mau.TopLevel = false;
            mau.Dock = System.Windows.Forms.DockStyle.Fill;
            mau.Show();
            panel1.Controls.Add(mau);
          //  panel1.Show();
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panel1.Controls.Clear();
            Hoadon mau = new Hoadon();
            mau.TopLevel = false;
            mau.Dock = System.Windows.Forms.DockStyle.Fill;
            mau.Show();
            panel1.Controls.Add(mau);
         //   panel1.Show();
            DangKy dk = new DangKy();
            dk.ShowDialog();

        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panel1.Controls.Clear();
            ThanhToan mau = new ThanhToan();
            mau.TopLevel = false;
            mau.Dock = System.Windows.Forms.DockStyle.Fill;
            mau.Show();
            panel1.Controls.Add(mau);
         //   panel1.Show();
            
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panel1.Controls.Clear();
            Phong mau = new Phong();
            mau.TopLevel = false;
            mau.Dock = System.Windows.Forms.DockStyle.Fill;
            mau.Show();
            panel1.Controls.Add(mau);
         //   panel1.Show();
        }
    }
}
