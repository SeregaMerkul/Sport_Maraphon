namespace kursovaya
{
    partial class AuthMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.test_Button2 = new kursovaya.Components.Test_Button();
            this.test_Button4 = new kursovaya.Components.Test_Button();
            this.test_Button1 = new kursovaya.Components.Test_Button();
            this.formDesign1 = new kursovaya.Components.FormDesign(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(331, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Форма авторизации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(15, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(917, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пожалуйста, авторизуйтесь в системе, используя ваш адрес электронной почты\r\n и па" +
    "роль.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(179, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(140, 328);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(304, 266);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(338, 36);
            this.textBoxLogin.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBoxLogin, "Введите E-mail");
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            this.textBoxLogin.Leave += new System.EventHandler(this.textBoxLogin_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(176, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(381, 45);
            this.label5.TabIndex = 14;
            this.label5.Text = "MARATHON SKILLS";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(304, 325);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(338, 36);
            this.textBoxPassword.TabIndex = 17;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // test_Button2
            // 
            this.test_Button2.BackColor = System.Drawing.Color.Transparent;
            this.test_Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_Button2.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.test_Button2.ForeColor = System.Drawing.Color.Black;
            this.test_Button2.Location = new System.Drawing.Point(475, 401);
            this.test_Button2.Name = "test_Button2";
            this.test_Button2.Rounding = 40;
            this.test_Button2.RoundingEnable = true;
            this.test_Button2.Size = new System.Drawing.Size(161, 62);
            this.test_Button2.TabIndex = 16;
            this.test_Button2.Text = "Cancel";
            this.test_Button2.Click += new System.EventHandler(this.test_Button2_Click);
            // 
            // test_Button4
            // 
            this.test_Button4.BackColor = System.Drawing.Color.Transparent;
            this.test_Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_Button4.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.test_Button4.ForeColor = System.Drawing.Color.Black;
            this.test_Button4.Location = new System.Drawing.Point(266, 401);
            this.test_Button4.Name = "test_Button4";
            this.test_Button4.Rounding = 40;
            this.test_Button4.RoundingEnable = true;
            this.test_Button4.Size = new System.Drawing.Size(161, 62);
            this.test_Button4.TabIndex = 15;
            this.test_Button4.Text = "Login";
            this.test_Button4.Click += new System.EventHandler(this.test_Button4_Click);
            // 
            // test_Button1
            // 
            this.test_Button1.BackColor = System.Drawing.Color.Transparent;
            this.test_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_Button1.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.test_Button1.ForeColor = System.Drawing.Color.Black;
            this.test_Button1.Location = new System.Drawing.Point(20, 8);
            this.test_Button1.Name = "test_Button1";
            this.test_Button1.Rounding = 40;
            this.test_Button1.RoundingEnable = true;
            this.test_Button1.Size = new System.Drawing.Size(134, 55);
            this.test_Button1.TabIndex = 13;
            this.test_Button1.Text = "Назад";
            this.test_Button1.Click += new System.EventHandler(this.test_Button1_Click);
            // 
            // formDesign1
            // 
            this.formDesign1.Form = this;
            this.formDesign1.FormStyle = kursovaya.Components.FormDesign.fStyle.None;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // AuthMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 687);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.test_Button2);
            this.Controls.Add(this.test_Button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.test_Button1);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AuthMenu";
            this.Text = "AuthMenu";
            this.Load += new System.EventHandler(this.AuthMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLogin;
        private Components.FormDesign formDesign1;
        private System.Windows.Forms.Label label5;
        private Components.Test_Button test_Button1;
        private Components.Test_Button test_Button4;
        private Components.Test_Button test_Button2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}