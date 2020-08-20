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
            this.button1 = new System.Windows.Forms.Button();
            this.But_Del = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Reason = new System.Windows.Forms.TextBox();
            this.IdReason = new System.Windows.Forms.TextBox();
            this.Patronymic_Box = new System.Windows.Forms.TextBox();
            this.Name_Box = new System.Windows.Forms.TextBox();
            this.Surname_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ContractTerm_Picker = new System.Windows.Forms.DateTimePicker();
            this.label65 = new System.Windows.Forms.Label();
            this.NumOr2_Box = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.NumberContract_Box = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.Position_Box = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.Phone_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // But_Del
            // 
            this.But_Del.Location = new System.Drawing.Point(212, 362);
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
            this.label1.Location = new System.Drawing.Point(27, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Укажите причину увольнения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер приказа";
            // 
            // Reason
            // 
            this.Reason.Location = new System.Drawing.Point(246, 197);
            this.Reason.Name = "Reason";
            this.Reason.Size = new System.Drawing.Size(508, 22);
            this.Reason.TabIndex = 6;
            // 
            // IdReason
            // 
            this.IdReason.Location = new System.Drawing.Point(246, 244);
            this.IdReason.Name = "IdReason";
            this.IdReason.Size = new System.Drawing.Size(508, 22);
            this.IdReason.TabIndex = 7;
            // 
            // Patronymic_Box
            // 
            this.Patronymic_Box.Location = new System.Drawing.Point(212, 87);
            this.Patronymic_Box.Name = "Patronymic_Box";
            this.Patronymic_Box.Size = new System.Drawing.Size(100, 22);
            this.Patronymic_Box.TabIndex = 14;
            // 
            // Name_Box
            // 
            this.Name_Box.Location = new System.Drawing.Point(212, 52);
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.Size = new System.Drawing.Size(100, 22);
            this.Name_Box.TabIndex = 12;
            // 
            // Surname_Box
            // 
            this.Surname_Box.Location = new System.Drawing.Point(212, 17);
            this.Surname_Box.Name = "Surname_Box";
            this.Surname_Box.Size = new System.Drawing.Size(100, 22);
            this.Surname_Box.TabIndex = 10;
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
            // ContractTerm_Picker
            // 
            this.ContractTerm_Picker.CustomFormat = "yyyy.MM.dd";
            this.ContractTerm_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ContractTerm_Picker.Location = new System.Drawing.Point(606, 115);
            this.ContractTerm_Picker.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.ContractTerm_Picker.Name = "ContractTerm_Picker";
            this.ContractTerm_Picker.Size = new System.Drawing.Size(100, 22);
            this.ContractTerm_Picker.TabIndex = 73;
            this.ContractTerm_Picker.Value = new System.DateTime(2020, 5, 24, 18, 40, 19, 0);
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
            // NumOr2_Box
            // 
            this.NumOr2_Box.Location = new System.Drawing.Point(606, 87);
            this.NumOr2_Box.Name = "NumOr2_Box";
            this.NumOr2_Box.Size = new System.Drawing.Size(100, 22);
            this.NumOr2_Box.TabIndex = 71;
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
            // NumberContract_Box
            // 
            this.NumberContract_Box.Location = new System.Drawing.Point(606, 54);
            this.NumberContract_Box.Name = "NumberContract_Box";
            this.NumberContract_Box.Size = new System.Drawing.Size(100, 22);
            this.NumberContract_Box.TabIndex = 69;
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
            // Position_Box
            // 
            this.Position_Box.Location = new System.Drawing.Point(606, 20);
            this.Position_Box.Name = "Position_Box";
            this.Position_Box.Size = new System.Drawing.Size(100, 22);
            this.Position_Box.TabIndex = 67;
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
            // Phone_Box
            // 
            this.Phone_Box.Location = new System.Drawing.Point(212, 120);
            this.Phone_Box.Name = "Phone_Box";
            this.Phone_Box.Size = new System.Drawing.Size(100, 22);
            this.Phone_Box.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "Телефон";
            // 
            // DeletePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Phone_Box);
            this.Controls.Add(this.ContractTerm_Picker);
            this.Controls.Add(this.label65);
            this.Controls.Add(this.NumOr2_Box);
            this.Controls.Add(this.label64);
            this.Controls.Add(this.NumberContract_Box);
            this.Controls.Add(this.label63);
            this.Controls.Add(this.Position_Box);
            this.Controls.Add(this.label62);
            this.Controls.Add(this.Patronymic_Box);
            this.Controls.Add(this.Name_Box);
            this.Controls.Add(this.Surname_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IdReason);
            this.Controls.Add(this.Reason);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.But_Del);
            this.Controls.Add(this.button1);
            this.Name = "DeletePerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Увольнение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button But_Del;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Reason;
        private System.Windows.Forms.TextBox IdReason;
        private System.Windows.Forms.TextBox Patronymic_Box;
        private System.Windows.Forms.TextBox Name_Box;
        private System.Windows.Forms.TextBox Surname_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ContractTerm_Picker;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TextBox NumOr2_Box;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox NumberContract_Box;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.TextBox Position_Box;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.TextBox Phone_Box;
        private System.Windows.Forms.Label label3;
    }
}