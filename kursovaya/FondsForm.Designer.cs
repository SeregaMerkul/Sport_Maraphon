namespace kursovaya
{
    partial class FondsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.названиефондаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.балансDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.fondsRUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursovayaDataSet9 = new kursovaya.kursovayaDataSet9();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fonds_RUTableAdapter = new kursovaya.kursovayaDataSet9TableAdapters.Fonds_RUTableAdapter();
            this.test_Button5 = new kursovaya.Components.Test_Button();
            this.formDesign1 = new kursovaya.Components.FormDesign(this.components);
            this.dataBase_Sport_MarathonDataSet1 = new kursovaya.DataBase_Sport_MarathonDataSet1();
            this.fondsRUBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fonds_RUTableAdapter1 = new kursovaya.DataBase_Sport_MarathonDataSet1TableAdapters.Fonds_RUTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondsRUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_Sport_MarathonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondsRUBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(855, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 79;
            this.label1.Text = "Поиск:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(948, 251);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 40);
            this.textBox1.TabIndex = 78;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.названиефондаDataGridViewTextBoxColumn,
            this.балансDataGridViewTextBoxColumn,
            this.View});
            this.dataGridView1.DataSource = this.fondsRUBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(215, 425);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 36;
            this.dataGridView1.Size = new System.Drawing.Size(712, 356);
            this.dataGridView1.TabIndex = 75;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // названиефондаDataGridViewTextBoxColumn
            // 
            this.названиефондаDataGridViewTextBoxColumn.DataPropertyName = "Название_фонда";
            this.названиефондаDataGridViewTextBoxColumn.HeaderText = "Название_фонда";
            this.названиефондаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиефондаDataGridViewTextBoxColumn.Name = "названиефондаDataGridViewTextBoxColumn";
            this.названиефондаDataGridViewTextBoxColumn.Width = 175;
            // 
            // балансDataGridViewTextBoxColumn
            // 
            this.балансDataGridViewTextBoxColumn.DataPropertyName = "Баланс";
            this.балансDataGridViewTextBoxColumn.HeaderText = "Баланс";
            this.балансDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.балансDataGridViewTextBoxColumn.Name = "балансDataGridViewTextBoxColumn";
            this.балансDataGridViewTextBoxColumn.Width = 168;
            // 
            // View
            // 
            this.View.DataPropertyName = "Название_фонда";
            this.View.HeaderText = "Транзакции";
            this.View.MinimumWidth = 6;
            this.View.Name = "View";
            this.View.Text = "Транзакции";
            this.View.UseColumnTextForButtonValue = true;
            this.View.Width = 125;
            // 
            // fondsRUBindingSource
            // 
            this.fondsRUBindingSource.DataMember = "Fonds_RU";
            this.fondsRUBindingSource.DataSource = this.kursovayaDataSet9;
            // 
            // kursovayaDataSet9
            // 
            this.kursovayaDataSet9.DataSetName = "kursovayaDataSet9";
            this.kursovayaDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(261, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(666, 45);
            this.label6.TabIndex = 74;
            this.label6.Text = "Благотворительные фонды марафона";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(205, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(486, 57);
            this.label9.TabIndex = 73;
            this.label9.Text = "MARATHON SKILLS";
            // 
            // fonds_RUTableAdapter
            // 
            this.fonds_RUTableAdapter.ClearBeforeFill = true;
            // 
            // test_Button5
            // 
            this.test_Button5.BackColor = System.Drawing.Color.Transparent;
            this.test_Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_Button5.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.test_Button5.ForeColor = System.Drawing.Color.Black;
            this.test_Button5.Location = new System.Drawing.Point(19, 12);
            this.test_Button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.test_Button5.Name = "test_Button5";
            this.test_Button5.Rounding = 40;
            this.test_Button5.RoundingEnable = true;
            this.test_Button5.Size = new System.Drawing.Size(179, 68);
            this.test_Button5.TabIndex = 71;
            this.test_Button5.Text = "Назад";
            this.test_Button5.Click += new System.EventHandler(this.test_Button5_Click);
            // 
            // formDesign1
            // 
            this.formDesign1.Form = this;
            this.formDesign1.FormStyle = kursovaya.Components.FormDesign.fStyle.None;
            // 
            // dataBase_Sport_MarathonDataSet1
            // 
            this.dataBase_Sport_MarathonDataSet1.DataSetName = "DataBase_Sport_MarathonDataSet1";
            this.dataBase_Sport_MarathonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fondsRUBindingSource1
            // 
            this.fondsRUBindingSource1.DataMember = "Fonds_RU";
            this.fondsRUBindingSource1.DataSource = this.dataBase_Sport_MarathonDataSet1;
            // 
            // fonds_RUTableAdapter1
            // 
            this.fonds_RUTableAdapter1.ClearBeforeFill = true;
            // 
            // FondsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 846);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.test_Button5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FondsForm";
            this.Text = "FondsForm";
            this.Load += new System.EventHandler(this.FondsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondsRUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_Sport_MarathonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondsRUBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.FormDesign formDesign1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private Components.Test_Button test_Button5;
        private kursovayaDataSet9 kursovayaDataSet9;
        private System.Windows.Forms.BindingSource fondsRUBindingSource;
        private kursovayaDataSet9TableAdapters.Fonds_RUTableAdapter fonds_RUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиефондаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn балансDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn View;
        private DataBase_Sport_MarathonDataSet1 dataBase_Sport_MarathonDataSet1;
        private System.Windows.Forms.BindingSource fondsRUBindingSource1;
        private DataBase_Sport_MarathonDataSet1TableAdapters.Fonds_RUTableAdapter fonds_RUTableAdapter1;
    }
}