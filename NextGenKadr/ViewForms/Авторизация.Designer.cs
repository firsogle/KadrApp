namespace NextGenKadr
{
    partial class Authorization
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
            this.Логин_Label = new System.Windows.Forms.Label();
            this.Пароль_Label = new System.Windows.Forms.Label();
            this.Войти_Button = new System.Windows.Forms.Button();
            this.Логин_Box = new System.Windows.Forms.TextBox();
            this.Пароль_Box = new System.Windows.Forms.TextBox();
            this.Закрыть_Button = new System.Windows.Forms.Button();
            this.Авторизация_Label = new System.Windows.Forms.Label();
            this.Кадровик_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Логин_Label
            // 
            this.Логин_Label.AutoSize = true;
            this.Логин_Label.Location = new System.Drawing.Point(149, 207);
            this.Логин_Label.Name = "Логин_Label";
            this.Логин_Label.Size = new System.Drawing.Size(47, 17);
            this.Логин_Label.TabIndex = 0;
            this.Логин_Label.Text = "Логин";
            // 
            // Пароль_Label
            // 
            this.Пароль_Label.AutoSize = true;
            this.Пароль_Label.Location = new System.Drawing.Point(149, 249);
            this.Пароль_Label.Name = "Пароль_Label";
            this.Пароль_Label.Size = new System.Drawing.Size(57, 17);
            this.Пароль_Label.TabIndex = 1;
            this.Пароль_Label.Text = "Пароль";
            // 
            // Войти_Button
            // 
            this.Войти_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Войти_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Войти_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Войти_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Войти_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Войти_Button.Location = new System.Drawing.Point(130, 388);
            this.Войти_Button.Name = "Войти_Button";
            this.Войти_Button.Size = new System.Drawing.Size(113, 51);
            this.Войти_Button.TabIndex = 2;
            this.Войти_Button.Text = "Войти";
            this.Войти_Button.UseVisualStyleBackColor = false;
            this.Войти_Button.Click += new System.EventHandler(this.Авторизация);
            // 
            // Логин_Box
            // 
            this.Логин_Box.Location = new System.Drawing.Point(218, 202);
            this.Логин_Box.Name = "Логин_Box";
            this.Логин_Box.Size = new System.Drawing.Size(252, 22);
            this.Логин_Box.TabIndex = 4;
            this.Логин_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_Box_KeyPress);
            // 
            // Пароль_Box
            // 
            this.Пароль_Box.Location = new System.Drawing.Point(218, 246);
            this.Пароль_Box.Name = "Пароль_Box";
            this.Пароль_Box.PasswordChar = '*';
            this.Пароль_Box.Size = new System.Drawing.Size(252, 22);
            this.Пароль_Box.TabIndex = 5;
            this.Пароль_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_Box_KeyPress);
            // 
            // Закрыть_Button
            // 
            this.Закрыть_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Закрыть_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Закрыть_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Закрыть_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Закрыть_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Закрыть_Button.Location = new System.Drawing.Point(434, 388);
            this.Закрыть_Button.Name = "Закрыть_Button";
            this.Закрыть_Button.Size = new System.Drawing.Size(113, 51);
            this.Закрыть_Button.TabIndex = 6;
            this.Закрыть_Button.Text = "Закрыть";
            this.Закрыть_Button.UseVisualStyleBackColor = false;
            this.Закрыть_Button.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Авторизация_Label
            // 
            this.Авторизация_Label.AutoSize = true;
            this.Авторизация_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Авторизация_Label.Location = new System.Drawing.Point(255, 140);
            this.Авторизация_Label.Name = "Авторизация_Label";
            this.Авторизация_Label.Size = new System.Drawing.Size(166, 29);
            this.Авторизация_Label.TabIndex = 7;
            this.Авторизация_Label.Text = "Авторизация";
            // 
            // Кадровик_Label
            // 
            this.Кадровик_Label.AutoSize = true;
            this.Кадровик_Label.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Кадровик_Label.Location = new System.Drawing.Point(265, 9);
            this.Кадровик_Label.Name = "Кадровик_Label";
            this.Кадровик_Label.Size = new System.Drawing.Size(134, 34);
            this.Кадровик_Label.TabIndex = 0;
            this.Кадровик_Label.Text = "АРМСКС";
            this.Кадровик_Label.Click += new System.EventHandler(this.Кадровик_Label_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.Кадровик_Label);
            this.Controls.Add(this.Авторизация_Label);
            this.Controls.Add(this.Закрыть_Button);
            this.Controls.Add(this.Пароль_Box);
            this.Controls.Add(this.Логин_Box);
            this.Controls.Add(this.Войти_Button);
            this.Controls.Add(this.Пароль_Label);
            this.Controls.Add(this.Логин_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Authorization";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Кадровый помошник";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Authorization_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Логин_Label;
        private System.Windows.Forms.Label Пароль_Label;
        private System.Windows.Forms.Button Войти_Button;
        private System.Windows.Forms.TextBox Логин_Box;
        private System.Windows.Forms.TextBox Пароль_Box;
        private System.Windows.Forms.Button Закрыть_Button;
        private System.Windows.Forms.Label Авторизация_Label;
        private System.Windows.Forms.Label Кадровик_Label;
    }
}