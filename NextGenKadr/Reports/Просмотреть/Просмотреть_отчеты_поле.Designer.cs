namespace NextGenKadr
{
    partial class ViewReportsGrid
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
            this.Поле_список_отчетов = new System.Windows.Forms.DataGridView();
            this.Выбрать_запись = new System.Windows.Forms.Button();
            this.Закрыть = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Поле_список_отчетов)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.Поле_список_отчетов);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Выбрать_запись);
            this.splitContainer1.Panel2.Controls.Add(this.Закрыть);
            this.splitContainer1.Size = new System.Drawing.Size(965, 489);
            this.splitContainer1.SplitterDistance = 408;
            this.splitContainer1.TabIndex = 0;
            // 
            // Поле_список_отчетов
            // 
            this.Поле_список_отчетов.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Поле_список_отчетов.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Поле_список_отчетов.Location = new System.Drawing.Point(0, 0);
            this.Поле_список_отчетов.Name = "Поле_список_отчетов";
            this.Поле_список_отчетов.RowHeadersWidth = 51;
            this.Поле_список_отчетов.RowTemplate.Height = 24;
            this.Поле_список_отчетов.Size = new System.Drawing.Size(965, 408);
            this.Поле_список_отчетов.TabIndex = 0;
            // 
            // Выбрать_запись
            // 
            this.Выбрать_запись.Enabled = false;
            this.Выбрать_запись.Location = new System.Drawing.Point(344, 7);
            this.Выбрать_запись.Name = "Выбрать_запись";
            this.Выбрать_запись.Size = new System.Drawing.Size(113, 58);
            this.Выбрать_запись.TabIndex = 1;
            this.Выбрать_запись.Text = "Выбрать запись";
            this.Выбрать_запись.UseVisualStyleBackColor = true;
            this.Выбрать_запись.Click += new System.EventHandler(this.Экспорт_Click);
            // 
            // Закрыть
            // 
            this.Закрыть.Location = new System.Drawing.Point(501, 7);
            this.Закрыть.Name = "Закрыть";
            this.Закрыть.Size = new System.Drawing.Size(113, 58);
            this.Закрыть.TabIndex = 0;
            this.Закрыть.Text = "Закрыть";
            this.Закрыть.UseVisualStyleBackColor = true;
            this.Закрыть.Click += new System.EventHandler(this.Закрыть_Click);
            // 
            // ViewReportsGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 489);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ViewReportsGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Поле_список_отчетов)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView Поле_список_отчетов;
        private System.Windows.Forms.Button Закрыть;
        private System.Windows.Forms.Button Выбрать_запись;
    }
}