using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovaya
{
    public partial class SponsorsMenu : Form
    {
        public SponsorsMenu()
        {
            InitializeComponent();
        }
        public bool IsAdmin;
        
        private void test_Button1_Click(object sender, EventArgs e)
        {
            IsAdmin = true;
            this.Hide();
            SponsorsForm sponsorsForm = new SponsorsForm(IsAdmin);
            sponsorsForm.Show();
        }

        private void test_Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SponsorsRequests sponsorsRequests = new SponsorsRequests();
            sponsorsRequests.Show();
        }

        private void test_Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogAdmin logAdmin = new LogAdmin();
            logAdmin.Show();
        }

        private void test_Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthMenu authMenu = new AuthMenu();
            authMenu.Show();
        }

        private void SponsorsMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
