namespace kursovaya
{
    partial class WantRunner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WantRunner));
            this.formDesign1 = new kursovaya.Components.FormDesign(this.components);
            this.test_Button3 = new kursovaya.Components.Test_Button();
            this.test_Button2 = new kursovaya.Components.Test_Button();
            this.test_Button4 = new kursovaya.Components.Test_Button();
            this.test_Button1 = new kursovaya.Components.Test_Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // formDesign1
            // 
            this.formDesign1.Form = this;
            this.formDesign1.FormStyle = kursovaya.Components.FormDesign.fStyle.None;
            // 
            // test_Button3
            // 
            this.test_Button3.BackColor = System.Drawing.Color.Transparent;
            this.test_Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_Button3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test_Button3.ForeColor = System.Drawing.Color.Black;
            this.test_Button3.Location = new System.Drawing.Point(389, 431);
            this.test_Button3.Margin = new System.Windows.Forms.Padding(4);
            this.test_Button3.Name = "test_Button3";
            this.test_Button3.Rounding = 30;
            this.test_Button3.RoundingEnable = true;
            this.test_Button3.Size = new System.Drawing.Size(501, 121);
            this.test_Button3.TabIndex = 9;
            this.test_Button3.Text = "Я новый участник";
            this.test_Button3.Click += new System.EventHandler(this.test_Button3_Click);
            // 
            // test_Button2
            // 
            this.test_Button2.BackColor = System.Drawing.Color.Transparent;
            this.test_Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_Button2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test_Button2.ForeColor = System.Drawing.Color.Black;
            this.test_Button2.Location = new System.Drawing.Point(389, 278);
            this.test_Button2.Margin = new System.Windows.Forms.Padding(4);
            this.test_Button2.Name = "test_Button2";
            this.test_Button2.Rounding = 30;
            this.test_Button2.RoundingEnable = true;
            this.test_Button2.Size = new System.Drawing.Size(501, 121);
            this.test_Button2.TabIndex = 8;
            this.test_Button2.Text = "Я участвовал ранее";
            this.test_Button2.Click += new System.EventHandler(this.test_Button2_Click);
            // 
            // test_Button4
            // 
            this.test_Button4.BackColor = System.Drawing.Color.Transparent;
            this.test_Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_Button4.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.test_Button4.ForeColor = System.Drawing.Color.Black;
            this.test_Button4.Location = new System.Drawing.Point(1085, 702);
            this.test_Button4.Margin = new System.Windows.Forms.Padding(4);
            this.test_Button4.Name = "test_Button4";
            this.test_Button4.Rounding = 40;
            this.test_Button4.RoundingEnable = true;
            this.test_Button4.Size = new System.Drawing.Size(179, 68);
            this.test_Button4.TabIndex = 10;
            this.test_Button4.Text = "Login";
            this.test_Button4.Click += new System.EventHandler(this.test_Button4_Click);
            // 
            // test_Button1
            // 
            this.test_Button1.BackColor = System.Drawing.Color.Transparent;
            this.test_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_Button1.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.test_Button1.ForeColor = System.Drawing.Color.Black;
            this.test_Button1.Location = new System.Drawing.Point(29, 14);
            this.test_Button1.Margin = new System.Windows.Forms.Padding(4);
            this.test_Button1.Name = "test_Button1";
            this.test_Button1.Rounding = 40;
            this.test_Button1.RoundingEnable = true;
            this.test_Button1.Size = new System.Drawing.Size(179, 68);
            this.test_Button1.TabIndex = 11;
            this.test_Button1.Text = "Назад";
            this.test_Button1.Click += new System.EventHandler(this.test_Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(237, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 57);
            this.label1.TabIndex = 12;
            this.label1.Text = "MARATHON SKILLS";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // WantRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 850);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.test_Button1);
            this.Controls.Add(this.test_Button4);
            this.Controls.Add(this.test_Button3);
            this.Controls.Add(this.test_Button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WantRunner";
            this.Text = "WantRunner";
            this.Load += new System.EventHandler(this.WantRunner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Components.FormDesign formDesign1;
        private Components.Test_Button test_Button3;
        private Components.Test_Button test_Button2;
        private Components.Test_Button test_Button4;
        private Components.Test_Button test_Button1;
        private System.Windows.Forms.Label label1;
    }
}