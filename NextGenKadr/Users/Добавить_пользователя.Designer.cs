namespace NextGenKadr.Users
{
    partial class Добавить_пользователя
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
            this.Логин_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Создать_пользователя_Box = new System.Windows.Forms.Button();
            this.Закрыть_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Пароль_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Повтор_пароля_Box = new System.Windows.Forms.TextBox();
            this.Администратор_radioButton = new System.Windows.Forms.RadioButton();
            this.Пользователь_radioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Логин_Box
            // 
            this.Логин_Box.Location = new System.Drawing.Point(296, 105);
            this.Логин_Box.Name = "Логин_Box";
            this.Логин_Box.Size = new System.Drawing.Size(220, 22);
            this.Логин_Box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // Создать_пользователя_Box
            // 
            this.Создать_пользователя_Box.Location = new System.Drawing.Point(201, 379);
            this.Создать_пользователя_Box.Name = "Создать_пользователя_Box";
            this.Создать_пользователя_Box.Size = new System.Drawing.Size(124, 56);
            this.Создать_пользователя_Box.TabIndex = 4;
            this.Создать_пользователя_Box.Text = "Создать пользователя";
            this.Создать_пользователя_Box.UseVisualStyleBackColor = true;
            this.Создать_пользователя_Box.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // Закрыть_Button
            // 
            this.Закрыть_Button.Location = new System.Drawing.Point(479, 379);
            this.Закрыть_Button.Name = "Закрыть_Button";
            this.Закрыть_Button.Size = new System.Drawing.Size(103, 56);
            this.Закрыть_Button.TabIndex = 5;
            this.Закрыть_Button.Text = "Закрыть";
            this.Закрыть_Button.UseVisualStyleBackColor = true;
            this.Закрыть_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Права";
            // 
            // Пароль_Box
            // 
            this.Пароль_Box.Location = new System.Drawing.Point(296, 171);
            this.Пароль_Box.Name = "Пароль_Box";
            this.Пароль_Box.Size = new System.Drawing.Size(220, 22);
            this.Пароль_Box.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Придумайте пароль от 5 символов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Повторите пароля";
            // 
            // Повтор_пароля_Box
            // 
            this.Повтор_пароля_Box.Location = new System.Drawing.Point(296, 235);
            this.Повтор_пароля_Box.Name = "Повтор_пароля_Box";
            this.Повтор_пароля_Box.Size = new System.Drawing.Size(220, 22);
            this.Повтор_пароля_Box.TabIndex = 10;
            // 
            // Администратор_radioButton
            // 
            this.Администратор_radioButton.AutoSize = true;
            this.Администратор_radioButton.Location = new System.Drawing.Point(292, 323);
            this.Администратор_radioButton.Name = "Администратор_radioButton";
            this.Администратор_radioButton.Size = new System.Drawing.Size(132, 21);
            this.Администратор_radioButton.TabIndex = 14;
            this.Администратор_radioButton.TabStop = true;
            this.Администратор_radioButton.Text = "Администратор";
            this.Администратор_radioButton.UseVisualStyleBackColor = true;
            // 
            // Пользователь_radioButton
            // 
            this.Пользователь_radioButton.AutoSize = true;
            this.Пользователь_radioButton.Location = new System.Drawing.Point(292, 296);
            this.Пользователь_radioButton.Name = "Пользователь_radioButton";
            this.Пользователь_radioButton.Size = new System.Drawing.Size(122, 21);
            this.Пользователь_radioButton.TabIndex = 15;
            this.Пользователь_radioButton.TabStop = true;
            this.Пользователь_radioButton.Text = "Пользователь";
            this.Пользователь_radioButton.UseVisualStyleBackColor = true;
            // 
            // Добавить_пользователя
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(762, 472);
            this.Controls.Add(this.Пользователь_radioButton);
            this.Controls.Add(this.Администратор_radioButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Повтор_пароля_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Закрыть_Button);
            this.Controls.Add(this.Создать_пользователя_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Пароль_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Логин_Box);
            this.Name = "Добавить_пользователя";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Логин_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Создать_пользователя_Box;
        private System.Windows.Forms.Button Закрыть_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Пароль_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Повтор_пароля_Box;
        private System.Windows.Forms.RadioButton Администратор_radioButton;
        private System.Windows.Forms.RadioButton Пользователь_radioButton;
    }
}