namespace NextGenKadr
{
    partial class ReportsDelete
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
            this.button2 = new System.Windows.Forms.Button();
            this.Удалить_Button = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.Удалить_Button);
            this.splitContainer1.Size = new System.Drawing.Size(957, 594);
            this.splitContainer1.SplitterDistance = 495;
            this.splitContainer1.TabIndex = 0;
            // 
            // Поле_список_отчетов_Grid
            // 
            this.Поле_список_отчетов_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Поле_список_отчетов_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Поле_список_отчетов_Grid.Location = new System.Drawing.Point(0, 0);
            this.Поле_список_отчетов_Grid.Name = "Поле_список_отчетов_Grid";
            this.Поле_список_отчетов_Grid.RowHeadersWidth = 51;
            this.Поле_список_отчетов_Grid.RowTemplate.Height = 24;
            this.Поле_список_отчетов_Grid.Size = new System.Drawing.Size(957, 495);
            this.Поле_список_отчетов_Grid.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(570, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Закрыть_Click);
            // 
            // Удалить_Button
            // 
            this.Удалить_Button.Location = new System.Drawing.Point(300, 24);
            this.Удалить_Button.Name = "Удалить_Button";
            this.Удалить_Button.Size = new System.Drawing.Size(110, 59);
            this.Удалить_Button.TabIndex = 0;
            this.Удалить_Button.Text = "Удалить";
            this.Удалить_Button.UseVisualStyleBackColor = true;
            this.Удалить_Button.Click += new System.EventHandler(this.Удалить_отчет);
            // 
            // ReportsDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(957, 594);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ReportsDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Поле_список_отчетов_Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView Поле_список_отчетов_Grid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Удалить_Button;
    }
}