namespace NextGenKadr
{
    partial class Bol
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
            this.label7 = new System.Windows.Forms.Label();
            this.DateOtp_Box = new System.Windows.Forms.DateTimePicker();
            this.NumberOtp_Box = new System.Windows.Forms.TextBox();
            this.Number_ID = new System.Windows.Forms.TextBox();
            this.Patronymic_Box = new System.Windows.Forms.TextBox();
            this.Name_Box = new System.Windows.Forms.TextBox();
            this.Surname_Box = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Bol2_Picker = new System.Windows.Forms.DateTimePicker();
            this.Bol1_Picker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.DateDoc_Box = new System.Windows.Forms.DateTimePicker();
            this.NumberDoc_Box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 70;
            this.label7.Text = "Дата приказа";
            // 
            // DateOtp_Box
            // 
            this.DateOtp_Box.CustomFormat = "yyyy.MM.dd";
            this.DateOtp_Box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOtp_Box.Location = new System.Drawing.Point(424, 126);
            this.DateOtp_Box.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.DateOtp_Box.Name = "DateOtp_Box";
            this.DateOtp_Box.Size = new System.Drawing.Size(100, 22);
            this.DateOtp_Box.TabIndex = 69;
            this.DateOtp_Box.Value = new System.DateTime(2020, 5, 24, 18, 40, 20, 0);
            // 
            // NumberOtp_Box
            // 
            this.NumberOtp_Box.Location = new System.Drawing.Point(424, 84);
            this.NumberOtp_Box.Name = "NumberOtp_Box";
            this.NumberOtp_Box.Size = new System.Drawing.Size(100, 22);
            this.NumberOtp_Box.TabIndex = 68;
            // 
            // Number_ID
            // 
            this.Number_ID.Location = new System.Drawing.Point(424, 50);
            this.Number_ID.Name = "Number_ID";
            this.Number_ID.ReadOnly = true;
            this.Number_ID.Size = new System.Drawing.Size(100, 22);
            this.Number_ID.TabIndex = 67;
            // 
            // Patronymic_Box
            // 
            this.Patronymic_Box.Location = new System.Drawing.Point(126, 126);
            this.Patronymic_Box.Name = "Patronymic_Box";
            this.Patronymic_Box.ReadOnly = true;
            this.Patronymic_Box.Size = new System.Drawing.Size(100, 22);
            this.Patronymic_Box.TabIndex = 65;
            // 
            // Name_Box
            // 
            this.Name_Box.Location = new System.Drawing.Point(126, 89);
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.ReadOnly = true;
            this.Name_Box.Size = new System.Drawing.Size(100, 22);
            this.Name_Box.TabIndex = 63;
            // 
            // Surname_Box
            // 
            this.Surname_Box.Location = new System.Drawing.Point(126, 52);
            this.Surname_Box.Name = "Surname_Box";
            this.Surname_Box.ReadOnly = true;
            this.Surname_Box.Size = new System.Drawing.Size(100, 22);
            this.Surname_Box.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(291, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 17);
            this.label13.TabIndex = 66;
            this.label13.Text = "Табельный номер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 64;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 62;
            this.label5.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 60;
            this.label6.Text = "Фамилия";
            // 
            // Bol2_Picker
            // 
            this.Bol2_Picker.CustomFormat = "yyyy.MM.dd";
            this.Bol2_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Bol2_Picker.Location = new System.Drawing.Point(126, 191);
            this.Bol2_Picker.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.Bol2_Picker.Name = "Bol2_Picker";
            this.Bol2_Picker.Size = new System.Drawing.Size(100, 22);
            this.Bol2_Picker.TabIndex = 59;
            this.Bol2_Picker.Value = new System.DateTime(2020, 5, 24, 18, 40, 20, 0);
            // 
            // Bol1_Picker
            // 
            this.Bol1_Picker.CustomFormat = "yyyy.MM.dd";
            this.Bol1_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Bol1_Picker.Location = new System.Drawing.Point(126, 159);
            this.Bol1_Picker.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.Bol1_Picker.Name = "Bol1_Picker";
            this.Bol1_Picker.Size = new System.Drawing.Size(100, 22);
            this.Bol1_Picker.TabIndex = 58;
            this.Bol1_Picker.Value = new System.DateTime(2020, 5, 24, 18, 40, 20, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "До";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "От";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Номер приказа";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 36);
            this.button1.TabIndex = 54;
            this.button1.Text = "Создать отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Report_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 72;
            this.label8.Text = "Дата документа";
            // 
            // DateDoc_Box
            // 
            this.DateDoc_Box.CustomFormat = "yyyy.MM.dd";
            this.DateDoc_Box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateDoc_Box.Location = new System.Drawing.Point(424, 191);
            this.DateDoc_Box.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.DateDoc_Box.Name = "DateDoc_Box";
            this.DateDoc_Box.Size = new System.Drawing.Size(100, 22);
            this.DateDoc_Box.TabIndex = 71;
            this.DateDoc_Box.Value = new System.DateTime(2020, 5, 24, 18, 40, 20, 0);
            // 
            // NumberDoc_Box
            // 
            this.NumberDoc_Box.Location = new System.Drawing.Point(424, 154);
            this.NumberDoc_Box.Name = "NumberDoc_Box";
            this.NumberDoc_Box.Size = new System.Drawing.Size(100, 22);
            this.NumberDoc_Box.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 17);
            this.label9.TabIndex = 73;
            this.label9.Text = "Номер документа";
            // 
            // Bol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 353);
            this.Controls.Add(this.NumberDoc_Box);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DateDoc_Box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DateOtp_Box);
            this.Controls.Add(this.NumberOtp_Box);
            this.Controls.Add(this.Number_ID);
            this.Controls.Add(this.Patronymic_Box);
            this.Controls.Add(this.Name_Box);
            this.Controls.Add(this.Surname_Box);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Bol2_Picker);
            this.Controls.Add(this.Bol1_Picker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Bol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DateOtp_Box;
        private System.Windows.Forms.TextBox NumberOtp_Box;
        private System.Windows.Forms.TextBox Number_ID;
        private System.Windows.Forms.TextBox Patronymic_Box;
        private System.Windows.Forms.TextBox Name_Box;
        private System.Windows.Forms.TextBox Surname_Box;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Bol2_Picker;
        private System.Windows.Forms.DateTimePicker Bol1_Picker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DateDoc_Box;
        private System.Windows.Forms.TextBox NumberDoc_Box;
        private System.Windows.Forms.Label label9;
    }
}