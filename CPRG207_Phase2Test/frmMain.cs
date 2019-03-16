using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPRG207_Phase2Test
{
    public partial class frmMain : Form
    {

        public frmPackages activeFrmPackages = null;
        public frmProducts activeFrmProducts = null;
        public frmSuppliers activeFrmSuppliers = null;
        public frmHome activeFrmHome = null;

        public static frmMain Form1Instance;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPackages_Click(object sender, EventArgs e)
        {
            if (activeFrmPackages == null)
            {
                activeFrmPackages = new frmPackages();
                activeFrmPackages.MdiParent = this;
                activeFrmPackages.WindowState = FormWindowState.Maximized;
                activeFrmPackages.Show();
                activeFrmPackages.activeFrmMain = this;
                //activeFrmPackages.ControlBox = false;
            }
            else
            {
                activeFrmPackages.BringToFront();
                activeFrmPackages.WindowState = FormWindowState.Maximized;
            }
                
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            if (activeFrmProducts == null)
            {
                activeFrmProducts = new frmProducts();
                activeFrmProducts.MdiParent = this;
                activeFrmProducts.WindowState = FormWindowState.Maximized;
                activeFrmProducts.Show();
               // activeFrmProducts.ControlBox = false;
            }
            else
            {
                activeFrmProducts.BringToFront();
                activeFrmProducts.WindowState = FormWindowState.Maximized;
            }
                
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            if (activeFrmSuppliers == null)
            {
                activeFrmSuppliers = new frmSuppliers();
                activeFrmSuppliers.MdiParent = this;
                activeFrmSuppliers.WindowState = FormWindowState.Maximized;
                activeFrmSuppliers.Show();
               // activeFrmSuppliers.ControlBox = false;
            }
            else
            {
                activeFrmSuppliers.BringToFront();
                activeFrmSuppliers.WindowState = FormWindowState.Maximized;
            }    
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            activeFrmHome = new frmHome();
            activeFrmHome.MdiParent = this;
            activeFrmHome.WindowState = FormWindowState.Maximized;
            activeFrmHome.Show();
            activeFrmHome.activeFrmMain = this;
            //activeFrmHome.ControlBox = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeFrmHome == null)
            {
                activeFrmHome = new frmHome();
                activeFrmHome.MdiParent = this;
                activeFrmHome.WindowState = FormWindowState.Maximized;
                activeFrmHome.Show();
                activeFrmHome.activeFrmMain = this;
                //activeFrmHome.ControlBox = false;
            }
            else
            {
                activeFrmHome.BringToFront();
                activeFrmHome.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
