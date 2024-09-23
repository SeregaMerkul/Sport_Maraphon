namespace kursovaya
{
    partial class AddFonds
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
            this.formDesign1 = new kursovaya.Components.FormDesign(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.test_Button1 = new kursovaya.Components.Test_Button();
            this.test_Button3 = new kursovaya.Components.Test_Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.названиефондаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.балансDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fondsRUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursovayaDataSet8 = new kursovaya.kursovayaDataSet8();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.test_Button6 = new kursovaya.Components.Test_Button();
            this.test_Button5 = new kursovaya.Components.Test_Button();
            this.fonds_RUTableAdapter = new kursovaya.kursovayaDataSet8TableAdapters.Fonds_RUTableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.test_Button2 = new kursovaya.Components.Test_Button();
            this.dataBase_Sport_MarathonDataSet = new kursovaya.DataBase_Sport_MarathonDataSet();
            this.fondsRUBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fonds_RUTableAdapter1 = new kursovaya.DataBase_Sport_MarathonDataSetTableAdapters.Fonds_RUTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondsRUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_Sport_MarathonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondsRUBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // formDesign1
            // 
            this.formDesign1.Form = this;
            this.formDesign1.FormStyle = kursovaya.Components.FormDesign.fStyle.None;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(856, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 67;
            this.label1.Text = "Поиск:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(949, 253);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 40);
            this.textBox1.TabIndex = 66;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // test_Button1
            // 
            this.test_Button1.BackColor = System.Drawing.Color.Transparent;
            this.test_Button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.test_Button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test_Button1.ForeColor = System.Drawing.Color.Black;
            this.test_Button1.Location = new System.Drawing.Point(53, 203);
            this.test_Button1.Name = "test_Button1";
            this.test_Button1.Rounding = 35;
            this.test_Button1.RoundingEnable = true;
            this.test_Button1.Size = new System.Drawing.Size(350, 122);
            this.test_Button1.TabIndex = 65;
            this.test_Button1.Text = " + добавление фонда";
            this.test_Button1.Click += new System.EventHandler(this.test_Button1_Click);
            // 
            // test_Button3
            // 
            this.test_Button3.BackColor = System.Drawing.Color.Tomato;
            this.test_Button3.ForeColor = System.Drawing.Color.Black;
            this.test_Button3.Location = new System.Drawing.Point(761, 390);
            this.test_Button3.Name = "test_Button3";
            this.test_Button3.RoundingEnable = false;
            this.test_Button3.Size = new System.Drawing.Size(100, 30);
            this.test_Button3.TabIndex = 64;
            this.test_Button3.Text = "Refresh";
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
            this.балансDataGridViewTextBoxColumn});
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
            this.dataGridView1.Location = new System.Drawing.Point(332, 427);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 36;
            this.dataGridView1.Size = new System.Drawing.Size(529, 356);
            this.dataGridView1.TabIndex = 63;
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
            // fondsRUBindingSource
            // 
            this.fondsRUBindingSource.DataMember = "Fonds_RU";
            this.fondsRUBindingSource.DataSource = this.kursovayaDataSet8;
            // 
            // kursovayaDataSet8
            // 
            this.kursovayaDataSet8.DataSetName = "kursovayaDataSet8";
            this.kursovayaDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(217, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(759, 45);
            this.label6.TabIndex = 62;
            this.label6.Text = "Управление благотворительными фондами";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(207, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(486, 57);
            this.label9.TabIndex = 61;
            this.label9.Text = "MARATHON SKILLS";
            // 
            // test_Button6
            // 
            this.test_Button6.BackColor = System.Drawing.Color.Transparent;
            this.test_Button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_Button6.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.test_Button6.ForeColor = System.Drawing.Color.Black;
            this.test_Button6.Location = new System.Drawing.Point(1080, 14);
            this.test_Button6.Margin = new System.Windows.Forms.Padding(4);
            this.test_Button6.Name = "test_Button6";
            this.test_Button6.Rounding = 40;
            this.test_Button6.RoundingEnable = true;
            this.test_Button6.Size = new System.Drawing.Size(179, 68);
            this.test_Button6.TabIndex = 60;
            this.test_Button6.Text = "Logout";
            this.test_Button6.Click += new System.EventHandler(this.test_Button6_Click);
            // 
            // test_Button5
            // 
            this.test_Button5.BackColor = System.Drawing.Color.Transparent;
            this.test_Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_Button5.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.test_Button5.ForeColor = System.Drawing.Color.Black;
            this.test_Button5.Location = new System.Drawing.Point(20, 14);
            this.test_Button5.Margin = new System.Windows.Forms.Padding(4);
            this.test_Button5.Name = "test_Button5";
            this.test_Button5.Rounding = 40;
            this.test_Button5.RoundingEnable = true;
            this.test_Button5.Size = new System.Drawing.Size(179, 68);
            this.test_Button5.TabIndex = 59;
            this.test_Button5.Text = "Назад";
            this.test_Button5.Click += new System.EventHandler(this.test_Button5_Click);
            // 
            // fonds_RUTableAdapter
            // 
            this.fonds_RUTableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(204, 229);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 32);
            this.textBox2.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(68, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 69;
            this.label2.Text = "Название:";
            // 
            // test_Button2
            // 
            this.test_Button2.BackColor = System.Drawing.Color.Transparent;
            this.test_Button2.ForeColor = System.Drawing.Color.Black;
            this.test_Button2.Location = new System.Drawing.Point(151, 272);
            this.test_Button2.Name = "test_Button2";
            this.test_Button2.Rounding = 35;
            this.test_Button2.RoundingEnable = true;
            this.test_Button2.Size = new System.Drawing.Size(139, 31);
            this.test_Button2.TabIndex = 70;
            this.test_Button2.Text = "Добавить";
            this.test_Button2.Click += new System.EventHandler(this.test_Button2_Click);
            // 
            // dataBase_Sport_MarathonDataSet
            // 
            this.dataBase_Sport_MarathonDataSet.DataSetName = "DataBase_Sport_MarathonDataSet";
            this.dataBase_Sport_MarathonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fondsRUBindingSource1
            // 
            this.fondsRUBindingSource1.DataMember = "Fonds_RU";
            this.fondsRUBindingSource1.DataSource = this.dataBase_Sport_MarathonDataSet;
            // 
            // fonds_RUTableAdapter1
            // 
            this.fonds_RUTableAdapter1.ClearBeforeFill = true;
            // 
            // AddFonds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 850);
            this.Controls.Add(this.test_Button1);
            this.Controls.Add(this.test_Button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.test_Button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.test_Button6);
            this.Controls.Add(this.test_Button5);
            this.Name = "AddFonds";
            this.Text = "AddFonds";
            this.Load += new System.EventHandler(this.AddFonds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondsRUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_Sport_MarathonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondsRUBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.FormDesign formDesign1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private Components.Test_Button test_Button1;
        private Components.Test_Button test_Button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private Components.Test_Button test_Button6;
        private Components.Test_Button test_Button5;
        private kursovayaDataSet8 kursovayaDataSet8;
        private System.Windows.Forms.BindingSource fondsRUBindingSource;
        private kursovayaDataSet8TableAdapters.Fonds_RUTableAdapter fonds_RUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиефондаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn балансDataGridViewTextBoxColumn;
        private Components.Test_Button test_Button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private DataBase_Sport_MarathonDataSet dataBase_Sport_MarathonDataSet;
        private System.Windows.Forms.BindingSource fondsRUBindingSource1;
        private DataBase_Sport_MarathonDataSetTableAdapters.Fonds_RUTableAdapter fonds_RUTableAdapter1;
    }
}