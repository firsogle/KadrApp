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
            this.Дата_приказа_Box = new System.Windows.Forms.DateTimePicker();
            this.Номер_приказа_Box = new System.Windows.Forms.TextBox();
            this.Табельный_номер_Box = new System.Windows.Forms.TextBox();
            this.Отчество_Box = new System.Windows.Forms.TextBox();
            this.Имя_Box = new System.Windows.Forms.TextBox();
            this.Фамилия_Box = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.До_Picker = new System.Windows.Forms.DateTimePicker();
            this.От_Picker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Создать_отчет = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Дата_документа_Box = new System.Windows.Forms.DateTimePicker();
            this.Номер_листа_нетрудоспособности_Box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Сотрудник = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Закрыть = new System.Windows.Forms.Button();
            this.Сотрудник.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 70;
            this.label7.Text = "Дата приказа";
            // 
            // Дата_приказа_Box
            // 
            this.Дата_приказа_Box.CustomFormat = "yyyy.MM.dd";
            this.Дата_приказа_Box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Дата_приказа_Box.Location = new System.Drawing.Point(252, 128);
            this.Дата_приказа_Box.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.Дата_приказа_Box.Name = "Дата_приказа_Box";
            this.Дата_приказа_Box.Size = new System.Drawing.Size(100, 22);
            this.Дата_приказа_Box.TabIndex = 69;
            this.Дата_приказа_Box.Value = new System.DateTime(2020, 12, 11, 0, 0, 0, 0);
            // 
            // Номер_приказа_Box
            // 
            this.Номер_приказа_Box.Location = new System.Drawing.Point(252, 88);
            this.Номер_приказа_Box.Name = "Номер_приказа_Box";
            this.Номер_приказа_Box.Size = new System.Drawing.Size(100, 22);
            this.Номер_приказа_Box.TabIndex = 68;
            this.Номер_приказа_Box.Enter += new System.EventHandler(this.Номер_приказа_Enter);
            this.Номер_приказа_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            this.Номер_приказа_Box.Leave += new System.EventHandler(this.Номер_листа_нетрудоспособности_Leave);
            // 
            // Табельный_номер_Box
            // 
            this.Табельный_номер_Box.Location = new System.Drawing.Point(166, 151);
            this.Табельный_номер_Box.Name = "Табельный_номер_Box";
            this.Табельный_номер_Box.ReadOnly = true;
            this.Табельный_номер_Box.Size = new System.Drawing.Size(100, 22);
            this.Табельный_номер_Box.TabIndex = 67;
            // 
            // Отчество_Box
            // 
            this.Отчество_Box.Location = new System.Drawing.Point(166, 115);
            this.Отчество_Box.Name = "Отчество_Box";
            this.Отчество_Box.ReadOnly = true;
            this.Отчество_Box.Size = new System.Drawing.Size(100, 22);
            this.Отчество_Box.TabIndex = 65;
            // 
            // Имя_Box
            // 
            this.Имя_Box.Location = new System.Drawing.Point(166, 78);
            this.Имя_Box.Name = "Имя_Box";
            this.Имя_Box.ReadOnly = true;
            this.Имя_Box.Size = new System.Drawing.Size(100, 22);
            this.Имя_Box.TabIndex = 63;
            // 
            // Фамилия_Box
            // 
            this.Фамилия_Box.Location = new System.Drawing.Point(166, 41);
            this.Фамилия_Box.Name = "Фамилия_Box";
            this.Фамилия_Box.ReadOnly = true;
            this.Фамилия_Box.Size = new System.Drawing.Size(100, 22);
            this.Фамилия_Box.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 17);
            this.label13.TabIndex = 66;
            this.label13.Text = "Табельный номер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 64;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 62;
            this.label5.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 60;
            this.label6.Text = "Фамилия";
            // 
            // До_Picker
            // 
            this.До_Picker.CustomFormat = "yyyy.MM.dd";
            this.До_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.До_Picker.Location = new System.Drawing.Point(252, 54);
            this.До_Picker.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.До_Picker.Name = "До_Picker";
            this.До_Picker.Size = new System.Drawing.Size(100, 22);
            this.До_Picker.TabIndex = 59;
            this.До_Picker.Value = new System.DateTime(2020, 12, 11, 0, 0, 0, 0);
            // 
            // От_Picker
            // 
            this.От_Picker.CustomFormat = "yyyy.MM.dd";
            this.От_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.От_Picker.Location = new System.Drawing.Point(65, 54);
            this.От_Picker.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.От_Picker.Name = "От_Picker";
            this.От_Picker.Size = new System.Drawing.Size(93, 22);
            this.От_Picker.TabIndex = 58;
            this.От_Picker.Value = new System.DateTime(2020, 12, 11, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Окончание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Начало";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Номер приказа";
            // 
            // Создать_отчет
            // 
            this.Создать_отчет.Location = new System.Drawing.Point(176, 261);
            this.Создать_отчет.Name = "Создать_отчет";
            this.Создать_отчет.Size = new System.Drawing.Size(153, 55);
            this.Создать_отчет.TabIndex = 54;
            this.Создать_отчет.Text = "Создать отчет";
            this.Создать_отчет.UseVisualStyleBackColor = true;
            this.Создать_отчет.Click += new System.EventHandler(this.Report_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 72;
            this.label8.Text = "Дата документа";
            // 
            // Дата_документа_Box
            // 
            this.Дата_документа_Box.CustomFormat = "yyyy.MM.dd";
            this.Дата_документа_Box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Дата_документа_Box.Location = new System.Drawing.Point(252, 161);
            this.Дата_документа_Box.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.Дата_документа_Box.Name = "Дата_документа_Box";
            this.Дата_документа_Box.Size = new System.Drawing.Size(100, 22);
            this.Дата_документа_Box.TabIndex = 71;
            this.Дата_документа_Box.Value = new System.DateTime(2020, 12, 11, 0, 0, 0, 0);
            // 
            // Номер_листа_нетрудоспособности_Box
            // 
            this.Номер_листа_нетрудоспособности_Box.Location = new System.Drawing.Point(252, 21);
            this.Номер_листа_нетрудоспособности_Box.Name = "Номер_листа_нетрудоспособности_Box";
            this.Номер_листа_нетрудоспособности_Box.Size = new System.Drawing.Size(100, 22);
            this.Номер_листа_нетрудоспособности_Box.TabIndex = 74;
            this.Номер_листа_нетрудоспособности_Box.Enter += new System.EventHandler(this.Номер_листа_нетрудоспособности_Box_Enter);
            this.Номер_листа_нетрудоспособности_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            this.Номер_листа_нетрудоспособности_Box.Leave += new System.EventHandler(this.Номер_листа_нетрудоспособности_Box_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 17);
            this.label9.TabIndex = 73;
            this.label9.Text = "Номер листа нетрудоспособности";
            // 
            // Сотрудник
            // 
            this.Сотрудник.Controls.Add(this.Фамилия_Box);
            this.Сотрудник.Controls.Add(this.label6);
            this.Сотрудник.Controls.Add(this.label5);
            this.Сотрудник.Controls.Add(this.label4);
            this.Сотрудник.Controls.Add(this.label13);
            this.Сотрудник.Controls.Add(this.Имя_Box);
            this.Сотрудник.Controls.Add(this.Отчество_Box);
            this.Сотрудник.Controls.Add(this.Табельный_номер_Box);
            this.Сотрудник.Location = new System.Drawing.Point(12, 22);
            this.Сотрудник.Name = "Сотрудник";
            this.Сотрудник.Size = new System.Drawing.Size(318, 218);
            this.Сотрудник.TabIndex = 75;
            this.Сотрудник.TabStop = false;
            this.Сотрудник.Text = "Сотрудник";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Номер_листа_нетрудоспособности_Box);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.От_Picker);
            this.groupBox2.Controls.Add(this.Дата_документа_Box);
            this.groupBox2.Controls.Add(this.До_Picker);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Номер_приказа_Box);
            this.groupBox2.Controls.Add(this.Дата_приказа_Box);
            this.groupBox2.Location = new System.Drawing.Point(336, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 228);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Больничный";
            // 
            // Закрыть
            // 
            this.Закрыть.Location = new System.Drawing.Point(392, 261);
            this.Закрыть.Name = "Закрыть";
            this.Закрыть.Size = new System.Drawing.Size(147, 55);
            this.Закрыть.TabIndex = 77;
            this.Закрыть.Text = "Закрыть";
            this.Закрыть.UseVisualStyleBackColor = true;
            this.Закрыть.Click += new System.EventHandler(this.Закрыть_Click);
            // 
            // Bol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 328);
            this.Controls.Add(this.Закрыть);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Сотрудник);
            this.Controls.Add(this.Создать_отчет);
            this.Name = "Bol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать Создание отчета о больничном";
            this.Сотрудник.ResumeLayout(false);
            this.Сотрудник.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Дата_приказа_Box;
        private System.Windows.Forms.TextBox Номер_приказа_Box;
        private System.Windows.Forms.TextBox Табельный_номер_Box;
        private System.Windows.Forms.TextBox Отчество_Box;
        private System.Windows.Forms.TextBox Имя_Box;
        private System.Windows.Forms.TextBox Фамилия_Box;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker До_Picker;
        private System.Windows.Forms.DateTimePicker От_Picker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Создать_отчет;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker Дата_документа_Box;
        private System.Windows.Forms.TextBox Номер_листа_нетрудоспособности_Box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox Сотрудник;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Закрыть;
    }
}