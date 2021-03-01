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
            this.Создать_отчет_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.От_Picker = new System.Windows.Forms.DateTimePicker();
            this.До_Picker = new System.Windows.Forms.DateTimePicker();
            this.Табельный_номер_Box = new System.Windows.Forms.TextBox();
            this.Отчество_Box = new System.Windows.Forms.TextBox();
            this.Имя_Box = new System.Windows.Forms.TextBox();
            this.Фамилия_Box = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Номер_приказа_Box = new System.Windows.Forms.TextBox();
            this.Дата_приказа_Box = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.Закрыть_Button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Сотрудник = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.Сотрудник.SuspendLayout();
            this.SuspendLayout();
            // 
            // Создать_отчет_Button
            // 
            this.Создать_отчет_Button.Location = new System.Drawing.Point(164, 275);
            this.Создать_отчет_Button.Name = "Создать_отчет_Button";
            this.Создать_отчет_Button.Size = new System.Drawing.Size(139, 58);
            this.Создать_отчет_Button.TabIndex = 0;
            this.Создать_отчет_Button.Text = "Создать отчет";
            this.Создать_отчет_Button.UseVisualStyleBackColor = true;
            this.Создать_отчет_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер приказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "От";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "До";
            // 
            // От_Picker
            // 
            this.От_Picker.CustomFormat = "yyyy.MM.dd";
            this.От_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.От_Picker.Location = new System.Drawing.Point(144, 111);
            this.От_Picker.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.От_Picker.Name = "От_Picker";
            this.От_Picker.Size = new System.Drawing.Size(100, 22);
            this.От_Picker.TabIndex = 41;
            this.От_Picker.Value = new System.DateTime(2020, 5, 24, 18, 40, 20, 0);
            // 
            // До_Picker
            // 
            this.До_Picker.CustomFormat = "yyyy.MM.dd";
            this.До_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.До_Picker.Location = new System.Drawing.Point(144, 143);
            this.До_Picker.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.До_Picker.Name = "До_Picker";
            this.До_Picker.Size = new System.Drawing.Size(100, 22);
            this.До_Picker.TabIndex = 42;
            this.До_Picker.Value = new System.DateTime(2020, 5, 24, 18, 40, 20, 0);
            // 
            // Табельный_номер_Box
            // 
            this.Табельный_номер_Box.Location = new System.Drawing.Point(159, 145);
            this.Табельный_номер_Box.Name = "Табельный_номер_Box";
            this.Табельный_номер_Box.ReadOnly = true;
            this.Табельный_номер_Box.Size = new System.Drawing.Size(100, 22);
            this.Табельный_номер_Box.TabIndex = 50;
            // 
            // Отчество_Box
            // 
            this.Отчество_Box.Location = new System.Drawing.Point(159, 113);
            this.Отчество_Box.Name = "Отчество_Box";
            this.Отчество_Box.ReadOnly = true;
            this.Отчество_Box.Size = new System.Drawing.Size(100, 22);
            this.Отчество_Box.TabIndex = 48;
            // 
            // Имя_Box
            // 
            this.Имя_Box.Location = new System.Drawing.Point(159, 76);
            this.Имя_Box.Name = "Имя_Box";
            this.Имя_Box.ReadOnly = true;
            this.Имя_Box.Size = new System.Drawing.Size(100, 22);
            this.Имя_Box.TabIndex = 46;
            // 
            // Фамилия_Box
            // 
            this.Фамилия_Box.Location = new System.Drawing.Point(159, 39);
            this.Фамилия_Box.Name = "Фамилия_Box";
            this.Фамилия_Box.ReadOnly = true;
            this.Фамилия_Box.Size = new System.Drawing.Size(100, 22);
            this.Фамилия_Box.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 17);
            this.label13.TabIndex = 49;
            this.label13.Text = "Табельный номер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Фамилия";
            // 
            // Номер_приказа_Box
            // 
            this.Номер_приказа_Box.Location = new System.Drawing.Point(144, 39);
            this.Номер_приказа_Box.Name = "Номер_приказа_Box";
            this.Номер_приказа_Box.Size = new System.Drawing.Size(100, 22);
            this.Номер_приказа_Box.TabIndex = 51;
            this.Номер_приказа_Box.Enter += new System.EventHandler(this.Номер_Enter);
            this.Номер_приказа_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            this.Номер_приказа_Box.Leave += new System.EventHandler(this.Номер_Leave);
            // 
            // Дата_приказа_Box
            // 
            this.Дата_приказа_Box.CustomFormat = "yyyy.MM.dd";
            this.Дата_приказа_Box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Дата_приказа_Box.Location = new System.Drawing.Point(144, 76);
            this.Дата_приказа_Box.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.Дата_приказа_Box.Name = "Дата_приказа_Box";
            this.Дата_приказа_Box.Size = new System.Drawing.Size(100, 22);
            this.Дата_приказа_Box.TabIndex = 52;
            this.Дата_приказа_Box.Value = new System.DateTime(2020, 5, 24, 18, 40, 20, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "Дата приказа";
            // 
            // Закрыть_Button
            // 
            this.Закрыть_Button.Location = new System.Drawing.Point(358, 275);
            this.Закрыть_Button.Name = "Закрыть_Button";
            this.Закрыть_Button.Size = new System.Drawing.Size(139, 58);
            this.Закрыть_Button.TabIndex = 54;
            this.Закрыть_Button.Text = "Закрыть";
            this.Закрыть_Button.UseVisualStyleBackColor = true;
            this.Закрыть_Button.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.До_Picker);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Дата_приказа_Box);
            this.groupBox2.Controls.Add(this.От_Picker);
            this.groupBox2.Controls.Add(this.Номер_приказа_Box);
            this.groupBox2.Location = new System.Drawing.Point(368, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 204);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отпуск";
            // 
            // Сотрудник
            // 
            this.Сотрудник.Controls.Add(this.Фамилия_Box);
            this.Сотрудник.Controls.Add(this.label6);
            this.Сотрудник.Controls.Add(this.label5);
            this.Сотрудник.Controls.Add(this.label4);
            this.Сотрудник.Controls.Add(this.label13);
            this.Сотрудник.Controls.Add(this.Имя_Box);
            this.Сотрудник.Controls.Add(this.Табельный_номер_Box);
            this.Сотрудник.Controls.Add(this.Отчество_Box);
            this.Сотрудник.Location = new System.Drawing.Point(5, 44);
            this.Сотрудник.Name = "Сотрудник";
            this.Сотрудник.Size = new System.Drawing.Size(318, 204);
            this.Сотрудник.TabIndex = 77;
            this.Сотрудник.TabStop = false;
            this.Сотрудник.Text = "Сотрудник";
            // 
            // Otp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(696, 372);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Сотрудник);
            this.Controls.Add(this.Закрыть_Button);
            this.Controls.Add(this.Создать_отчет_Button);
            this.Name = "Otp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать отчет отпуска сотрудника";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Сотрудник.ResumeLayout(false);
            this.Сотрудник.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Создать_отчет_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker От_Picker;
        private System.Windows.Forms.DateTimePicker До_Picker;
        private System.Windows.Forms.TextBox Табельный_номер_Box;
        private System.Windows.Forms.TextBox Отчество_Box;
        private System.Windows.Forms.TextBox Имя_Box;
        private System.Windows.Forms.TextBox Фамилия_Box;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Номер_приказа_Box;
        private System.Windows.Forms.DateTimePicker Дата_приказа_Box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Закрыть_Button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox Сотрудник;
    }
}