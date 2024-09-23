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
    public partial class MoreInfoMenu : Form
    {

        public bool IsAdmin = false;
        public MoreInfoMenu()
        {
            InitializeComponent();
        }

        private void test_Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FondsForm fondsForm = new FondsForm();
            fondsForm.Show();
        }

        private void test_Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glav glav = new Glav();
            glav.Show();
        }

        private void test_Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MoreInfo moreInfo = new MoreInfo(IsAdmin);
            moreInfo.Show();
        }

        private void MoreInfoMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
