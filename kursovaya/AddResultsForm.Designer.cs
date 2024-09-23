namespace kursovaya
{
    partial class AddResultsForm
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
            this.labelEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.test_Button1 = new kursovaya.Components.Test_Button();
            this.saveButton = new kursovaya.Components.Test_Button();
            this.label13 = new System.Windows.Forms.Label();
            this.placeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.formDesign1 = new kursovaya.Components.FormDesign(this.components);
            this.timeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelEmail.Location = new System.Drawing.Point(229, 94);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(64, 27);
            this.labelEmail.TabIndex = 125;
            this.labelEmail.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(166, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 124;
            this.label1.Text = "Email:";
            // 
            // test_Button1
            // 
            this.test_Button1.BackColor = System.Drawing.Color.Transparent;
            this.test_Button1.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.test_Button1.ForeColor = System.Drawing.Color.Black;
            this.test_Button1.Location = new System.Drawing.Point(280, 254);
            this.test_Button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.test_Button1.Name = "test_Button1";
            this.test_Button1.Rounding = 30;
            this.test_Button1.RoundingEnable = true;
            this.test_Button1.Size = new System.Drawing.Size(171, 55);
            this.test_Button1.TabIndex = 123;
            this.test_Button1.Text = "Cancel";
            this.test_Button1.Click += new System.EventHandler(this.test_Button1_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(83, 254);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Rounding = 30;
            this.saveButton.RoundingEnable = true;
            this.saveButton.Size = new System.Drawing.Size(171, 55);
            this.saveButton.TabIndex = 122;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(172, 29);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(202, 27);
            this.label13.TabIndex = 121;
            this.label13.Text = "Результаты бегуна";
            // 
            // placeTextBox
            // 
            this.placeTextBox.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.placeTextBox.Location = new System.Drawing.Point(229, 187);
            this.placeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.placeTextBox.Name = "placeTextBox";
            this.placeTextBox.Size = new System.Drawing.Size(200, 34);
            this.placeTextBox.TabIndex = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.Location = new System.Drawing.Point(148, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 119;
            this.label2.Text = "Место:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label6.Location = new System.Drawing.Point(148, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 23);
            this.label6.TabIndex = 117;
            this.label6.Text = "Время:";
            // 
            // formDesign1
            // 
            this.formDesign1.Form = this;
            this.formDesign1.FormStyle = kursovaya.Components.FormDesign.fStyle.None;
            // 
            // timeMaskedTextBox
            // 
            this.timeMaskedTextBox.Font = new System.Drawing.Font("Tahoma", 16.2F);
            this.timeMaskedTextBox.Location = new System.Drawing.Point(229, 138);
            this.timeMaskedTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timeMaskedTextBox.Mask = "00:00:00";
            this.timeMaskedTextBox.Name = "timeMaskedTextBox";
            this.timeMaskedTextBox.Size = new System.Drawing.Size(200, 34);
            this.timeMaskedTextBox.TabIndex = 126;
            this.timeMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.timeMaskedTextBox.Click += new System.EventHandler(this.timeMaskedTextBox_Click);
            this.timeMaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.timeMaskedTextBox_Validating);
            // 
            // AddResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 328);
            this.Controls.Add(this.timeMaskedTextBox);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.test_Button1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.placeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddResultsForm";
            this.Text = "AddResultsForm";
            this.Load += new System.EventHandler(this.AddResultsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label label1;
        private Components.Test_Button test_Button1;
        private Components.Test_Button saveButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox placeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private Components.FormDesign formDesign1;
        private System.Windows.Forms.MaskedTextBox timeMaskedTextBox;
    }
}