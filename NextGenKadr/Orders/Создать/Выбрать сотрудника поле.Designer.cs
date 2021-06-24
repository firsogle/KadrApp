namespace NextGenKadr
{
    partial class Reports
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
            this.Список_уволенных_Button = new System.Windows.Forms.Button();
            this.Больничный_Button = new System.Windows.Forms.Button();
            this.Отпуск_Button = new System.Windows.Forms.Button();
            this.Командировка_Button = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel2.Controls.Add(this.Список_уволенных_Button);
            this.splitContainer1.Panel2.Controls.Add(this.Больничный_Button);
            this.splitContainer1.Panel2.Controls.Add(this.Отпуск_Button);
            this.splitContainer1.Panel2.Controls.Add(this.Командировка_Button);
            this.splitContainer1.Size = new System.Drawing.Size(734, 500);
            this.splitContainer1.SplitterDistance = 389;
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
            this.Поле_пользователей_Grid.Size = new System.Drawing.Size(734, 389);
            this.Поле_пользователей_Grid.TabIndex = 0;
            // 
            // Список_уволенных_Button
            // 
            this.Список_уволенных_Button.Location = new System.Drawing.Point(566, 24);
            this.Список_уволенных_Button.Name = "Список_уволенных_Button";
            this.Список_уволенных_Button.Size = new System.Drawing.Size(134, 51);
            this.Список_уволенных_Button.TabIndex = 6;
            this.Список_уволенных_Button.Text = "Создать приказ на увольнение";
            this.Список_уволенных_Button.UseVisualStyleBackColor = true;
            this.Список_уволенных_Button.Click += new System.EventHandler(this.ListDelete_Click);
            // 
            // Больничный_Button
            // 
            this.Больничный_Button.Location = new System.Drawing.Point(391, 24);
            this.Больничный_Button.Name = "Больничный_Button";
            this.Больничный_Button.Size = new System.Drawing.Size(134, 51);
            this.Больничный_Button.TabIndex = 5;
            this.Больничный_Button.Text = "Больничные";
            this.Больничный_Button.UseVisualStyleBackColor = true;
            this.Больничный_Button.Click += new System.EventHandler(this.Bol_Click);
            // 
            // Отпуск_Button
            // 
            this.Отпуск_Button.Location = new System.Drawing.Point(208, 24);
            this.Отпуск_Button.Name = "Отпуск_Button";
            this.Отпуск_Button.Size = new System.Drawing.Size(133, 51);
            this.Отпуск_Button.TabIndex = 4;
            this.Отпуск_Button.Text = "Создать приказ на отпуск";
            this.Отпуск_Button.UseVisualStyleBackColor = true;
            this.Отпуск_Button.Click += new System.EventHandler(this.Otp_Click);
            // 
            // Командировка_Button
            // 
            this.Командировка_Button.Location = new System.Drawing.Point(39, 24);
            this.Командировка_Button.Name = "Командировка_Button";
            this.Командировка_Button.Size = new System.Drawing.Size(134, 51);
            this.Командировка_Button.TabIndex = 3;
            this.Командировка_Button.Text = "Создать приказ на командировку";
            this.Командировка_Button.UseVisualStyleBackColor = true;
            this.Командировка_Button.Click += new System.EventHandler(this.Com_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 500);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбрать сотрудника";
            this.Load += new System.EventHandler(this.Reports_Load);
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
        private System.Windows.Forms.Button Больничный_Button;
        private System.Windows.Forms.Button Отпуск_Button;
        private System.Windows.Forms.Button Командировка_Button;
        private System.Windows.Forms.Button Список_уволенных_Button;
    }
}