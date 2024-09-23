using kursovaya.Components;
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
    public partial class WantRunner : ShadowedForm
    {
        public WantRunner()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void test_Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glav glav = new Glav();
            glav.Show();
        }

        private void test_Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthMenu authMenu = new AuthMenu();
            authMenu.Show();
        }

        private void test_Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthMenu authMenu = new AuthMenu();
            authMenu.Show();
        }

        private void test_Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegRunner regRunner = new RegRunner();
            regRunner.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void WantRunner_Load(object sender, EventArgs e)
        {


        }
    }
}
