using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospitall_Project
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Client_Menu_Click(object sender, EventArgs e)
        {
            FrmClien f=new FrmClien();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();   

        }

        private void Medicine_Menu_Click(object sender, EventArgs e)
        {
            FrmMedicine f = new FrmMedicine();  
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }


        private void Position_Menu_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void AllStuff_Menu_Click(object sender, EventArgs e)
        {
            FrmStuff f = new FrmStuff();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void Tool_Menu_Click(object sender, EventArgs e)
        {
            FrmTool f = new FrmTool();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void Room_Menu_Click(object sender, EventArgs e)
        {
            FrmRoom f = new FrmRoom();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void CheckIn_Click(object sender, EventArgs e)
        {
            FrmCheckIn f = new FrmCheckIn();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void CheckOut_Click(object sender, EventArgs e)
        {
            FrmCheckout f = new FrmCheckout();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void History_Menu_Click(object sender, EventArgs e)
        {
            FrmHistory f = new FrmHistory();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmHome f = new FrmHome();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }
    }
}
