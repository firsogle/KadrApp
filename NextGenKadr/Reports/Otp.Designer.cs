namespace NextGenKadr
{
    partial class Otp
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Otp1_Picker = new System.Windows.Forms.DateTimePicker();
            this.Otp2_Picker = new System.Windows.Forms.DateTimePicker();
            this.Number_ID = new System.Windows.Forms.TextBox();
            this.Patronymic_Box = new System.Windows.Forms.TextBox();
            this.Name_Box = new System.Windows.Forms.TextBox();
            this.Surname_Box = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NumberOtp_Box = new System.Windows.Forms.TextBox();
            this.DateOtp_Box = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Создать отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер приказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "От";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "До";
            // 
            // Otp1_Picker
            // 
            this.Otp1_Picker.CustomFormat = "yyyy.MM.dd";
            this.Otp1_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Otp1_Picker.Location = new System.Drawing.Point(118, 210);
            this.Otp1_Picker.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.Otp1_Picker.Name = "Otp1_Picker";
            this.Otp1_Picker.Size = new System.Drawing.Size(100, 22);
            this.Otp1_Picker.TabIndex = 41;
            this.Otp1_Picker.Value = new System.DateTime(2020, 5, 24, 18, 40, 20, 0);
            // 
            // Otp2_Picker
            // 
            this.Otp2_Picker.CustomFormat = "yyyy.MM.dd";
            this.Otp2_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Otp2_Picker.Location = new System.Drawing.Point(314, 210);
            this.Otp2_Picker.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.Otp2_Picker.Name = "Otp2_Picker";
            this.Otp2_Picker.Size = new System.Drawing.Size(100, 22);
            this.Otp2_Picker.TabIndex = 42;
            this.Otp2_Picker.Value = new System.DateTime(2020, 5, 24, 18, 40, 20, 0);
            // 
            // Number_ID
            // 
            this.Number_ID.Location = new System.Drawing.Point(404, 81);
            this.Number_ID.Name = "Number_ID";
            this.Number_ID.ReadOnly = true;
            this.Number_ID.Size = new System.Drawing.Size(100, 22);
            this.Number_ID.TabIndex = 50;
            // 
            // Patronymic_Box
            // 
            this.Patronymic_Box.Location = new System.Drawing.Point(106, 152);
            this.Patronymic_Box.Name = "Patronymic_Box";
            this.Patronymic_Box.ReadOnly = true;
            this.Patronymic_Box.Size = new System.Drawing.Size(100, 22);
            this.Patronymic_Box.TabIndex = 48;
            // 
            // Name_Box
            // 
            this.Name_Box.Location = new System.Drawing.Point(106, 115);
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.ReadOnly = true;
            this.Name_Box.Size = new System.Drawing.Size(100, 22);
            this.Name_Box.TabIndex = 46;
            // 
            // Surname_Box
            // 
            this.Surname_Box.Location = new System.Drawing.Point(106, 78);
            this.Surname_Box.Name = "Surname_Box";
            this.Surname_Box.ReadOnly = true;
            this.Surname_Box.Size = new System.Drawing.Size(100, 22);
            this.Surname_Box.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(271, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 17);
            this.label13.TabIndex = 49;
            this.label13.Text = "Табельный номер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Фамилия";
            // 
            // NumberOtp_Box
            // 
            this.NumberOtp_Box.Location = new System.Drawing.Point(404, 115);
            this.NumberOtp_Box.Name = "NumberOtp_Box";
            this.NumberOtp_Box.Size = new System.Drawing.Size(100, 22);
            this.NumberOtp_Box.TabIndex = 51;
            // 
            // DateOtp_Box
            // 
            this.DateOtp_Box.CustomFormat = "yyyy.MM.dd";
            this.DateOtp_Box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOtp_Box.Location = new System.Drawing.Point(404, 152);
            this.DateOtp_Box.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.DateOtp_Box.Name = "DateOtp_Box";
            this.DateOtp_Box.Size = new System.Drawing.Size(100, 22);
            this.DateOtp_Box.TabIndex = 52;
            this.DateOtp_Box.Value = new System.DateTime(2020, 5, 24, 18, 40, 20, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "Дата приказа";
            // 
            // Otp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 344);
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
            this.Controls.Add(this.Otp2_Picker);
            this.Controls.Add(this.Otp1_Picker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Otp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Otp1_Picker;
        private System.Windows.Forms.DateTimePicker Otp2_Picker;
        private System.Windows.Forms.TextBox Number_ID;
        private System.Windows.Forms.TextBox Patronymic_Box;
        private System.Windows.Forms.TextBox Name_Box;
        private System.Windows.Forms.TextBox Surname_Box;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NumberOtp_Box;
        private System.Windows.Forms.DateTimePicker DateOtp_Box;
        private System.Windows.Forms.Label label7;
    }
}