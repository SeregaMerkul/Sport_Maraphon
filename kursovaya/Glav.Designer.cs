namespace kursovaya
{
    partial class Glav
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glav));
            this.label1 = new System.Windows.Forms.Label();
            this.formDesign1 = new kursovaya.Components.FormDesign(this.components);
            this.test_Button1 = new kursovaya.Components.Test_Button();
            this.test_Button2 = new kursovaya.Components.Test_Button();
            this.test_Button3 = new kursovaya.Components.Test_Button();
            this.test_Button4 = new kursovaya.Components.Test_Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(286, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "MARATHON SKILLS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // formDesign1
            // 
            this.formDesign1.Form = this;
            this.formDesign1.FormStyle = kursovaya.Components.FormDesign.fStyle.None;
            // 
            // test_Button1
            // 
            this.test_Button1.BackColor = System.Drawing.Color.Transparent;
            this.test_Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.test_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_Button1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test_Button1.ForeColor = System.Drawing.Color.Black;
            this.test_Button1.Location = new System.Drawing.Point(281, 236);
            this.test_Button1.Name = "test_Button1";
            this.test_Button1.Rounding = 30;
            this.test_Button1.RoundingEnable = true;
            this.test_Button1.Size = new System.Drawing.Size(376, 98);
            this.test_Button1.TabIndex = 5;
            this.test_Button1.Text = "Я хочу стать бегуном";
            this.test_Button1.Click += new System.EventHandler(this.test_Button1_Click);
            // 
            // test_Button2
            // 
            this.test_Button2.BackColor = System.Drawing.Color.Transparent;
            this.test_Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_Button2.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.test_Button2.ForeColor = System.Drawing.Color.Black;
            this.test_Button2.Location = new System.Drawing.Point(281, 359);
            this.test_Button2.Name = "test_Button2";
            this.test_Button2.Rounding = 30;
            this.test_Button2.RoundingEnable = true;
            this.test_Button2.Size = new System.Drawing.Size(376, 98);
            this.test_Button2.TabIndex = 6;
            this.test_Button2.Text = "Я хочу стать спонсором марафона";
            this.test_Button2.Click += new System.EventHandler(this.test_Button2_Click);
            // 
            // test_Button3
            // 
            this.test_Button3.BackColor = System.Drawing.Color.Transparent;
            this.test_Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_Button3.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.test_Button3.ForeColor = System.Drawing.Color.Black;
            this.test_Button3.Location = new System.Drawing.Point(281, 483);
            this.test_Button3.Name = "test_Button3";
            this.test_Button3.Rounding = 30;
            this.test_Button3.RoundingEnable = true;
            this.test_Button3.Size = new System.Drawing.Size(376, 98);
            this.test_Button3.TabIndex = 7;
            this.test_Button3.Text = "Я хочу узнать больше о событии";
            this.test_Button3.Click += new System.EventHandler(this.test_Button3_Click);
            // 
            // test_Button4
            // 
            this.test_Button4.BackColor = System.Drawing.Color.Transparent;
            this.test_Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_Button4.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.test_Button4.ForeColor = System.Drawing.Color.Black;
            this.test_Button4.Location = new System.Drawing.Point(801, 565);
            this.test_Button4.Name = "test_Button4";
            this.test_Button4.Rounding = 40;
            this.test_Button4.RoundingEnable = true;
            this.test_Button4.Size = new System.Drawing.Size(134, 55);
            this.test_Button4.TabIndex = 8;
            this.test_Button4.Text = "Login";
            this.test_Button4.Click += new System.EventHandler(this.test_Button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(392, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Москва, Россия\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(331, 644);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(442, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "осталось времени до старта марфона!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(320, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "суббота, 21 апреля 2023 года";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTime.Location = new System.Drawing.Point(221, 646);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(59, 29);
            this.labelTime.TabIndex = 12;
            this.labelTime.Text = "time";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Glav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 687);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.test_Button4);
            this.Controls.Add(this.test_Button3);
            this.Controls.Add(this.test_Button2);
            this.Controls.Add(this.test_Button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Glav";
            this.Text = "Marathon Skills";
            this.Load += new System.EventHandler(this.Glav_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Components.FormDesign formDesign1;
        private Components.Test_Button test_Button1;
        private Components.Test_Button test_Button4;
        private Components.Test_Button test_Button3;
        private Components.Test_Button test_Button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTime;
    }
}

