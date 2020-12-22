namespace NextGenKadr
{
    partial class DeletePerson
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
            this.Закрыть = new System.Windows.Forms.Button();
            this.But_Del = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Причина_Box = new System.Windows.Forms.TextBox();
            this.Отчество_Box = new System.Windows.Forms.TextBox();
            this.Имя_Box = new System.Windows.Forms.TextBox();
            this.Фамилия_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Срок_договора_Picker = new System.Windows.Forms.DateTimePicker();
            this.label65 = new System.Windows.Forms.Label();
            this.Номер_приказа_Box = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.Номер_договора_Box = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.Должность_Box = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.Табельный_номер_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Дата_увольнения_Picker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Закрыть
            // 
            this.Закрыть.Location = new System.Drawing.Point(482, 359);
            this.Закрыть.Name = "Закрыть";
            this.Закрыть.Size = new System.Drawing.Size(111, 55);
            this.Закрыть.TabIndex = 0;
            this.Закрыть.Text = "Закрыть";
            this.Закрыть.UseVisualStyleBackColor = true;
            this.Закрыть.Click += new System.EventHandler(this.Закрыть_Click);
            // 
            // But_Del
            // 
            this.But_Del.Location = new System.Drawing.Point(239, 359);
            this.But_Del.Name = "But_Del";
            this.But_Del.Size = new System.Drawing.Size(132, 55);
            this.But_Del.TabIndex = 1;
            this.But_Del.Text = "Уволить сотрудника";
            this.But_Del.UseVisualStyleBackColor = true;
            this.But_Del.Click += new System.EventHandler(this.But_Del_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Укажите причину увольнения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата увольнения";
            // 
            // Причина_Box
            // 
            this.Причина_Box.Location = new System.Drawing.Point(246, 197);
            this.Причина_Box.Name = "Причина_Box";
            this.Причина_Box.Size = new System.Drawing.Size(508, 22);
            this.Причина_Box.TabIndex = 6;
            // 
            // Отчество_Box
            // 
            this.Отчество_Box.Location = new System.Drawing.Point(212, 87);
            this.Отчество_Box.Name = "Отчество_Box";
            this.Отчество_Box.Size = new System.Drawing.Size(100, 22);
            this.Отчество_Box.TabIndex = 14;
            // 
            // Имя_Box
            // 
            this.Имя_Box.Location = new System.Drawing.Point(212, 52);
            this.Имя_Box.Name = "Имя_Box";
            this.Имя_Box.Size = new System.Drawing.Size(100, 22);
            this.Имя_Box.TabIndex = 12;
            // 
            // Фамилия_Box
            // 
            this.Фамилия_Box.Location = new System.Drawing.Point(212, 17);
            this.Фамилия_Box.Name = "Фамилия_Box";
            this.Фамилия_Box.Size = new System.Drawing.Size(100, 22);
            this.Фамилия_Box.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Фамилия";
            // 
            // Срок_договора_Picker
            // 
            this.Срок_договора_Picker.CustomFormat = "yyyy.MM.dd";
            this.Срок_договора_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Срок_договора_Picker.Location = new System.Drawing.Point(606, 115);
            this.Срок_договора_Picker.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.Срок_договора_Picker.Name = "Срок_договора_Picker";
            this.Срок_договора_Picker.Size = new System.Drawing.Size(100, 22);
            this.Срок_договора_Picker.TabIndex = 73;
            this.Срок_договора_Picker.Value = new System.DateTime(2020, 5, 24, 18, 40, 19, 0);
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(418, 120);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(104, 17);
            this.label65.TabIndex = 72;
            this.label65.Text = "Срок договора";
            // 
            // Номер_приказа_Box
            // 
            this.Номер_приказа_Box.Location = new System.Drawing.Point(606, 87);
            this.Номер_приказа_Box.Name = "Номер_приказа_Box";
            this.Номер_приказа_Box.Size = new System.Drawing.Size(100, 22);
            this.Номер_приказа_Box.TabIndex = 71;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(418, 87);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(82, 17);
            this.label64.TabIndex = 70;
            this.label64.Text = "№ Приказа";
            // 
            // Номер_договора_Box
            // 
            this.Номер_договора_Box.Location = new System.Drawing.Point(606, 54);
            this.Номер_договора_Box.Name = "Номер_договора_Box";
            this.Номер_договора_Box.Size = new System.Drawing.Size(100, 22);
            this.Номер_договора_Box.TabIndex = 69;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(418, 54);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(89, 17);
            this.label63.TabIndex = 68;
            this.label63.Text = "№ Договора";
            // 
            // Должность_Box
            // 
            this.Должность_Box.Location = new System.Drawing.Point(606, 20);
            this.Должность_Box.Name = "Должность_Box";
            this.Должность_Box.Size = new System.Drawing.Size(100, 22);
            this.Должность_Box.TabIndex = 67;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(418, 20);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(81, 17);
            this.label62.TabIndex = 66;
            this.label62.Text = "Должность";
            // 
            // Табельный_номер_Box
            // 
            this.Табельный_номер_Box.Location = new System.Drawing.Point(212, 120);
            this.Табельный_номер_Box.Name = "Табельный_номер_Box";
            this.Табельный_номер_Box.Size = new System.Drawing.Size(100, 22);
            this.Табельный_номер_Box.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "Табельный номер";
            // 
            // Дата_увольнения_Picker
            // 
            this.Дата_увольнения_Picker.CustomFormat = "yyyy.MM.dd";
            this.Дата_увольнения_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Дата_увольнения_Picker.Location = new System.Drawing.Point(246, 247);
            this.Дата_увольнения_Picker.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.Дата_увольнения_Picker.Name = "Дата_увольнения_Picker";
            this.Дата_увольнения_Picker.Size = new System.Drawing.Size(100, 22);
            this.Дата_увольнения_Picker.TabIndex = 76;
            this.Дата_увольнения_Picker.Value = new System.DateTime(2020, 5, 24, 18, 40, 19, 0);
            // 
            // DeletePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Дата_увольнения_Picker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Табельный_номер_Box);
            this.Controls.Add(this.Срок_договора_Picker);
            this.Controls.Add(this.label65);
            this.Controls.Add(this.Номер_приказа_Box);
            this.Controls.Add(this.label64);
            this.Controls.Add(this.Номер_договора_Box);
            this.Controls.Add(this.label63);
            this.Controls.Add(this.Должность_Box);
            this.Controls.Add(this.label62);
            this.Controls.Add(this.Отчество_Box);
            this.Controls.Add(this.Имя_Box);
            this.Controls.Add(this.Фамилия_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Причина_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.But_Del);
            this.Controls.Add(this.Закрыть);
            this.Name = "DeletePerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Увольнение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Закрыть;
        private System.Windows.Forms.Button But_Del;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Причина_Box;
        private System.Windows.Forms.TextBox Отчество_Box;
        private System.Windows.Forms.TextBox Имя_Box;
        private System.Windows.Forms.TextBox Фамилия_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Срок_договора_Picker;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TextBox Номер_приказа_Box;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox Номер_договора_Box;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.TextBox Должность_Box;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.TextBox Табельный_номер_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Дата_увольнения_Picker;
    }
}