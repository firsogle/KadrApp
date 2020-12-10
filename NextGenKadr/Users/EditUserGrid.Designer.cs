namespace NextGenKadr
{
    partial class EditUserGrid
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
            this.User_radioButton = new System.Windows.Forms.RadioButton();
            this.Admin_radioButton = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.Root_Box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Password_Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Login_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Изменить пользователя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Edit_Click);
            // 
            // User_radioButton
            // 
            this.User_radioButton.AutoSize = true;
            this.User_radioButton.Location = new System.Drawing.Point(298, 259);
            this.User_radioButton.Name = "User_radioButton";
            this.User_radioButton.Size = new System.Drawing.Size(122, 21);
            this.User_radioButton.TabIndex = 26;
            this.User_radioButton.TabStop = true;
            this.User_radioButton.Text = "Пользователь";
            this.User_radioButton.UseVisualStyleBackColor = true;
            // 
            // Admin_radioButton
            // 
            this.Admin_radioButton.AutoSize = true;
            this.Admin_radioButton.Location = new System.Drawing.Point(298, 286);
            this.Admin_radioButton.Name = "Admin_radioButton";
            this.Admin_radioButton.Size = new System.Drawing.Size(132, 21);
            this.Admin_radioButton.TabIndex = 25;
            this.Admin_radioButton.TabStop = true;
            this.Admin_radioButton.Text = "Администратор";
            this.Admin_radioButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Повторите пароля";
            // 
            // Root_Box
            // 
            this.Root_Box.Location = new System.Drawing.Point(298, 195);
            this.Root_Box.Name = "Root_Box";
            this.Root_Box.Size = new System.Drawing.Size(220, 22);
            this.Root_Box.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Права";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(429, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 48);
            this.button4.TabIndex = 21;
            this.button4.Text = "Закрыть";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Придумайте пароль от 5 символов";
            // 
            // Password_Box
            // 
            this.Password_Box.Location = new System.Drawing.Point(298, 131);
            this.Password_Box.Name = "Password_Box";
            this.Password_Box.Size = new System.Drawing.Size(220, 22);
            this.Password_Box.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Логин";
            // 
            // Login_Box
            // 
            this.Login_Box.Location = new System.Drawing.Point(298, 65);
            this.Login_Box.Name = "Login_Box";
            this.Login_Box.Size = new System.Drawing.Size(220, 22);
            this.Login_Box.TabIndex = 16;
            // 
            // EditUserGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 472);
            this.Controls.Add(this.User_radioButton);
            this.Controls.Add(this.Admin_radioButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Root_Box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Password_Box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Login_Box);
            this.Controls.Add(this.button1);
            this.Name = "EditUserGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменить пользователя";
            this.Load += new System.EventHandler(this.EditUserGrid_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton User_radioButton;
        private System.Windows.Forms.RadioButton Admin_radioButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Root_Box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Password_Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Login_Box;
    }
}