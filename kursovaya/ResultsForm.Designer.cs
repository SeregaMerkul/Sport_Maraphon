namespace kursovaya
{
    partial class ResultsForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.пп = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилия = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датарожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.страна = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Выбрать = new System.Windows.Forms.DataGridViewButtonColumn();
            this.runnersRUBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kursovayaDataSet24 = new kursovaya.kursovayaDataSet24();
            this.label6 = new System.Windows.Forms.Label();
            this.test_Button6 = new kursovaya.Components.Test_Button();
            this.label9 = new System.Windows.Forms.Label();
            this.test_Button5 = new kursovaya.Components.Test_Button();
            this.kursovayaDataSet22 = new kursovaya.kursovayaDataSet22();
            this.runnersRUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.runners_RUTableAdapter = new kursovaya.kursovayaDataSet22TableAdapters.Runners_RUTableAdapter();
            this.kursovayaDataSet23 = new kursovaya.kursovayaDataSet23();
            this.runnersRUBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.runners_RUTableAdapter1 = new kursovaya.kursovayaDataSet23TableAdapters.Runners_RUTableAdapter();
            this.formDesign1 = new kursovaya.Components.FormDesign(this.components);
            this.runners_RUTableAdapter2 = new kursovaya.kursovayaDataSet24TableAdapters.Runners_RUTableAdapter();
            this.dataBase_Sport_MarathonDataSet6 = new kursovaya.DataBase_Sport_MarathonDataSet6();
            this.runnersRUBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.runners_RUTableAdapter3 = new kursovaya.DataBase_Sport_MarathonDataSet6TableAdapters.Runners_RUTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnersRUBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnersRUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnersRUBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_Sport_MarathonDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnersRUBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "имя",
            "фамилия",
            "Email",
            "Пол",
            "Дата_рождения",
            "Страна"});
            this.comboBox1.Location = new System.Drawing.Point(943, 222);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 41);
            this.comboBox1.TabIndex = 102;
            this.comboBox1.Text = "имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(817, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 101;
            this.label2.Text = "Поиск по:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(849, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 100;
            this.label1.Text = "Поиск:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(943, 285);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 40);
            this.textBox1.TabIndex = 99;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
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
            this.пп,
            this.имя,
            this.фамилия,
            this.Email,
            this.полDataGridViewTextBoxColumn,
            this.датарожденияDataGridViewTextBoxColumn,
            this.страна,
            this.Выбрать});
            this.dataGridView1.DataSource = this.runnersRUBindingSource3;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(49, 418);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 36;
            this.dataGridView1.Size = new System.Drawing.Size(1181, 356);
            this.dataGridView1.TabIndex = 98;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // пп
            // 
            this.пп.DataPropertyName = "#_пп";
            this.пп.HeaderText = "№пп";
            this.пп.MinimumWidth = 6;
            this.пп.Name = "пп";
            this.пп.ReadOnly = true;
            this.пп.Width = 125;
            // 
            // имя
            // 
            this.имя.DataPropertyName = "Имя";
            this.имя.HeaderText = "Имя";
            this.имя.MinimumWidth = 6;
            this.имя.Name = "имя";
            this.имя.Width = 125;
            // 
            // фамилия
            // 
            this.фамилия.DataPropertyName = "Фамилия";
            this.фамилия.HeaderText = "Фамилия";
            this.фамилия.MinimumWidth = 6;
            this.фамилия.Name = "фамилия";
            this.фамилия.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // полDataGridViewTextBoxColumn
            // 
            this.полDataGridViewTextBoxColumn.DataPropertyName = "Пол";
            this.полDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.полDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.полDataGridViewTextBoxColumn.Name = "полDataGridViewTextBoxColumn";
            this.полDataGridViewTextBoxColumn.Width = 125;
            // 
            // датарожденияDataGridViewTextBoxColumn
            // 
            this.датарожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.HeaderText = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датарожденияDataGridViewTextBoxColumn.Name = "датарожденияDataGridViewTextBoxColumn";
            this.датарожденияDataGridViewTextBoxColumn.Width = 125;
            // 
            // страна
            // 
            this.страна.DataPropertyName = "Страна";
            this.страна.HeaderText = "Страна";
            this.страна.MinimumWidth = 6;
            this.страна.Name = "страна";
            this.страна.Width = 125;
            // 
            // Выбрать
            // 
            this.Выбрать.HeaderText = "Выбрать";
            this.Выбрать.MinimumWidth = 6;
            this.Выбрать.Name = "Выбрать";
            this.Выбрать.Text = "Выбрать";
            this.Выбрать.UseColumnTextForButtonValue = true;
            this.Выбрать.Width = 130;
            // 
            // runnersRUBindingSource2
            // 
            this.runnersRUBindingSource2.DataMember = "Runners_RU";
            this.runnersRUBindingSource2.DataSource = this.kursovayaDataSet24;
            // 
            // kursovayaDataSet24
            // 
            this.kursovayaDataSet24.DataSetName = "kursovayaDataSet24";
            this.kursovayaDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(460, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 45);
            this.label6.TabIndex = 97;
            this.label6.Text = "Список бегунов";
            // 
            // test_Button6
            // 
            this.test_Button6.BackColor = System.Drawing.Color.Transparent;
            this.test_Button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_Button6.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.test_Button6.ForeColor = System.Drawing.Color.Black;
            this.test_Button6.Location = new System.Drawing.Point(1080, 11);
            this.test_Button6.Margin = new System.Windows.Forms.Padding(4);
            this.test_Button6.Name = "test_Button6";
            this.test_Button6.Rounding = 40;
            this.test_Button6.RoundingEnable = true;
            this.test_Button6.Size = new System.Drawing.Size(179, 68);
            this.test_Button6.TabIndex = 96;
            this.test_Button6.Text = "Logout";
            this.test_Button6.Click += new System.EventHandler(this.test_Button6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(199, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(486, 57);
            this.label9.TabIndex = 95;
            this.label9.Text = "MARATHON SKILLS";
            // 
            // test_Button5
            // 
            this.test_Button5.BackColor = System.Drawing.Color.Transparent;
            this.test_Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_Button5.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.test_Button5.ForeColor = System.Drawing.Color.Black;
            this.test_Button5.Location = new System.Drawing.Point(12, 11);
            this.test_Button5.Margin = new System.Windows.Forms.Padding(4);
            this.test_Button5.Name = "test_Button5";
            this.test_Button5.Rounding = 40;
            this.test_Button5.RoundingEnable = true;
            this.test_Button5.Size = new System.Drawing.Size(179, 68);
            this.test_Button5.TabIndex = 94;
            this.test_Button5.Text = "Назад";
            this.test_Button5.Click += new System.EventHandler(this.test_Button5_Click);
            // 
            // kursovayaDataSet22
            // 
            this.kursovayaDataSet22.DataSetName = "kursovayaDataSet22";
            this.kursovayaDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // runnersRUBindingSource
            // 
            this.runnersRUBindingSource.DataMember = "Runners_RU";
            this.runnersRUBindingSource.DataSource = this.kursovayaDataSet22;
            // 
            // runners_RUTableAdapter
            // 
            this.runners_RUTableAdapter.ClearBeforeFill = true;
            // 
            // kursovayaDataSet23
            // 
            this.kursovayaDataSet23.DataSetName = "kursovayaDataSet23";
            this.kursovayaDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // runnersRUBindingSource1
            // 
            this.runnersRUBindingSource1.DataMember = "Runners_RU";
            this.runnersRUBindingSource1.DataSource = this.kursovayaDataSet23;
            // 
            // runners_RUTableAdapter1
            // 
            this.runners_RUTableAdapter1.ClearBeforeFill = true;
            // 
            // formDesign1
            // 
            this.formDesign1.Form = this;
            this.formDesign1.FormStyle = kursovaya.Components.FormDesign.fStyle.None;
            // 
            // runners_RUTableAdapter2
            // 
            this.runners_RUTableAdapter2.ClearBeforeFill = true;
            // 
            // dataBase_Sport_MarathonDataSet6
            // 
            this.dataBase_Sport_MarathonDataSet6.DataSetName = "DataBase_Sport_MarathonDataSet6";
            this.dataBase_Sport_MarathonDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // runnersRUBindingSource3
            // 
            this.runnersRUBindingSource3.DataMember = "Runners_RU";
            this.runnersRUBindingSource3.DataSource = this.dataBase_Sport_MarathonDataSet6;
            // 
            // runners_RUTableAdapter3
            // 
            this.runners_RUTableAdapter3.ClearBeforeFill = true;
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 846);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.test_Button6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.test_Button5);
            this.Name = "ResultsForm";
            this.Text = "ResultsForm";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnersRUBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnersRUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnersRUBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_Sport_MarathonDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnersRUBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private Components.Test_Button test_Button6;
        private System.Windows.Forms.Label label9;
        private Components.Test_Button test_Button5;
        private kursovayaDataSet22 kursovayaDataSet22;
        private System.Windows.Forms.BindingSource runnersRUBindingSource;
        private kursovayaDataSet22TableAdapters.Runners_RUTableAdapter runners_RUTableAdapter;
        private kursovayaDataSet23 kursovayaDataSet23;
        private System.Windows.Forms.BindingSource runnersRUBindingSource1;
        private kursovayaDataSet23TableAdapters.Runners_RUTableAdapter runners_RUTableAdapter1;
        private Components.FormDesign formDesign1;
        private kursovayaDataSet24 kursovayaDataSet24;
        private System.Windows.Forms.BindingSource runnersRUBindingSource2;
        private kursovayaDataSet24TableAdapters.Runners_RUTableAdapter runners_RUTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn пп;
        private System.Windows.Forms.DataGridViewTextBoxColumn имя;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилия;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn полDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датарожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn страна;
        private System.Windows.Forms.DataGridViewButtonColumn Выбрать;
        private DataBase_Sport_MarathonDataSet6 dataBase_Sport_MarathonDataSet6;
        private System.Windows.Forms.BindingSource runnersRUBindingSource3;
        private DataBase_Sport_MarathonDataSet6TableAdapters.Runners_RUTableAdapter runners_RUTableAdapter3;
    }
}