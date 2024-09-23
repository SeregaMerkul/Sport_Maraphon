namespace kursovaya
{
    partial class Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Имя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Фамилия = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Пароль = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Роль = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.usersRUBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kursovayaDataSet7 = new kursovaya.kursovayaDataSet7();
            this.usersRUBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kursovayaDataSet6 = new kursovaya.kursovayaDataSet6();
            this.usersRUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursovayaDataSet5 = new kursovaya.kursovayaDataSet5();
            this.test_Button6 = new kursovaya.Components.Test_Button();
            this.test_Button5 = new kursovaya.Components.Test_Button();
            this.formDesign1 = new kursovaya.Components.FormDesign(this.components);
            this.users_RUTableAdapter = new kursovaya.kursovayaDataSet5TableAdapters.Users_RUTableAdapter();
            this.users_RUTableAdapter1 = new kursovaya.kursovayaDataSet6TableAdapters.Users_RUTableAdapter();
            this.test_Button1 = new kursovaya.Components.Test_Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.users_RUTableAdapter2 = new kursovaya.kursovayaDataSet7TableAdapters.Users_RUTableAdapter();
            this.dataBase_Sport_MarathonDataSet11 = new kursovaya.DataBase_Sport_MarathonDataSet11();
            this.usersRUBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.users_RUTableAdapter3 = new kursovaya.DataBase_Sport_MarathonDataSet11TableAdapters.Users_RUTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersRUBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersRUBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersRUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_Sport_MarathonDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersRUBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(207, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(486, 57);
            this.label9.TabIndex = 50;
            this.label9.Text = "MARATHON SKILLS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(381, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(511, 45);
            this.label6.TabIndex = 51;
            this.label6.Text = "Управление пользователями";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Имя,
            this.Фамилия,
            this.Email,
            this.Пароль,
            this.Роль,
            this.Edit});
            this.dataGridView1.DataSource = this.usersRUBindingSource3;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(91, 428);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 36;
            this.dataGridView1.Size = new System.Drawing.Size(1091, 356);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Имя
            // 
            this.Имя.DataPropertyName = "Имя";
            this.Имя.HeaderText = "Имя";
            this.Имя.MinimumWidth = 6;
            this.Имя.Name = "Имя";
            this.Имя.ReadOnly = true;
            this.Имя.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Имя.Width = 135;
            // 
            // Фамилия
            // 
            this.Фамилия.DataPropertyName = "Фамилия";
            this.Фамилия.HeaderText = "Фамилия";
            this.Фамилия.MinimumWidth = 6;
            this.Фамилия.Name = "Фамилия";
            this.Фамилия.ReadOnly = true;
            this.Фамилия.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Фамилия.Width = 140;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Email.Width = 140;
            // 
            // Пароль
            // 
            this.Пароль.DataPropertyName = "Пароль";
            this.Пароль.HeaderText = "Пароль";
            this.Пароль.MinimumWidth = 6;
            this.Пароль.Name = "Пароль";
            this.Пароль.ReadOnly = true;
            this.Пароль.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Пароль.Width = 140;
            // 
            // Роль
            // 
            this.Роль.DataPropertyName = "Роль";
            this.Роль.HeaderText = "Роль";
            this.Роль.MinimumWidth = 6;
            this.Роль.Name = "Роль";
            this.Роль.ReadOnly = true;
            this.Роль.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Роль.Width = 140;
            // 
            // Edit
            // 
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 70;
            // 
            // usersRUBindingSource2
            // 
            this.usersRUBindingSource2.DataMember = "Users_RU";
            this.usersRUBindingSource2.DataSource = this.kursovayaDataSet7;
            // 
            // kursovayaDataSet7
            // 
            this.kursovayaDataSet7.DataSetName = "kursovayaDataSet7";
            this.kursovayaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersRUBindingSource1
            // 
            this.usersRUBindingSource1.DataMember = "Users_RU";
            this.usersRUBindingSource1.DataSource = this.kursovayaDataSet6;
            // 
            // kursovayaDataSet6
            // 
            this.kursovayaDataSet6.DataSetName = "kursovayaDataSet6";
            this.kursovayaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersRUBindingSource
            // 
            this.usersRUBindingSource.DataMember = "Users_RU";
            this.usersRUBindingSource.DataSource = this.kursovayaDataSet5;
            // 
            // kursovayaDataSet5
            // 
            this.kursovayaDataSet5.DataSetName = "kursovayaDataSet5";
            this.kursovayaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // test_Button6
            // 
            this.test_Button6.BackColor = System.Drawing.Color.Transparent;
            this.test_Button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_Button6.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.test_Button6.ForeColor = System.Drawing.Color.Black;
            this.test_Button6.Location = new System.Drawing.Point(1083, 15);
            this.test_Button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.test_Button6.Name = "test_Button6";
            this.test_Button6.Rounding = 40;
            this.test_Button6.RoundingEnable = true;
            this.test_Button6.Size = new System.Drawing.Size(179, 68);
            this.test_Button6.TabIndex = 49;
            this.test_Button6.Text = "Logout";
            this.test_Button6.Click += new System.EventHandler(this.test_Button6_Click);
            // 
            // test_Button5
            // 
            this.test_Button5.BackColor = System.Drawing.Color.Transparent;
            this.test_Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_Button5.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.test_Button5.ForeColor = System.Drawing.Color.Black;
            this.test_Button5.Location = new System.Drawing.Point(20, 15);
            this.test_Button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.test_Button5.Name = "test_Button5";
            this.test_Button5.Rounding = 40;
            this.test_Button5.RoundingEnable = true;
            this.test_Button5.Size = new System.Drawing.Size(179, 68);
            this.test_Button5.TabIndex = 48;
            this.test_Button5.Text = "Назад";
            this.test_Button5.Click += new System.EventHandler(this.test_Button5_Click);
            // 
            // formDesign1
            // 
            this.formDesign1.Form = this;
            this.formDesign1.FormStyle = kursovaya.Components.FormDesign.fStyle.None;
            // 
            // users_RUTableAdapter
            // 
            this.users_RUTableAdapter.ClearBeforeFill = true;
            // 
            // users_RUTableAdapter1
            // 
            this.users_RUTableAdapter1.ClearBeforeFill = true;
            // 
            // test_Button1
            // 
            this.test_Button1.BackColor = System.Drawing.Color.Transparent;
            this.test_Button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.test_Button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test_Button1.ForeColor = System.Drawing.Color.Black;
            this.test_Button1.Location = new System.Drawing.Point(91, 217);
            this.test_Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.test_Button1.Name = "test_Button1";
            this.test_Button1.Rounding = 35;
            this.test_Button1.RoundingEnable = true;
            this.test_Button1.Size = new System.Drawing.Size(349, 122);
            this.test_Button1.TabIndex = 54;
            this.test_Button1.Text = " + добавление пользователя";
            this.test_Button1.Click += new System.EventHandler(this.test_Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(949, 288);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 40);
            this.textBox1.TabIndex = 55;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(856, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 56;
            this.label1.Text = "Поиск:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(824, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 57;
            this.label2.Text = "Поиск по:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Имя",
            "Фамилия",
            "Email",
            "Роль"});
            this.comboBox1.Location = new System.Drawing.Point(949, 220);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 41);
            this.comboBox1.TabIndex = 58;
            this.comboBox1.Text = "Имя";
            // 
            // users_RUTableAdapter2
            // 
            this.users_RUTableAdapter2.ClearBeforeFill = true;
            // 
            // dataBase_Sport_MarathonDataSet11
            // 
            this.dataBase_Sport_MarathonDataSet11.DataSetName = "DataBase_Sport_MarathonDataSet11";
            this.dataBase_Sport_MarathonDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersRUBindingSource3
            // 
            this.usersRUBindingSource3.DataMember = "Users_RU";
            this.usersRUBindingSource3.DataSource = this.dataBase_Sport_MarathonDataSet11;
            // 
            // users_RUTableAdapter3
            // 
            this.users_RUTableAdapter3.ClearBeforeFill = true;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 846);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.test_Button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.test_Button6);
            this.Controls.Add(this.test_Button5);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersRUBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersRUBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersRUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_Sport_MarathonDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersRUBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private Components.Test_Button test_Button6;
        private Components.Test_Button test_Button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Components.FormDesign formDesign1;
        private kursovayaDataSet5 kursovayaDataSet5;
        private System.Windows.Forms.BindingSource usersRUBindingSource;
        private kursovayaDataSet5TableAdapters.Users_RUTableAdapter users_RUTableAdapter;
        private kursovayaDataSet6 kursovayaDataSet6;
        private System.Windows.Forms.BindingSource usersRUBindingSource1;
        private kursovayaDataSet6TableAdapters.Users_RUTableAdapter users_RUTableAdapter1;
        private Components.Test_Button test_Button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Имя;
        private System.Windows.Forms.DataGridViewTextBoxColumn Фамилия;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Пароль;
        private System.Windows.Forms.DataGridViewTextBoxColumn Роль;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private kursovayaDataSet7 kursovayaDataSet7;
        private System.Windows.Forms.BindingSource usersRUBindingSource2;
        private kursovayaDataSet7TableAdapters.Users_RUTableAdapter users_RUTableAdapter2;
        private DataBase_Sport_MarathonDataSet11 dataBase_Sport_MarathonDataSet11;
        private System.Windows.Forms.BindingSource usersRUBindingSource3;
        private DataBase_Sport_MarathonDataSet11TableAdapters.Users_RUTableAdapter users_RUTableAdapter3;
    }
}