using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace kursovaya
{
    public partial class MoreInfo : Form
    {

        private string filePath = "C:\\Users\\Matematika\\Desktop\\Защита КП СВ 20-31\\Меркулов Сергей\\ИС_спортивный марафон\\kursovaya\\Resources\\MoreInfoText.txt";
        public string aboba;
        public bool IsAdmin_Test;
        public int check = 0;
        public MoreInfo(bool IsAdmin)
        {
            IsAdmin_Test = IsAdmin;
            InitializeComponent();
        }

        private void test_Button5_Click(object sender, EventArgs e)
        {
            if (IsAdmin_Test)
            {


                test_Button5.Focus();
                this.Close();
                LogAdmin logAdmin = new LogAdmin();
                logAdmin.Show();
            }
            else
            {
                test_Button5.Focus();
                this.Close();
                MoreInfoMenu moreInfoMenu = new MoreInfoMenu();
                moreInfoMenu.Show();
            }
            
        }



        private void MoreInfo_Load(object sender, EventArgs e)
        {
            if (IsAdmin_Test) {

                label1.Click += label1_Click;
            }
            else
            {
                label1.Click -= label1_Click;
            }


            label1.Focus();
            pictureBox2.BackColor = Color.Transparent;
            label1.Text = "";
            if (File.Exists(filePath)) 
            {
                string text = File.ReadAllText(filePath).Replace("\r\n", "");
                StringBuilder sb = new StringBuilder();
                int charsPerLine = 35;
                int charCount = 0;
                foreach (char c in text)
                {
                    sb.Append(c);
                    charCount++;
                    if (charCount >= charsPerLine && c != ' ')
                    {
                        sb.AppendLine();
                        charCount = 0;
                    }
                }
                label1.Text = sb.ToString();
            }
    
        }
        private string[] SplitTextIntoBlocks(string text, int blockSize)
        {
            List<string> blocks = new List<string>();

            for (int i = 0; i < text.Length; i += blockSize)
            {
                int blockLength = Math.Min(blockSize, text.Length - i);
                string block = text.Substring(i, blockLength);
                blocks.Add(block);
            }

            return blocks.ToArray();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void test_Button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            check = 1;
            CheckpointForm checkpointForm    = new CheckpointForm(check);
            checkpointForm.Opacity = 0;
            checkpointForm.Show();
            for (int i = 0; i <= 100; i++)
            {
                checkpointForm.Opacity = i / 100.0;
                System.Threading.Thread.Sleep(1);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            TextBox textBox = new TextBox();
            textBox.Location = label1.Location;
            textBox.Font = label1.Font;
            textBox.Size = label1.Size;
            textBox.Multiline = true;
            textBox.Text = label1.Text;
            textBox.BorderStyle = BorderStyle.None;
            textBox.BackColor = this.BackColor;
            textBox.Leave += textBox_Leave;
            this.Controls.Add(textBox);
            textBox.Focus();
            label1.Hide();

            
        }

         private void textBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            label1.Text = textBox.Text;
            aboba = textBox.Text;
            this.Controls.Remove(textBox);
            
            label1.Show();
        }

        private void MoreInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsAdmin_Test)
            {
                File.WriteAllText(filePath, aboba);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            check = 2;
            CheckpointForm checkpointForm = new CheckpointForm(check);
            checkpointForm.Opacity = 0;
            checkpointForm.Show();
            for (int i = 0; i <= 100; i++)
            {
                checkpointForm.Opacity = i / 100.0;
                System.Threading.Thread.Sleep(1);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            check = 3;
            CheckpointForm checkpointForm = new CheckpointForm(check);
            checkpointForm.Opacity = 0;
            checkpointForm.Show();
            for (int i = 0; i <= 100; i++)
            {
                checkpointForm.Opacity = i / 100.0;
                System.Threading.Thread.Sleep(1);
            }
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            check = 4;
            CheckpointForm checkpointForm = new CheckpointForm(check);
            checkpointForm.Opacity = 0;
            checkpointForm.Show();
            for (int i = 0; i <= 100; i++)
            {
                checkpointForm.Opacity = i / 100.0;
                System.Threading.Thread.Sleep(1);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            check = 5;
            CheckpointForm checkpointForm = new CheckpointForm(check);
            checkpointForm.Opacity = 0;
            checkpointForm.Show();
            for (int i = 0; i <= 100; i++)
            {
                checkpointForm.Opacity = i / 100.0;
                System.Threading.Thread.Sleep(1);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            check = 6;
            CheckpointForm checkpointForm = new CheckpointForm(check);
            checkpointForm.Opacity = 0;
            checkpointForm.Show();
            for (int i = 0; i <= 100; i++)
            {
                checkpointForm.Opacity = i / 100.0;
                System.Threading.Thread.Sleep(1);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            check = 7;
            CheckpointForm checkpointForm = new CheckpointForm(check);
            checkpointForm.Opacity = 0;
            checkpointForm.Show();
            for (int i = 0; i <= 100; i++)
            {
                checkpointForm.Opacity = i / 100.0;
                System.Threading.Thread.Sleep(1);
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            check = 8;
            CheckpointForm checkpointForm = new CheckpointForm(check);
            checkpointForm.Opacity = 0;
            checkpointForm.Show();
            for (int i = 0; i <= 100; i++)
            {
                checkpointForm.Opacity = i / 100.0;
                System.Threading.Thread.Sleep(1);
            }
        }
    }
}
