namespace NextGenKadr
{
    partial class ListDelete
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

       

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
       #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Экспорт_в_Word_Button = new System.Windows.Forms.Button();
            this.Табельный_номер_Box = new System.Windows.Forms.TextBox();
            this.Отчество_Box = new System.Windows.Forms.TextBox();
            this.Имя_Box = new System.Windows.Forms.TextBox();
            this.Фамилия_Box = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Закрыть = new System.Windows.Forms.Button();
            this.Дата_увольнения_Picker = new System.Windows.Forms.DateTimePicker();
            this.Причина_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Экспорт_в_Word_Button
            // 
            this.Экспорт_в_Word_Button.ForeColor = System.Drawing.Color.DarkBlue;
            this.Экспорт_в_Word_Button.Location = new System.Drawing.Point(149, 206);
            this.Экспорт_в_Word_Button.Name = "Экспорт_в_Word_Button";
            this.Экспорт_в_Word_Button.Size = new System.Drawing.Size(132, 42);
            this.Экспорт_в_Word_Button.TabIndex = 0;
            this.Экспорт_в_Word_Button.Text = "Эспорт Word";
            this.Экспорт_в_Word_Button.UseVisualStyleBackColor = true;
            this.Экспорт_в_Word_Button.Click += new System.EventHandler(this.Создать_Click);
            // 
            // Табельный_номер_Box
            // 
            this.Табельный_номер_Box.Location = new System.Drawing.Point(136, 137);
            this.Табельный_номер_Box.Name = "Табельный_номер_Box";
            this.Табельный_номер_Box.ReadOnly = true;
            this.Табельный_номер_Box.Size = new System.Drawing.Size(100, 22);
            this.Табельный_номер_Box.TabIndex = 50;
            // 
            // Отчество_Box
            // 
            this.Отчество_Box.Location = new System.Drawing.Point(136, 105);
            this.Отчество_Box.Name = "Отчество_Box";
            this.Отчество_Box.ReadOnly = true;
            this.Отчество_Box.Size = new System.Drawing.Size(100, 22);
            this.Отчество_Box.TabIndex = 48;
            // 
            // Имя_Box
            // 
            this.Имя_Box.Location = new System.Drawing.Point(136, 68);
            this.Имя_Box.Name = "Имя_Box";
            this.Имя_Box.ReadOnly = true;
            this.Имя_Box.Size = new System.Drawing.Size(100, 22);
            this.Имя_Box.TabIndex = 46;
            // 
            // Фамилия_Box
            // 
            this.Фамилия_Box.Location = new System.Drawing.Point(136, 31);
            this.Фамилия_Box.Name = "Фамилия_Box";
            this.Фамилия_Box.ReadOnly = true;
            this.Фамилия_Box.Size = new System.Drawing.Size(100, 22);
            this.Фамилия_Box.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 17);
            this.label13.TabIndex = 49;
            this.label13.Text = "Табельный номер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Фамилия";
            // 
            // Закрыть
            // 
            this.Закрыть.Location = new System.Drawing.Point(357, 206);
            this.Закрыть.Name = "Закрыть";
            this.Закрыть.Size = new System.Drawing.Size(132, 42);
            this.Закрыть.TabIndex = 54;
            this.Закрыть.Text = "Закрыть";
            this.Закрыть.UseVisualStyleBackColor = true;
            this.Закрыть.Click += new System.EventHandler(this.Закрыть_Click);
            // 
            // Дата_увольнения_Picker
            // 
            this.Дата_увольнения_Picker.CustomFormat = "yyyy.MM.dd";
            this.Дата_увольнения_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Дата_увольнения_Picker.Location = new System.Drawing.Point(286, 103);
            this.Дата_увольнения_Picker.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.Дата_увольнения_Picker.Name = "Дата_увольнения_Picker";
            this.Дата_увольнения_Picker.Size = new System.Drawing.Size(100, 22);
            this.Дата_увольнения_Picker.TabIndex = 82;
            this.Дата_увольнения_Picker.Value = new System.DateTime(2020, 5, 24, 18, 40, 19, 0);
            // 
            // Причина_Box
            // 
            this.Причина_Box.Location = new System.Drawing.Point(286, 48);
            this.Причина_Box.Name = "Причина_Box";
            this.Причина_Box.ReadOnly = true;
            this.Причина_Box.Size = new System.Drawing.Size(342, 22);
            this.Причина_Box.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 80;
            this.label2.Text = "Дата увольнения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 79;
            this.label1.Text = "Причина увольнения";
            // 
            // ListDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(661, 275);
            this.Controls.Add(this.Фамилия_Box);
            this.Controls.Add(this.Дата_увольнения_Picker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Причина_Box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Имя_Box);
            this.Controls.Add(this.Закрыть);
            this.Controls.Add(this.Табельный_номер_Box);
            this.Controls.Add(this.Отчество_Box);
            this.Controls.Add(this.Экспорт_в_Word_Button);
            this.Name = "ListDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать отчет об увольнении";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Экспорт_в_Word_Button;
        private System.Windows.Forms.TextBox Табельный_номер_Box;
        private System.Windows.Forms.TextBox Отчество_Box;
        private System.Windows.Forms.TextBox Имя_Box;
        private System.Windows.Forms.TextBox Фамилия_Box;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Закрыть;
        private System.Windows.Forms.DateTimePicker Дата_увольнения_Picker;
        private System.Windows.Forms.TextBox Причина_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}