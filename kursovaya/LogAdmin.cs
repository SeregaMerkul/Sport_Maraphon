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
    public partial class LogAdmin : Form
    {
        public bool IsAdmin = true;
        public LogAdmin()
        {
            InitializeComponent();
        }

        private void test_Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glav glav = new Glav();
            glav.Show();
        }

        private void test_Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthMenu authMenu = new AuthMenu();
            authMenu.Show();
        }

        private void test_Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users users = new Users();
            users.Show();
        }

        private void test_Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFonds addFonds = new AddFonds();
            addFonds.Show();
        }

        private void test_Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MoreInfo moreInfo = new MoreInfo(IsAdmin);
            moreInfo.Show();
        }

        private void test_Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            SponsorsMenu sponsorsMenu = new SponsorsMenu();
            sponsorsMenu.Show();
        }

        private void test_Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResultsForm resultsForm = new ResultsForm();
            resultsForm.Show();
        }

        private void LogAdmin_Load(object sender, EventArgs e)
        {
            if (AuthUser.Finish_Marahon)
            {
                test_Button7.Visible = true;
            }
            else
            {
                test_Button7.Visible = false;
            }
        }
    }
}
