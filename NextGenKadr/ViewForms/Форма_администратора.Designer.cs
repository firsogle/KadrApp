namespace NextGenKadr
{
    partial class AdminForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolstrip2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ViewPersonStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Reports = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.Просмотреть_отчеты_Button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Добавить_пользователя_Button = new System.Windows.Forms.ToolStripButton();
            this.Изменить_пользователя_Button = new System.Windows.Forms.ToolStripButton();
            this.Удалить_пользователя_Button = new System.Windows.Forms.ToolStripButton();
            this.Список_пользователей_Button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Удалить_записей_БД_Button = new System.Windows.Forms.ToolStripButton();
            this.Изменить_путь_к_БД_Button = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.опрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolstrip2,
            this.toolStripButton3,
            this.ViewPersonStrip,
            this.toolStripButton5,
            this.toolStripSeparator1,
            this.Reports,
            this.toolStripButton11,
            this.Просмотреть_отчеты_Button,
            this.toolStripSeparator2,
            this.Добавить_пользователя_Button,
            this.Изменить_пользователя_Button,
            this.Удалить_пользователя_Button,
            this.Список_пользователей_Button,
            this.toolStripSeparator3,
            this.Удалить_записей_БД_Button,
            this.Изменить_путь_к_БД_Button,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(190, 566);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdminForm_MouseMove);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(187, 24);
            this.toolStripButton1.Text = "Добавить сотрудника";
            this.toolStripButton1.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // toolstrip2
            // 
            this.toolstrip2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolstrip2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstrip2.Name = "toolstrip2";
            this.toolstrip2.Size = new System.Drawing.Size(187, 24);
            this.toolstrip2.Text = "Изменить сотрудника";
            this.toolstrip2.Click += new System.EventHandler(this.Update_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(187, 24);
            this.toolStripButton3.Text = "Уволить сотрудника";
            this.toolStripButton3.Click += new System.EventHandler(this.DeletePerson_Click);
            // 
            // ViewPersonStrip
            // 
            this.ViewPersonStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ViewPersonStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ViewPersonStrip.Name = "ViewPersonStrip";
            this.ViewPersonStrip.Size = new System.Drawing.Size(187, 24);
            this.ViewPersonStrip.Text = "Просмотреть сотрудника";
            this.ViewPersonStrip.Click += new System.EventHandler(this.ViewPersonStrip_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(187, 24);
            this.toolStripButton5.Text = "Экспорт в Excel";
            this.toolStripButton5.Click += new System.EventHandler(this.Export_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // Reports
            // 
            this.Reports.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Reports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(187, 24);
            this.Reports.Text = "Создать приказы";
            this.Reports.Click += new System.EventHandler(this.Reports_Click);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(187, 24);
            this.toolStripButton11.Text = "Удалить приказы";
            this.toolStripButton11.Click += new System.EventHandler(this.DeleteReports_Click);
            // 
            // Просмотреть_отчеты_Button
            // 
            this.Просмотреть_отчеты_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Просмотреть_отчеты_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Просмотреть_отчеты_Button.Name = "Просмотреть_отчеты_Button";
            this.Просмотреть_отчеты_Button.Size = new System.Drawing.Size(187, 24);
            this.Просмотреть_отчеты_Button.Text = "Список приказов";
            this.Просмотреть_отчеты_Button.Click += new System.EventHandler(this.ViewReports_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
            // 
            // Добавить_пользователя_Button
            // 
            this.Добавить_пользователя_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Добавить_пользователя_Button.Image = ((System.Drawing.Image)(resources.GetObject("Добавить_пользователя_Button.Image")));
            this.Добавить_пользователя_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Добавить_пользователя_Button.Name = "Добавить_пользователя_Button";
            this.Добавить_пользователя_Button.Size = new System.Drawing.Size(187, 24);
            this.Добавить_пользователя_Button.Text = "Добавить пользователя";
            this.Добавить_пользователя_Button.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // Изменить_пользователя_Button
            // 
            this.Изменить_пользователя_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Изменить_пользователя_Button.Image = ((System.Drawing.Image)(resources.GetObject("Изменить_пользователя_Button.Image")));
            this.Изменить_пользователя_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Изменить_пользователя_Button.Name = "Изменить_пользователя_Button";
            this.Изменить_пользователя_Button.Size = new System.Drawing.Size(187, 24);
            this.Изменить_пользователя_Button.Text = "Изменить пользователя";
            this.Изменить_пользователя_Button.Click += new System.EventHandler(this.EditUser_Click);
            // 
            // Удалить_пользователя_Button
            // 
            this.Удалить_пользователя_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Удалить_пользователя_Button.Image = ((System.Drawing.Image)(resources.GetObject("Удалить_пользователя_Button.Image")));
            this.Удалить_пользователя_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Удалить_пользователя_Button.Name = "Удалить_пользователя_Button";
            this.Удалить_пользователя_Button.Size = new System.Drawing.Size(187, 24);
            this.Удалить_пользователя_Button.Text = "Удалить пользователя";
            this.Удалить_пользователя_Button.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // Список_пользователей_Button
            // 
            this.Список_пользователей_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Список_пользователей_Button.Image = ((System.Drawing.Image)(resources.GetObject("Список_пользователей_Button.Image")));
            this.Список_пользователей_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Список_пользователей_Button.Name = "Список_пользователей_Button";
            this.Список_пользователей_Button.Size = new System.Drawing.Size(187, 24);
            this.Список_пользователей_Button.Text = "Список пользователей";
            this.Список_пользователей_Button.Click += new System.EventHandler(this.UsersList_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(187, 6);
            // 
            // Удалить_записей_БД_Button
            // 
            this.Удалить_записей_БД_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Удалить_записей_БД_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Удалить_записей_БД_Button.Name = "Удалить_записей_БД_Button";
            this.Удалить_записей_БД_Button.Size = new System.Drawing.Size(187, 24);
            this.Удалить_записей_БД_Button.Text = "Удалить записи БД";
            this.Удалить_записей_БД_Button.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Изменить_путь_к_БД_Button
            // 
            this.Изменить_путь_к_БД_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Изменить_путь_к_БД_Button.Image = ((System.Drawing.Image)(resources.GetObject("Изменить_путь_к_БД_Button.Image")));
            this.Изменить_путь_к_БД_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Изменить_путь_к_БД_Button.Name = "Изменить_путь_к_БД_Button";
            this.Изменить_путь_к_БД_Button.Size = new System.Drawing.Size(187, 24);
            this.Изменить_путь_к_БД_Button.Text = "Изменить путь к БД";
            this.Изменить_путь_к_БД_Button.Click += new System.EventHandler(this.Path_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(187, 24);
            this.toolStripButton2.Text = "Просмотреть журнал";
            this.toolStripButton2.Click += new System.EventHandler(this.Просмотреть_журнал);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1005, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdminForm_MouseMove);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.опрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.справкаToolStripMenuItem.Text = "Спра&вка";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(193, 6);
            // 
            // опрограммеToolStripMenuItem
            // 
            this.опрограммеToolStripMenuItem.Name = "опрограммеToolStripMenuItem";
            this.опрограммеToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.опрограммеToolStripMenuItem.Text = "&О программе...";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Bold);
            this.UserLabel.Location = new System.Drawing.Point(228, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(101, 24);
            this.UserLabel.TabIndex = 5;
            this.UserLabel.Text = "UserLabel";
            this.UserLabel.Click += new System.EventHandler(this.UserLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(972, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Exit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Администратор";
            // 
            // MainGrid
            // 
            this.MainGrid.AllowUserToAddRows = false;
            this.MainGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainGrid.Location = new System.Drawing.Point(190, 28);
            this.MainGrid.Margin = new System.Windows.Forms.Padding(4);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.RowHeadersWidth = 51;
            this.MainGrid.Size = new System.Drawing.Size(815, 566);
            this.MainGrid.TabIndex = 9;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 594);
            this.Controls.Add(this.MainGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "Кадровый помошник";
            this.Activated += new System.EventHandler(this.AdminForm_Activated);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdminForm_MouseMove);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton ViewPersonStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolstrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton Reports;
        private System.Windows.Forms.ToolStripButton Просмотреть_отчеты_Button;
        private System.Windows.Forms.ToolStripButton Удалить_записей_БД_Button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Добавить_пользователя_Button;
        private System.Windows.Forms.ToolStripButton Удалить_пользователя_Button;
        private System.Windows.Forms.ToolStripButton Изменить_пользователя_Button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton Изменить_путь_к_БД_Button;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton Список_пользователей_Button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem опрограммеToolStripMenuItem;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridView MainGrid;
    }
}

