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
    public partial class ThanksSponsors : Form
    {
        public ThanksSponsors()
        {
            InitializeComponent();
        }

        private void test_Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogSponsor logSponsor = new LogSponsor();
            logSponsor.Show();
        }

        private void test_Button5_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            LogSponsor logSponsor = new LogSponsor();
            logSponsor.Show();
        }

        private void test_Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthMenu authMenu = new AuthMenu();
            authMenu.Show();
        }

        private void ThanksSponsors_Load(object sender, EventArgs e)
        {

        }
    }
}
