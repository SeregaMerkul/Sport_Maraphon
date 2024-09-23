namespace kursovaya
{
    partial class MoreInfoMenu
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
            this.formDesign1 = new kursovaya.Components.FormDesign(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.test_Button2 = new kursovaya.Components.Test_Button();
            this.test_Button1 = new kursovaya.Components.Test_Button();
            this.test_Button5 = new kursovaya.Components.Test_Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // formDesign1
            // 
            this.formDesign1.Form = this;
            this.formDesign1.FormStyle = kursovaya.Components.FormDesign.fStyle.None;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(367, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Подробная информация";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // test_Button2
            // 
            this.test_Button2.BackColor = System.Drawing.Color.Transparent;
            this.test_Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.test_Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_Button2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Italic);
            this.test_Button2.ForeColor = System.Drawing.Color.Black;
            this.test_Button2.Location = new System.Drawing.Point(521, 196);
            this.test_Button2.Name = "test_Button2";
            this.test_Button2.Rounding = 30;
            this.test_Button2.RoundingEnable = true;
            this.test_Button2.Size = new System.Drawing.Size(376, 98);
            this.test_Button2.TabIndex = 59;
            this.test_Button2.Text = "Благотворительные фонды";
            this.test_Button2.Click += new System.EventHandler(this.test_Button2_Click);
            // 
            // test_Button1
            // 
            this.test_Button1.BackColor = System.Drawing.Color.Transparent;
            this.test_Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.test_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_Button1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Italic);
            this.test_Button1.ForeColor = System.Drawing.Color.Black;
            this.test_Button1.Location = new System.Drawing.Point(67, 196);
            this.test_Button1.Name = "test_Button1";
            this.test_Button1.Rounding = 30;
            this.test_Button1.RoundingEnable = true;
            this.test_Button1.Size = new System.Drawing.Size(376, 98);
            this.test_Button1.TabIndex = 58;
            this.test_Button1.Text = "Подробная информация марафона";
            this.test_Button1.Click += new System.EventHandler(this.test_Button1_Click);
            // 
            // test_Button5
            // 
            this.test_Button5.BackColor = System.Drawing.Color.Transparent;
            this.test_Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_Button5.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.test_Button5.ForeColor = System.Drawing.Color.Black;
            this.test_Button5.Location = new System.Drawing.Point(17, 11);
            this.test_Button5.Name = "test_Button5";
            this.test_Button5.Rounding = 40;
            this.test_Button5.RoundingEnable = true;
            this.test_Button5.Size = new System.Drawing.Size(134, 55);
            this.test_Button5.TabIndex = 60;
            this.test_Button5.Text = "Назад";
            this.test_Button5.Click += new System.EventHandler(this.test_Button5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(157, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(381, 45);
            this.label9.TabIndex = 62;
            this.label9.Text = "MARATHON SKILLS";
            // 
            // MoreInfoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 687);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.test_Button5);
            this.Controls.Add(this.test_Button2);
            this.Controls.Add(this.test_Button1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MoreInfoMenu";
            this.Text = "MoreInfoMenu";
            this.Load += new System.EventHandler(this.MoreInfoMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.FormDesign formDesign1;
        private System.Windows.Forms.Label label2;
        private Components.Test_Button test_Button2;
        private Components.Test_Button test_Button1;
        private Components.Test_Button test_Button5;
        private System.Windows.Forms.Label label9;
    }
}