namespace kursovaya
{
    partial class ResultsMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formDesign1 = new kursovaya.Components.FormDesign(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Выбрать = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.test_Button6 = new kursovaya.Components.Test_Button();
            this.label9 = new System.Windows.Forms.Label();
            this.test_Button5 = new kursovaya.Components.Test_Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // formDesign1
            // 
            this.formDesign1.Form = this;
            this.formDesign1.FormStyle = kursovaya.Components.FormDesign.fStyle.None;
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
            this.comboBox1.Location = new System.Drawing.Point(944, 224);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 41);
            this.comboBox1.TabIndex = 102;
            this.comboBox1.Text = "Название_Компании";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(818, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 101;
            this.label2.Text = "Поиск по:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(850, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 100;
            this.label1.Text = "Поиск:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(944, 287);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 40);
            this.textBox1.TabIndex = 99;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Выбрать});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(50, 420);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 36;
            this.dataGridView1.Size = new System.Drawing.Size(1181, 356);
            this.dataGridView1.TabIndex = 98;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(461, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 45);
            this.label6.TabIndex = 97;
            this.label6.Text = "Список бегунов";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // test_Button6
            // 
            this.test_Button6.BackColor = System.Drawing.Color.Transparent;
            this.test_Button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_Button6.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.test_Button6.ForeColor = System.Drawing.Color.Black;
            this.test_Button6.Location = new System.Drawing.Point(1081, 13);
            this.test_Button6.Margin = new System.Windows.Forms.Padding(4);
            this.test_Button6.Name = "test_Button6";
            this.test_Button6.Rounding = 40;
            this.test_Button6.RoundingEnable = true;
            this.test_Button6.Size = new System.Drawing.Size(179, 68);
            this.test_Button6.TabIndex = 96;
            this.test_Button6.Text = "Logout";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(200, 18);
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
            this.test_Button5.Location = new System.Drawing.Point(13, 13);
            this.test_Button5.Margin = new System.Windows.Forms.Padding(4);
            this.test_Button5.Name = "test_Button5";
            this.test_Button5.Rounding = 40;
            this.test_Button5.RoundingEnable = true;
            this.test_Button5.Size = new System.Drawing.Size(179, 68);
            this.test_Button5.TabIndex = 94;
            this.test_Button5.Text = "Назад";
            // 
            // ResultsMenu
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
            this.Name = "ResultsMenu";
            this.Text = "ResultsMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.FormDesign formDesign1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Выбрать;
        private System.Windows.Forms.Label label6;
        private Components.Test_Button test_Button6;
        private System.Windows.Forms.Label label9;
        private Components.Test_Button test_Button5;
    }
}