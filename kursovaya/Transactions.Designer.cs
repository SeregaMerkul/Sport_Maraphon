namespace kursovaya
{
    partial class Transactions
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
            this.label6 = new System.Windows.Forms.Label();
            this.kursovayaDataSet19 = new kursovaya.kursovayaDataSet19();
            this.transactionsRUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactions_RUTableAdapter = new kursovaya.kursovayaDataSet19TableAdapters.Transactions_RUTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ппDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.благотвортельDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.элПочтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionsRUBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBase_Sport_MarathonDataSet12 = new kursovaya.DataBase_Sport_MarathonDataSet12();
            this.transactionsRUBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBase_Sport_MarathonDataSet10 = new kursovaya.DataBase_Sport_MarathonDataSet10();
            this.label9 = new System.Windows.Forms.Label();
            this.transactions_RUTableAdapter1 = new kursovaya.DataBase_Sport_MarathonDataSet10TableAdapters.Transactions_RUTableAdapter();
            this.transactions_RUTableAdapter2 = new kursovaya.DataBase_Sport_MarathonDataSet12TableAdapters.Transactions_RUTableAdapter();
            this.test_Button1 = new kursovaya.Components.Test_Button();
            this.test_Button5 = new kursovaya.Components.Test_Button();
            this.formDesign1 = new kursovaya.Components.FormDesign(this.components);
            this.dataBase_Sport_MarathonDataSet13 = new kursovaya.DataBase_Sport_MarathonDataSet13();
            this.transactionsRUBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.transactions_RUTableAdapter3 = new kursovaya.DataBase_Sport_MarathonDataSet13TableAdapters.Transactions_RUTableAdapter();
            this.Марафон = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsRUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsRUBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_Sport_MarathonDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsRUBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_Sport_MarathonDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_Sport_MarathonDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsRUBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(212, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 34);
            this.label6.TabIndex = 89;
            this.label6.Text = "История транзакций";
            // 
            // kursovayaDataSet19
            // 
            this.kursovayaDataSet19.DataSetName = "kursovayaDataSet19";
            this.kursovayaDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsRUBindingSource
            // 
            this.transactionsRUBindingSource.DataMember = "Transactions_RU";
            this.transactionsRUBindingSource.DataSource = this.kursovayaDataSet19;
            // 
            // transactions_RUTableAdapter
            // 
            this.transactions_RUTableAdapter.ClearBeforeFill = true;
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
            this.благотвортельDataGridViewTextBoxColumn,
            this.элПочтаDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn,
            this.Марафон});
            this.dataGridView1.DataSource = this.transactionsRUBindingSource3;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(13, 157);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 36;
            this.dataGridView1.Size = new System.Drawing.Size(1042, 356);
            this.dataGridView1.TabIndex = 90;
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
            // благотвортельDataGridViewTextBoxColumn
            // 
            this.благотвортельDataGridViewTextBoxColumn.DataPropertyName = "Благотвортель";
            this.благотвортельDataGridViewTextBoxColumn.HeaderText = "Благотвортель";
            this.благотвортельDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.благотвортельDataGridViewTextBoxColumn.Name = "благотвортельDataGridViewTextBoxColumn";
            this.благотвортельDataGridViewTextBoxColumn.Width = 160;
            // 
            // элПочтаDataGridViewTextBoxColumn
            // 
            this.элПочтаDataGridViewTextBoxColumn.DataPropertyName = "Эл_Почта";
            this.элПочтаDataGridViewTextBoxColumn.HeaderText = "Эл_Почта";
            this.элПочтаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.элПочтаDataGridViewTextBoxColumn.Name = "элПочтаDataGridViewTextBoxColumn";
            this.элПочтаDataGridViewTextBoxColumn.Width = 160;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.Width = 160;
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.суммаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            this.суммаDataGridViewTextBoxColumn.Width = 160;
            // 
            // transactionsRUBindingSource2
            // 
            this.transactionsRUBindingSource2.DataMember = "Transactions_RU";
            this.transactionsRUBindingSource2.DataSource = this.dataBase_Sport_MarathonDataSet12;
            // 
            // dataBase_Sport_MarathonDataSet12
            // 
            this.dataBase_Sport_MarathonDataSet12.DataSetName = "DataBase_Sport_MarathonDataSet12";
            this.dataBase_Sport_MarathonDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsRUBindingSource1
            // 
            this.transactionsRUBindingSource1.DataMember = "Transactions_RU";
            this.transactionsRUBindingSource1.DataSource = this.dataBase_Sport_MarathonDataSet10;
            // 
            // dataBase_Sport_MarathonDataSet10
            // 
            this.dataBase_Sport_MarathonDataSet10.DataSetName = "DataBase_Sport_MarathonDataSet10";
            this.dataBase_Sport_MarathonDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(178, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(486, 57);
            this.label9.TabIndex = 92;
            this.label9.Text = "MARATHON SKILLS";
            // 
            // transactions_RUTableAdapter1
            // 
            this.transactions_RUTableAdapter1.ClearBeforeFill = true;
            // 
            // transactions_RUTableAdapter2
            // 
            this.transactions_RUTableAdapter2.ClearBeforeFill = true;
            // 
            // test_Button1
            // 
            this.test_Button1.BackColor = System.Drawing.Color.Transparent;
            this.test_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_Button1.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.test_Button1.ForeColor = System.Drawing.Color.Black;
            this.test_Button1.Location = new System.Drawing.Point(938, 13);
            this.test_Button1.Margin = new System.Windows.Forms.Padding(4);
            this.test_Button1.Name = "test_Button1";
            this.test_Button1.Rounding = 40;
            this.test_Button1.RoundingEnable = true;
            this.test_Button1.Size = new System.Drawing.Size(143, 56);
            this.test_Button1.TabIndex = 93;
            this.test_Button1.Text = "Печать";
            this.test_Button1.Click += new System.EventHandler(this.test_Button1_Click);
            // 
            // test_Button5
            // 
            this.test_Button5.BackColor = System.Drawing.Color.Transparent;
            this.test_Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_Button5.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.test_Button5.ForeColor = System.Drawing.Color.Black;
            this.test_Button5.Location = new System.Drawing.Point(19, 15);
            this.test_Button5.Margin = new System.Windows.Forms.Padding(4);
            this.test_Button5.Name = "test_Button5";
            this.test_Button5.Rounding = 40;
            this.test_Button5.RoundingEnable = true;
            this.test_Button5.Size = new System.Drawing.Size(143, 56);
            this.test_Button5.TabIndex = 91;
            this.test_Button5.Text = "Назад";
            this.test_Button5.Click += new System.EventHandler(this.test_Button5_Click);
            // 
            // formDesign1
            // 
            this.formDesign1.Form = this;
            this.formDesign1.FormStyle = kursovaya.Components.FormDesign.fStyle.None;
            // 
            // dataBase_Sport_MarathonDataSet13
            // 
            this.dataBase_Sport_MarathonDataSet13.DataSetName = "DataBase_Sport_MarathonDataSet13";
            this.dataBase_Sport_MarathonDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsRUBindingSource3
            // 
            this.transactionsRUBindingSource3.DataMember = "Transactions_RU";
            this.transactionsRUBindingSource3.DataSource = this.dataBase_Sport_MarathonDataSet13;
            // 
            // transactions_RUTableAdapter3
            // 
            this.transactions_RUTableAdapter3.ClearBeforeFill = true;
            // 
            // Марафон
            // 
            this.Марафон.DataPropertyName = "Марафон";
            this.Марафон.HeaderText = "Марафон";
            this.Марафон.MinimumWidth = 6;
            this.Марафон.Name = "Марафон";
            this.Марафон.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(438, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 29);
            this.label1.TabIndex = 94;
            this.label1.Text = "Печать относительно:";
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 614);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.test_Button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.test_Button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Name = "Transactions";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.Transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsRUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsRUBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_Sport_MarathonDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsRUBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_Sport_MarathonDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_Sport_MarathonDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsRUBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.FormDesign formDesign1;
        private System.Windows.Forms.Label label6;
        private kursovayaDataSet19 kursovayaDataSet19;
        private System.Windows.Forms.BindingSource transactionsRUBindingSource;
        private kursovayaDataSet19TableAdapters.Transactions_RUTableAdapter transactions_RUTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ппDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn благотвортельDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn элПочтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private Components.Test_Button test_Button5;
        private DataBase_Sport_MarathonDataSet10 dataBase_Sport_MarathonDataSet10;
        private System.Windows.Forms.BindingSource transactionsRUBindingSource1;
        private DataBase_Sport_MarathonDataSet10TableAdapters.Transactions_RUTableAdapter transactions_RUTableAdapter1;
        private DataBase_Sport_MarathonDataSet12 dataBase_Sport_MarathonDataSet12;
        private System.Windows.Forms.BindingSource transactionsRUBindingSource2;
        private DataBase_Sport_MarathonDataSet12TableAdapters.Transactions_RUTableAdapter transactions_RUTableAdapter2;
        private Components.Test_Button test_Button1;
        private DataBase_Sport_MarathonDataSet13 dataBase_Sport_MarathonDataSet13;
        private System.Windows.Forms.BindingSource transactionsRUBindingSource3;
        private DataBase_Sport_MarathonDataSet13TableAdapters.Transactions_RUTableAdapter transactions_RUTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Марафон;
        private System.Windows.Forms.Label label1;
    }
}