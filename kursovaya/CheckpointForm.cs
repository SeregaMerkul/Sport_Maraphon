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
    public partial class CheckpointForm : Form
    {
        public int checkpoint = 0;
        public CheckpointForm(int check)
        {
            InitializeComponent();
            checkpoint = check;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckpointForm_Load(object sender, EventArgs e)
        {
            switch (checkpoint)
            {
                case 1:
                    labelTEST.Text = "Checkpoint 1";
                    label2.Text = " — Стенд питья";
                    label3.Text = " — Мед. пункт";
                    label4.Text = " — Туалет";
                    label5.Text = " — Зона отдыха";                    
                    break;

                case 2:
                    labelTEST.Text = "Checkpoint 2";
                    label2.Text = " — Стенд питья";
                    label3.Text = " — Стенд закусок";
                    label4.Text = " — Мед. пункт";
                    label5.Text = " — Туалет";               
                    break;

                case 3:
                    labelTEST.Text = "Checkpoint 3";
                    label2.Text = " — Стенд питья";
                    label3.Text = " — Мед. пункт";
                    label4.Text = " — Туалет";
                    label5.Text = "";
                    break;

                case 4:
                    labelTEST.Text = "Checkpoint 4";
                    label2.Text = " — Стенд питья";
                    label3.Text = " — Мед. пункт";
                    label4.Text = " — Туалет";
                    label5.Text = " — Зона отдыха";
                    break;

                case 5:
                    labelTEST.Text = "Checkpoint 5";
                    label2.Text = " — Стенд питья";
                    label3.Text = " — Мед. пункт";
                    label4.Text = " — Туалет";
                    label5.Text = " — Зона отдыха";
                    break;

                case 6:
                    labelTEST.Text = "Checkpoint 6";
                    label2.Text = " — Стенд питья";
                    label3.Text = " — Мед. пункт";
                    label4.Text = " — Туалет";
                    label5.Text = " — Зона отдыха";
                    break;

                case 7:
                    labelTEST.Text = "Checkpoint 7";
                    label2.Text = " — Стенд питья";
                    label3.Text = " — Мед. пункт";
                    label4.Text = " — Туалет";
                    label5.Text = " — Зона отдыха";
                    break;

                case 8:
                    labelTEST.Text = "Checkpoint 8";
                    label2.Text = " — Стенд питья";
                    label3.Text = " — Мед. пункт";
                    label4.Text = " — Туалет";
                    label5.Text = " — Зона отдыха";
                    break;
            }
        }

        

    }
}
