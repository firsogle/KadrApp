namespace NextGenKadr
{
    partial class Com
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
            this.До_Picker = new System.Windows.Forms.DateTimePicker();
            this.От_Picker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Создать_отчет = new System.Windows.Forms.Button();
            this.Место_командировки_Box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Цель_Box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Закрыть = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Сотрудник = new System.Windows.Forms.GroupBox();
            this.Фамилия_Box = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.Имя_Box = new System.Windows.Forms.TextBox();
            this.Отчество_Box = new System.Windows.Forms.TextBox();
            this.Табельный_номер_Box = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.Сотрудник.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 70;
            this.label7.Text = "Дата приказа";
            // 
            // Дата_приказа_Box
            // 
            this.Дата_приказа_Box.CustomFormat = "yyyy.MM.dd";
            this.Дата_приказа_Box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Дата_приказа_Box.Location = new System.Drawing.Point(150, 183);
            this.Дата_приказа_Box.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.Дата_приказа_Box.Name = "Дата_приказа_Box";
            this.Дата_приказа_Box.Size = new System.Drawing.Size(100, 22);
            this.Дата_приказа_Box.TabIndex = 69;
            this.Дата_приказа_Box.Value = new System.DateTime(2020, 5, 24, 18, 40, 20, 0);
            // 
            // Номер_приказа_Box
            // 
            this.Номер_приказа_Box.Location = new System.Drawing.Point(17, 183);
            this.Номер_приказа_Box.Name = "Номер_приказа_Box";
            this.Номер_приказа_Box.Size = new System.Drawing.Size(106, 22);
            this.Номер_приказа_Box.TabIndex = 68;
            this.Номер_приказа_Box.Enter += new System.EventHandler(this.Номер_Enter);
            this.Номер_приказа_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            this.Номер_приказа_Box.Leave += new System.EventHandler(this.Номер_Leave);
            // 
            // До_Picker
            // 
            this.До_Picker.CustomFormat = "yyyy.MM.dd";
            this.До_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.До_Picker.Location = new System.Drawing.Point(150, 130);
            this.До_Picker.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.До_Picker.Name = "До_Picker";
            this.До_Picker.Size = new System.Drawing.Size(100, 22);
            this.До_Picker.TabIndex = 59;
            this.До_Picker.Value = new System.DateTime(2020, 5, 24, 18, 40, 20, 0);
            // 
            // От_Picker
            // 
            this.От_Picker.CustomFormat = "yyyy.MM.dd";
            this.От_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.От_Picker.Location = new System.Drawing.Point(18, 130);
            this.От_Picker.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.От_Picker.Name = "От_Picker";
            this.От_Picker.Size = new System.Drawing.Size(100, 22);
            this.От_Picker.TabIndex = 58;
            this.От_Picker.Value = new System.DateTime(2020, 5, 24, 18, 40, 20, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "До";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "От";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Номер приказа";
            // 
            // Создать_отчет
            // 
            this.Создать_отчет.Location = new System.Drawing.Point(159, 256);
            this.Создать_отчет.Name = "Создать_отчет";
            this.Создать_отчет.Size = new System.Drawing.Size(151, 55);
            this.Создать_отчет.TabIndex = 54;
            this.Создать_отчет.Text = "Создать отчет";
            this.Создать_отчет.UseVisualStyleBackColor = true;
            this.Создать_отчет.Click += new System.EventHandler(this.Report_Click);
            // 
            // Место_командировки_Box
            // 
            this.Место_командировки_Box.Location = new System.Drawing.Point(18, 43);
            this.Место_командировки_Box.Name = "Место_командировки_Box";
            this.Место_командировки_Box.Size = new System.Drawing.Size(319, 22);
            this.Место_командировки_Box.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 17);
            this.label8.TabIndex = 71;
            this.label8.Text = "Место командировки";
            // 
            // Цель_Box
            // 
            this.Цель_Box.Location = new System.Drawing.Point(18, 88);
            this.Цель_Box.Name = "Цель_Box";
            this.Цель_Box.Size = new System.Drawing.Size(319, 22);
            this.Цель_Box.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 73;
            this.label9.Text = "Цель";
            // 
            // Закрыть
            // 
            this.Закрыть.Location = new System.Drawing.Point(360, 256);
            this.Закрыть.Name = "Закрыть";
            this.Закрыть.Size = new System.Drawing.Size(147, 55);
            this.Закрыть.TabIndex = 81;
            this.Закрыть.Text = "Закрыть";
            this.Закрыть.UseVisualStyleBackColor = true;
            this.Закрыть.Click += new System.EventHandler(this.Закрыть_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.До_Picker);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.От_Picker);
            this.groupBox2.Controls.Add(this.Дата_приказа_Box);
            this.groupBox2.Controls.Add(this.Цель_Box);
            this.groupBox2.Controls.Add(this.Номер_приказа_Box);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Место_командировки_Box);
            this.groupBox2.Location = new System.Drawing.Point(332, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 214);
            this.groupBox2.TabIndex = 80;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Командировка";
            // 
            // Сотрудник
            // 
            this.Сотрудник.Controls.Add(this.Фамилия_Box);
            this.Сотрудник.Controls.Add(this.label17);
            this.Сотрудник.Controls.Add(this.label18);
            this.Сотрудник.Controls.Add(this.label19);
            this.Сотрудник.Controls.Add(this.label20);
            this.Сотрудник.Controls.Add(this.Имя_Box);
            this.Сотрудник.Controls.Add(this.Отчество_Box);
            this.Сотрудник.Controls.Add(this.Табельный_номер_Box);
            this.Сотрудник.Location = new System.Drawing.Point(8, 24);
            this.Сотрудник.Name = "Сотрудник";
            this.Сотрудник.Size = new System.Drawing.Size(318, 204);
            this.Сотрудник.TabIndex = 79;
            this.Сотрудник.TabStop = false;
            this.Сотрудник.Text = "Сотрудник";
            // 
            // Фамилия_Box
            // 
            this.Фамилия_Box.Location = new System.Drawing.Point(142, 41);
            this.Фамилия_Box.Name = "Фамилия_Box";
            this.Фамилия_Box.ReadOnly = true;
            this.Фамилия_Box.Size = new System.Drawing.Size(151, 22);
            this.Фамилия_Box.TabIndex = 61;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(62, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 17);
            this.label17.TabIndex = 60;
            this.label17.Text = "Фамилия";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(97, 80);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 17);
            this.label18.TabIndex = 62;
            this.label18.Text = "Имя";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(61, 120);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 17);
            this.label19.TabIndex = 64;
            this.label19.Text = "Отчество";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 156);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(127, 17);
            this.label20.TabIndex = 66;
            this.label20.Text = "Табельный номер";
            // 
            // Имя_Box
            // 
            this.Имя_Box.Location = new System.Drawing.Point(142, 78);
            this.Имя_Box.Name = "Имя_Box";
            this.Имя_Box.ReadOnly = true;
            this.Имя_Box.Size = new System.Drawing.Size(151, 22);
            this.Имя_Box.TabIndex = 63;
            // 
            // Отчество_Box
            // 
            this.Отчество_Box.Location = new System.Drawing.Point(142, 115);
            this.Отчество_Box.Name = "Отчество_Box";
            this.Отчество_Box.ReadOnly = true;
            this.Отчество_Box.Size = new System.Drawing.Size(151, 22);
            this.Отчество_Box.TabIndex = 65;
            // 
            // Табельный_номер_Box
            // 
            this.Табельный_номер_Box.Location = new System.Drawing.Point(142, 153);
            this.Табельный_номер_Box.Name = "Табельный_номер_Box";
            this.Табельный_номер_Box.ReadOnly = true;
            this.Табельный_номер_Box.Size = new System.Drawing.Size(151, 22);
            this.Табельный_номер_Box.TabIndex = 67;
            // 
            // Com
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 343);
            this.Controls.Add(this.Закрыть);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Сотрудник);
            this.Controls.Add(this.Создать_отчет);
            this.Name = "Com";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать отчет о командировке";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Сотрудник.ResumeLayout(false);
            this.Сотрудник.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Дата_приказа_Box;
        private System.Windows.Forms.TextBox Номер_приказа_Box;
        private System.Windows.Forms.DateTimePicker До_Picker;
        private System.Windows.Forms.DateTimePicker От_Picker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Создать_отчет;
        private System.Windows.Forms.TextBox Место_командировки_Box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Цель_Box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Закрыть;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox Сотрудник;
        private System.Windows.Forms.TextBox Фамилия_Box;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox Имя_Box;
        private System.Windows.Forms.TextBox Отчество_Box;
        private System.Windows.Forms.TextBox Табельный_номер_Box;
    }
}