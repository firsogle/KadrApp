
namespace NextGenKadr.Other
{
    partial class Grid_Журнал
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
            this.Поле_список_отчетов_Grid = new System.Windows.Forms.DataGridView();
            this.Закрыть_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Поле_список_отчетов_Grid)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.Поле_список_отчетов_Grid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.splitContainer1.Panel2.Controls.Add(this.Закрыть_Button);
            this.splitContainer1.Size = new System.Drawing.Size(962, 475);
            this.splitContainer1.SplitterDistance = 396;
            this.splitContainer1.TabIndex = 0;
            // 
            // Поле_список_отчетов_Grid
            // 
            this.Поле_список_отчетов_Grid.AllowUserToAddRows = false;
            this.Поле_список_отчетов_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Поле_список_отчетов_Grid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Поле_список_отчетов_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Поле_список_отчетов_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Поле_список_отчетов_Grid.Location = new System.Drawing.Point(0, 0);
            this.Поле_список_отчетов_Grid.Margin = new System.Windows.Forms.Padding(4);
            this.Поле_список_отчетов_Grid.Name = "Поле_список_отчетов_Grid";
            this.Поле_список_отчетов_Grid.RowHeadersWidth = 51;
            this.Поле_список_отчетов_Grid.Size = new System.Drawing.Size(962, 396);
            this.Поле_список_отчетов_Grid.TabIndex = 3;
            // 
            // Закрыть_Button
            // 
            this.Закрыть_Button.Location = new System.Drawing.Point(424, 11);
            this.Закрыть_Button.Name = "Закрыть_Button";
            this.Закрыть_Button.Size = new System.Drawing.Size(114, 53);
            this.Закрыть_Button.TabIndex = 12;
            this.Закрыть_Button.Text = "Закрыть";
            this.Закрыть_Button.UseVisualStyleBackColor = true;
            this.Закрыть_Button.Click += new System.EventHandler(this.Закрыть_Click);
            // 
            // Grid_Журнал
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 475);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Grid_Журнал";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Поле_список_отчетов_Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Закрыть;
        private System.Windows.Forms.DataGridView Поле_список_отчетов_Grid;
        private System.Windows.Forms.Button Закрыть_Button;
    }
}