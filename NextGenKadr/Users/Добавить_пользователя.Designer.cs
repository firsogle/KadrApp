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
            this.Login_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Password_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ReTypePassword_Box = new System.Windows.Forms.TextBox();
            this.Admin_radioButton = new System.Windows.Forms.RadioButton();
            this.User_radioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Login_Box
            // 
            this.Login_Box.Location = new System.Drawing.Point(296, 105);
            this.Login_Box.Name = "Login_Box";
            this.Login_Box.Size = new System.Drawing.Size(220, 22);
            this.Login_Box.TabIndex = 0;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "Создать пользователя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(479, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 56);
            this.button2.TabIndex = 5;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // Password_Box
            // 
            this.Password_Box.Location = new System.Drawing.Point(296, 171);
            this.Password_Box.Name = "Password_Box";
            this.Password_Box.Size = new System.Drawing.Size(220, 22);
            this.Password_Box.TabIndex = 2;
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
            // ReTypePassword_Box
            // 
            this.ReTypePassword_Box.Location = new System.Drawing.Point(296, 235);
            this.ReTypePassword_Box.Name = "ReTypePassword_Box";
            this.ReTypePassword_Box.Size = new System.Drawing.Size(220, 22);
            this.ReTypePassword_Box.TabIndex = 10;
            // 
            // Admin_radioButton
            // 
            this.Admin_radioButton.AutoSize = true;
            this.Admin_radioButton.Location = new System.Drawing.Point(292, 323);
            this.Admin_radioButton.Name = "Admin_radioButton";
            this.Admin_radioButton.Size = new System.Drawing.Size(132, 21);
            this.Admin_radioButton.TabIndex = 14;
            this.Admin_radioButton.TabStop = true;
            this.Admin_radioButton.Text = "Администратор";
            this.Admin_radioButton.UseVisualStyleBackColor = true;
            // 
            // User_radioButton
            // 
            this.User_radioButton.AutoSize = true;
            this.User_radioButton.Location = new System.Drawing.Point(292, 296);
            this.User_radioButton.Name = "User_radioButton";
            this.User_radioButton.Size = new System.Drawing.Size(122, 21);
            this.User_radioButton.TabIndex = 15;
            this.User_radioButton.TabStop = true;
            this.User_radioButton.Text = "Пользователь";
            this.User_radioButton.UseVisualStyleBackColor = true;
            // 
            // Добавить_пользователя
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 472);
            this.Controls.Add(this.User_radioButton);
            this.Controls.Add(this.Admin_radioButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReTypePassword_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login_Box);
            this.Name = "Добавить_пользователя";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Password_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ReTypePassword_Box;
        private System.Windows.Forms.RadioButton Admin_radioButton;
        private System.Windows.Forms.RadioButton User_radioButton;
    }
}