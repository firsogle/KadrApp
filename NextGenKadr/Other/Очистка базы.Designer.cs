namespace NextGenKadr
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.Удалить_всех_пользователей_Button = new System.Windows.Forms.Button();
            this.button3aУдалить_всех_сотрудников_Button = new System.Windows.Forms.Button();
            this.Очистить_базу_данных_Button = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Закрыть_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // Удалить_всех_пользователей_Button
            // 
            this.Удалить_всех_пользователей_Button.Location = new System.Drawing.Point(14, 24);
            this.Удалить_всех_пользователей_Button.Name = "Удалить_всех_пользователей_Button";
            this.Удалить_всех_пользователей_Button.Size = new System.Drawing.Size(156, 70);
            this.Удалить_всех_пользователей_Button.TabIndex = 6;
            this.Удалить_всех_пользователей_Button.Text = "Удалить всех пользователей";
            this.Удалить_всех_пользователей_Button.UseVisualStyleBackColor = true;
            this.Удалить_всех_пользователей_Button.Click += new System.EventHandler(this.Удалить_пользователей_Click);
            // 
            // button3aУдалить_всех_сотрудников_Button
            // 
            this.button3aУдалить_всех_сотрудников_Button.Location = new System.Drawing.Point(14, 112);
            this.button3aУдалить_всех_сотрудников_Button.Name = "button3aУдалить_всех_сотрудников_Button";
            this.button3aУдалить_всех_сотрудников_Button.Size = new System.Drawing.Size(156, 65);
            this.button3aУдалить_всех_сотрудников_Button.TabIndex = 7;
            this.button3aУдалить_всех_сотрудников_Button.Text = "Удалить всех сотрудников";
            this.button3aУдалить_всех_сотрудников_Button.UseVisualStyleBackColor = true;
            this.button3aУдалить_всех_сотрудников_Button.Click += new System.EventHandler(this.Удалить_сотрудников_Click);
            // 
            // Очистить_базу_данных_Button
            // 
            this.Очистить_базу_данных_Button.Location = new System.Drawing.Point(201, 24);
            this.Очистить_базу_данных_Button.Name = "Очистить_базу_данных_Button";
            this.Очистить_базу_данных_Button.Size = new System.Drawing.Size(158, 70);
            this.Очистить_базу_данных_Button.TabIndex = 8;
            this.Очистить_базу_данных_Button.Text = "Очистить базу данных";
            this.Очистить_базу_данных_Button.UseVisualStyleBackColor = true;
            this.Очистить_базу_данных_Button.Click += new System.EventHandler(this.Удалить_всё_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(201, 112);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 65);
            this.button5.TabIndex = 9;
            this.button5.Text = "Удалить все отчеты";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Удалить_отчеты_Click);
            // 
            // Закрыть_Button
            // 
            this.Закрыть_Button.Location = new System.Drawing.Point(121, 231);
            this.Закрыть_Button.Name = "Закрыть_Button";
            this.Закрыть_Button.Size = new System.Drawing.Size(114, 53);
            this.Закрыть_Button.TabIndex = 11;
            this.Закрыть_Button.Text = "Закрыть";
            this.Закрыть_Button.UseVisualStyleBackColor = true;
            this.Закрыть_Button.Click += new System.EventHandler(this.Закрыть_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(381, 318);
            this.Controls.Add(this.Закрыть_Button);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Очистить_базу_данных_Button);
            this.Controls.Add(this.button3aУдалить_всех_сотрудников_Button);
            this.Controls.Add(this.Удалить_всех_пользователей_Button);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.Text = "Очистка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Удалить_всех_пользователей_Button;
        private System.Windows.Forms.Button button3aУдалить_всех_сотрудников_Button;
        private System.Windows.Forms.Button Очистить_базу_данных_Button;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Закрыть_Button;
    }
}