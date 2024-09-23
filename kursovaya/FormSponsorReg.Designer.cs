namespace kursovaya
{
    partial class FormSponsorReg
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
            this.label9 = new System.Windows.Forms.Label();
            this.test_Button5 = new kursovaya.Components.Test_Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fondsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBase_Sport_MarathonDataSet2 = new kursovaya.DataBase_Sport_MarathonDataSet2();
            this.fondsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursovayaDataSet10 = new kursovaya.kursovayaDataSet10();
            this.test_Button1 = new kursovaya.Components.Test_Button();
            this.test_Button2 = new kursovaya.Components.Test_Button();
            this.fondsTableAdapter = new kursovaya.kursovayaDataSet10TableAdapters.FondsTableAdapter();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.fondsTableAdapter1 = new kursovaya.DataBase_Sport_MarathonDataSet2TableAdapters.FondsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fondsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_Sport_MarathonDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // formDesign1
            // 
            this.formDesign1.Form = this;
            this.formDesign1.FormStyle = kursovaya.Components.FormDesign.fStyle.None;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(201, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(486, 57);
            this.label9.TabIndex = 52;
            this.label9.Text = "MARATHON SKILLS";
            // 
            // test_Button5
            // 
            this.test_Button5.BackColor = System.Drawing.Color.Transparent;
            this.test_Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_Button5.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.test_Button5.ForeColor = System.Drawing.Color.Black;
            this.test_Button5.Location = new System.Drawing.Point(15, 11);
            this.test_Button5.Margin = new System.Windows.Forms.Padding(4);
            this.test_Button5.Name = "test_Button5";
            this.test_Button5.Rounding = 40;
            this.test_Button5.RoundingEnable = true;
            this.test_Button5.Size = new System.Drawing.Size(179, 68);
            this.test_Button5.TabIndex = 51;
            this.test_Button5.Text = "Назад";
            this.test_Button5.Click += new System.EventHandler(this.test_Button5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(355, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(552, 45);
            this.label6.TabIndex = 58;
            this.label6.Text = "Подача заявки на регистрацию";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(292, 208);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(355, 40);
            this.textBox1.TabIndex = 89;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label7.Location = new System.Drawing.Point(31, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 29);
            this.label7.TabIndex = 88;
            this.label7.Text = "Название компании:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(292, 271);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(355, 40);
            this.textBoxLogin.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(196, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 90;
            this.label1.Text = "E-Mail:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(819, 592);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(355, 40);
            this.textBox3.TabIndex = 93;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.Location = new System.Drawing.Point(537, 599);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 29);
            this.label2.TabIndex = 92;
            this.label2.Text = "Сумма пожертвования:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label4.Location = new System.Drawing.Point(212, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 29);
            this.label4.TabIndex = 94;
            this.label4.Text = "ИНН:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label15.Location = new System.Drawing.Point(203, 409);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 29);
            this.label15.TabIndex = 99;
            this.label15.Text = "Фонд:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DataSource = this.fondsBindingSource1;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 16.2F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(292, 402);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(355, 41);
            this.comboBox1.TabIndex = 98;
            this.comboBox1.ValueMember = "Id";
            // 
            // fondsBindingSource1
            // 
            this.fondsBindingSource1.DataMember = "Fonds";
            this.fondsBindingSource1.DataSource = this.dataBase_Sport_MarathonDataSet2;
            // 
            // dataBase_Sport_MarathonDataSet2
            // 
            this.dataBase_Sport_MarathonDataSet2.DataSetName = "DataBase_Sport_MarathonDataSet2";
            this.dataBase_Sport_MarathonDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fondsBindingSource
            // 
            this.fondsBindingSource.DataMember = "Fonds";
            this.fondsBindingSource.DataSource = this.kursovayaDataSet10;
            // 
            // kursovayaDataSet10
            // 
            this.kursovayaDataSet10.DataSetName = "kursovayaDataSet10";
            this.kursovayaDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // test_Button1
            // 
            this.test_Button1.BackColor = System.Drawing.Color.Transparent;
            this.test_Button1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test_Button1.ForeColor = System.Drawing.Color.Black;
            this.test_Button1.Location = new System.Drawing.Point(707, 684);
            this.test_Button1.Margin = new System.Windows.Forms.Padding(4);
            this.test_Button1.Name = "test_Button1";
            this.test_Button1.Rounding = 40;
            this.test_Button1.RoundingEnable = true;
            this.test_Button1.Size = new System.Drawing.Size(197, 66);
            this.test_Button1.TabIndex = 100;
            this.test_Button1.Text = "Подать заявку";
            this.test_Button1.Click += new System.EventHandler(this.test_Button1_Click);
            // 
            // test_Button2
            // 
            this.test_Button2.BackColor = System.Drawing.Color.Transparent;
            this.test_Button2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test_Button2.ForeColor = System.Drawing.Color.Black;
            this.test_Button2.Location = new System.Drawing.Point(953, 684);
            this.test_Button2.Margin = new System.Windows.Forms.Padding(4);
            this.test_Button2.Name = "test_Button2";
            this.test_Button2.Rounding = 40;
            this.test_Button2.RoundingEnable = true;
            this.test_Button2.Size = new System.Drawing.Size(197, 66);
            this.test_Button2.TabIndex = 101;
            this.test_Button2.Text = "Cancel";
            this.test_Button2.Click += new System.EventHandler(this.test_Button2_Click);
            // 
            // fondsTableAdapter
            // 
            this.fondsTableAdapter.ClearBeforeFill = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox1.Location = new System.Drawing.Point(292, 338);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(355, 39);
            this.maskedTextBox1.TabIndex = 102;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.maskedTextBox1.Click += new System.EventHandler(this.maskedTextBox1_Click);
            // 
            // fondsTableAdapter1
            // 
            this.fondsTableAdapter1.ClearBeforeFill = true;
            // 
            // FormSponsorReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 846);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.test_Button2);
            this.Controls.Add(this.test_Button1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.test_Button5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSponsorReg";
            this.Text = "FormSponsorReg";
            this.Load += new System.EventHandler(this.FormSponsorReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fondsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_Sport_MarathonDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.FormDesign formDesign1;
        private System.Windows.Forms.Label label9;
        private Components.Test_Button test_Button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox1;
        private Components.Test_Button test_Button1;
        private Components.Test_Button test_Button2;
        private kursovayaDataSet10 kursovayaDataSet10;
        private System.Windows.Forms.BindingSource fondsBindingSource;
        private kursovayaDataSet10TableAdapters.FondsTableAdapter fondsTableAdapter;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private DataBase_Sport_MarathonDataSet2 dataBase_Sport_MarathonDataSet2;
        private System.Windows.Forms.BindingSource fondsBindingSource1;
        private DataBase_Sport_MarathonDataSet2TableAdapters.FondsTableAdapter fondsTableAdapter1;
    }
}