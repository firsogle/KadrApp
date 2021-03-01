namespace NextGenKadr
{
    partial class PathToDB
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
            this.Изменить_путь_к_базе_Button = new System.Windows.Forms.Button();
            this.Путь_к_базе_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Закрыть_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Изменить_путь_к_базе_Button
            // 
            this.Изменить_путь_к_базе_Button.Location = new System.Drawing.Point(146, 157);
            this.Изменить_путь_к_базе_Button.Name = "Изменить_путь_к_базе_Button";
            this.Изменить_путь_к_базе_Button.Size = new System.Drawing.Size(103, 43);
            this.Изменить_путь_к_базе_Button.TabIndex = 0;
            this.Изменить_путь_к_базе_Button.Text = "Изменить путь к базе";
            this.Изменить_путь_к_базе_Button.UseVisualStyleBackColor = true;
            this.Изменить_путь_к_базе_Button.Click += new System.EventHandler(this.Изменить_путь_Click);
            // 
            // Путь_к_базе_TextBox
            // 
            this.Путь_к_базе_TextBox.Location = new System.Drawing.Point(40, 72);
            this.Путь_к_базе_TextBox.Name = "Путь_к_базе_TextBox";
            this.Путь_к_базе_TextBox.Size = new System.Drawing.Size(539, 22);
            this.Путь_к_базе_TextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Путь к базе:";
            // 
            // Закрыть_Button
            // 
            this.Закрыть_Button.Location = new System.Drawing.Point(349, 157);
            this.Закрыть_Button.Name = "Закрыть_Button";
            this.Закрыть_Button.Size = new System.Drawing.Size(104, 43);
            this.Закрыть_Button.TabIndex = 3;
            this.Закрыть_Button.Text = "Закрыть";
            this.Закрыть_Button.UseVisualStyleBackColor = true;
            this.Закрыть_Button.Click += new System.EventHandler(this.Close);
            // 
            // PathToDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(613, 247);
            this.Controls.Add(this.Закрыть_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Путь_к_базе_TextBox);
            this.Controls.Add(this.Изменить_путь_к_базе_Button);
            this.Name = "PathToDB";
            this.Text = "Изменения пути к базе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Изменить_путь_к_базе_Button;
        private System.Windows.Forms.TextBox Путь_к_базе_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Закрыть_Button;
    }
}