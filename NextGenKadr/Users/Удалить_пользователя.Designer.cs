﻿namespace NextGenKadr
{
    partial class DeleteUser
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Поле_пользователей_Grid = new System.Windows.Forms.DataGridView();
            this.Удалить_пользователя_Button = new System.Windows.Forms.Button();
            this.Закрыть = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Поле_пользователей_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Поле_пользователей_Grid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.splitContainer1.Panel2.Controls.Add(this.Удалить_пользователя_Button);
            this.splitContainer1.Panel2.Controls.Add(this.Закрыть);
            this.splitContainer1.Size = new System.Drawing.Size(442, 453);
            this.splitContainer1.SplitterDistance = 355;
            this.splitContainer1.TabIndex = 0;
            // 
            // Поле_пользователей_Grid
            // 
            this.Поле_пользователей_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Поле_пользователей_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Поле_пользователей_Grid.Location = new System.Drawing.Point(0, 0);
            this.Поле_пользователей_Grid.Name = "Поле_пользователей_Grid";
            this.Поле_пользователей_Grid.RowHeadersWidth = 51;
            this.Поле_пользователей_Grid.RowTemplate.Height = 24;
            this.Поле_пользователей_Grid.Size = new System.Drawing.Size(442, 355);
            this.Поле_пользователей_Grid.TabIndex = 0;
            // 
            // Удалить_пользователя_Button
            // 
            this.Удалить_пользователя_Button.Location = new System.Drawing.Point(76, 19);
            this.Удалить_пользователя_Button.Name = "Удалить_пользователя_Button";
            this.Удалить_пользователя_Button.Size = new System.Drawing.Size(112, 55);
            this.Удалить_пользователя_Button.TabIndex = 1;
            this.Удалить_пользователя_Button.Text = "Удалить пользователя";
            this.Удалить_пользователя_Button.UseVisualStyleBackColor = true;
            this.Удалить_пользователя_Button.Click += new System.EventHandler(this.Select_CLick);
            // 
            // Закрыть
            // 
            this.Закрыть.Location = new System.Drawing.Point(259, 19);
            this.Закрыть.Name = "Закрыть";
            this.Закрыть.Size = new System.Drawing.Size(107, 55);
            this.Закрыть.TabIndex = 0;
            this.Закрыть.Text = "Закрыть";
            this.Закрыть.UseVisualStyleBackColor = true;
            this.Закрыть.Click += new System.EventHandler(this.Закрыть_Click);
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 453);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DeleteUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удалить пользователя";
            this.Load += new System.EventHandler(this.DeleteUser_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Поле_пользователей_Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView Поле_пользователей_Grid;
        private System.Windows.Forms.Button Закрыть;
        private System.Windows.Forms.Button Удалить_пользователя_Button;
    }
}