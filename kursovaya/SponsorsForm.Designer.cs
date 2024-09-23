namespace kursovaya
{
    partial class SponsorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SponsorsForm));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ппDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеКомпанииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.элПочтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иННDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фондDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.парольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.занятDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Выбрать = new System.Windows.Forms.DataGridViewButtonColumn();
            this.sponsorsRUBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBase_Sport_MarathonDataSet7 = new kursovaya.DataBase_Sport_MarathonDataSet7();
            this.sponsorsRUBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kursovayaDataSet18 = new kursovaya.kursovayaDataSet18();
            this.sponsorsRUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursovayaDataSet16 = new kursovaya.kursovayaDataSet16();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sponsors_RUTableAdapter = new kursovaya.kursovayaDataSet16TableAdapters.Sponsors_RUTableAdapter();
            this.sponsors_RUTableAdapter1 = new kursovaya.kursovayaDataSet18TableAdapters.Sponsors_RUTableAdapter();
            this.test_Button6 = new kursovaya.Components.Test_Button();
            this.test_Button5 = new kursovaya.Components.Test_Button();
            this.formDesign1 = new kursovaya.Components.FormDesign(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.sponsors_RUTableAdapter2 = new kursovaya.DataBase_Sport_MarathonDataSet7TableAdapters.Sponsors_RUTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorsRUBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_Sport_MarathonDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorsRUBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorsRUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Название_Компании",
            "Эл_Почта",
            "ИНН",
            "Фонд"});
            this.comboBox1.Location = new System.Drawing.Point(710, 184);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 35);
            this.comboBox1.TabIndex = 93;
            this.comboBox1.Text = "Название_Компании";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(616, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 92;
            this.label2.Text = "Поиск по:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(640, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 91;
            this.label1.Text = "Поиск:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(710, 235);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 34);
            this.textBox1.TabIndex = 90;
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
            this.ппDataGridViewTextBoxColumn,
            this.названиеКомпанииDataGridViewTextBoxColumn,
            this.элПочтаDataGridViewTextBoxColumn,
            this.иННDataGridViewTextBoxColumn,
            this.фондDataGridViewTextBoxColumn,
            this.парольDataGridViewTextBoxColumn,
            this.занятDataGridViewCheckBoxColumn,
            this.Выбрать});
            this.dataGridView1.DataSource = this.sponsorsRUBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(40, 343);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 36;
            this.dataGridView1.Size = new System.Drawing.Size(886, 289);
            this.dataGridView1.TabIndex = 89;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ппDataGridViewTextBoxColumn
            // 
            this.ппDataGridViewTextBoxColumn.DataPropertyName = "#п\\п";
            this.ппDataGridViewTextBoxColumn.HeaderText = "#п\\п";
            this.ппDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ппDataGridViewTextBoxColumn.Name = "ппDataGridViewTextBoxColumn";
            this.ппDataGridViewTextBoxColumn.ReadOnly = true;
            this.ппDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиеКомпанииDataGridViewTextBoxColumn
            // 
            this.названиеКомпанииDataGridViewTextBoxColumn.DataPropertyName = "Название_Компании";
            this.названиеКомпанииDataGridViewTextBoxColumn.HeaderText = "Название_Компании";
            this.названиеКомпанииDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеКомпанииDataGridViewTextBoxColumn.Name = "названиеКомпанииDataGridViewTextBoxColumn";
            this.названиеКомпанииDataGridViewTextBoxColumn.Width = 125;
            // 
            // элПочтаDataGridViewTextBoxColumn
            // 
            this.элПочтаDataGridViewTextBoxColumn.DataPropertyName = "Эл_Почта";
            this.элПочтаDataGridViewTextBoxColumn.HeaderText = "Эл_Почта";
            this.элПочтаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.элПочтаDataGridViewTextBoxColumn.Name = "элПочтаDataGridViewTextBoxColumn";
            this.элПочтаDataGridViewTextBoxColumn.Width = 125;
            // 
            // иННDataGridViewTextBoxColumn
            // 
            this.иННDataGridViewTextBoxColumn.DataPropertyName = "ИНН";
            this.иННDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.иННDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.иННDataGridViewTextBoxColumn.Name = "иННDataGridViewTextBoxColumn";
            this.иННDataGridViewTextBoxColumn.Width = 125;
            // 
            // фондDataGridViewTextBoxColumn
            // 
            this.фондDataGridViewTextBoxColumn.DataPropertyName = "Фонд";
            this.фондDataGridViewTextBoxColumn.HeaderText = "Фонд";
            this.фондDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фондDataGridViewTextBoxColumn.Name = "фондDataGridViewTextBoxColumn";
            this.фондDataGridViewTextBoxColumn.Width = 125;
            // 
            // парольDataGridViewTextBoxColumn
            // 
            this.парольDataGridViewTextBoxColumn.DataPropertyName = "Пароль";
            this.парольDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.парольDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.парольDataGridViewTextBoxColumn.Name = "парольDataGridViewTextBoxColumn";
            this.парольDataGridViewTextBoxColumn.Width = 125;
            // 
            // занятDataGridViewCheckBoxColumn
            // 
            this.занятDataGridViewCheckBoxColumn.DataPropertyName = "Занят";
            this.занятDataGridViewCheckBoxColumn.HeaderText = "Занят";
            this.занятDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.занятDataGridViewCheckBoxColumn.Name = "занятDataGridViewCheckBoxColumn";
            this.занятDataGridViewCheckBoxColumn.Width = 75;
            // 
            // Выбрать
            // 
            this.Выбрать.HeaderText = "Выбрать";
            this.Выбрать.MinimumWidth = 6;
            this.Выбрать.Name = "Выбрать";
            this.Выбрать.Text = "Выбрать";
            this.Выбрать.UseColumnTextForButtonValue = true;
            this.Выбрать.Visible = false;
            this.Выбрать.Width = 130;
            // 
            // sponsorsRUBindingSource2
            // 
            this.sponsorsRUBindingSource2.DataMember = "Sponsors_RU";
            this.sponsorsRUBindingSource2.DataSource = this.dataBase_Sport_MarathonDataSet7;
            // 
            // dataBase_Sport_MarathonDataSet7
            // 
            this.dataBase_Sport_MarathonDataSet7.DataSetName = "DataBase_Sport_MarathonDataSet7";
            this.dataBase_Sport_MarathonDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sponsorsRUBindingSource1
            // 
            this.sponsorsRUBindingSource1.DataMember = "Sponsors_RU";
            this.sponsorsRUBindingSource1.DataSource = this.kursovayaDataSet18;
            // 
            // kursovayaDataSet18
            // 
            this.kursovayaDataSet18.DataSetName = "kursovayaDataSet18";
            this.kursovayaDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sponsorsRUBindingSource
            // 
            this.sponsorsRUBindingSource.DataMember = "Sponsors_RU";
            this.sponsorsRUBindingSource.DataSource = this.kursovayaDataSet16;
            // 
            // kursovayaDataSet16
            // 
            this.kursovayaDataSet16.DataSetName = "kursovayaDataSet16";
            this.kursovayaDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(348, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 35);
            this.label6.TabIndex = 88;
            this.label6.Text = "Список спонсоров";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(152, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(381, 45);
            this.label9.TabIndex = 86;
            this.label9.Text = "MARATHON SKILLS";
            // 
            // sponsors_RUTableAdapter
            // 
            this.sponsors_RUTableAdapter.ClearBeforeFill = true;
            // 
            // sponsors_RUTableAdapter1
            // 
            this.sponsors_RUTableAdapter1.ClearBeforeFill = true;
            // 
            // test_Button6
            // 
            this.test_Button6.BackColor = System.Drawing.Color.Transparent;
            this.test_Button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_Button6.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.test_Button6.ForeColor = System.Drawing.Color.Black;
            this.test_Button6.Location = new System.Drawing.Point(813, 12);
            this.test_Button6.Name = "test_Button6";
            this.test_Button6.Rounding = 40;
            this.test_Button6.RoundingEnable = true;
            this.test_Button6.Size = new System.Drawing.Size(134, 55);
            this.test_Button6.TabIndex = 87;
            this.test_Button6.Text = "Logout";
            this.test_Button6.Click += new System.EventHandler(this.test_Button6_Click);
            // 
            // test_Button5
            // 
            this.test_Button5.BackColor = System.Drawing.Color.Transparent;
            this.test_Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_Button5.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.test_Button5.ForeColor = System.Drawing.Color.Black;
            this.test_Button5.Location = new System.Drawing.Point(12, 12);
            this.test_Button5.Name = "test_Button5";
            this.test_Button5.Rounding = 40;
            this.test_Button5.RoundingEnable = true;
            this.test_Button5.Size = new System.Drawing.Size(134, 55);
            this.test_Button5.TabIndex = 85;
            this.test_Button5.Text = "Назад";
            this.test_Button5.Click += new System.EventHandler(this.test_Button5_Click);
            // 
            // formDesign1
            // 
            this.formDesign1.Form = this;
            this.formDesign1.FormStyle = kursovaya.Components.FormDesign.fStyle.None;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Cancel";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Add";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // sponsors_RUTableAdapter2
            // 
            this.sponsors_RUTableAdapter2.ClearBeforeFill = true;
            // 
            // SponsorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 687);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.test_Button6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.test_Button5);
            this.Name = "SponsorsForm";
            this.Text = "SponsorsForm";
            this.Load += new System.EventHandler(this.SponsorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorsRUBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_Sport_MarathonDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorsRUBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorsRUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet16)).EndInit();
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
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private kursovayaDataSet16 kursovayaDataSet16;
        private System.Windows.Forms.BindingSource sponsorsRUBindingSource;
        private kursovayaDataSet16TableAdapters.Sponsors_RUTableAdapter sponsors_RUTableAdapter;
        private Components.FormDesign formDesign1;
        private kursovayaDataSet18 kursovayaDataSet18;
        private System.Windows.Forms.BindingSource sponsorsRUBindingSource1;
        private kursovayaDataSet18TableAdapters.Sponsors_RUTableAdapter sponsors_RUTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ппDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеКомпанииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn элПочтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иННDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фондDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn парольDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn занятDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Выбрать;
        private DataBase_Sport_MarathonDataSet7 dataBase_Sport_MarathonDataSet7;
        private System.Windows.Forms.BindingSource sponsorsRUBindingSource2;
        private DataBase_Sport_MarathonDataSet7TableAdapters.Sponsors_RUTableAdapter sponsors_RUTableAdapter2;
    }
}