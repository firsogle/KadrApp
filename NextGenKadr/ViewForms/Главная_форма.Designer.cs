namespace NextGenKadr
{
    partial class MainForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForms));
            this.Поле_главного_меню = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.опрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Пользователь_Label = new System.Windows.Forms.Label();
            this.Добавить_отрудника_Button = new System.Windows.Forms.ToolStripButton();
            this.Изменить_сотрудника_Button = new System.Windows.Forms.ToolStripButton();
            this.Уволить_сотрудника_Button = new System.Windows.Forms.ToolStripButton();
            this.Просмотреть_сотрудников_Button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Создать_отчеты_Button = new System.Windows.Forms.ToolStripButton();
            this.Удалить_отчеты_Button = new System.Windows.Forms.ToolStripButton();
            this.Просмотреть_отчеты_Button = new System.Windows.Forms.ToolStripButton();
            this.Сотрудники_в_Excel_Button = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Обновить_базу_Button = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Поле_главного_меню)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Поле_главного_меню
            // 
            this.Поле_главного_меню.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Поле_главного_меню.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Поле_главного_меню.Location = new System.Drawing.Point(195, 27);
            this.Поле_главного_меню.Name = "Поле_главного_меню";
            this.Поле_главного_меню.RowHeadersWidth = 51;
            this.Поле_главного_меню.RowTemplate.Height = 24;
            this.Поле_главного_меню.Size = new System.Drawing.Size(997, 710);
            this.Поле_главного_меню.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1192, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Enter += new System.EventHandler(this.AdminForm_Load);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.опрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Спра&вка";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(221, 6);
            // 
            // опрограммеToolStripMenuItem
            // 
            this.опрограммеToolStripMenuItem.Name = "опрограммеToolStripMenuItem";
            this.опрограммеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.опрограммеToolStripMenuItem.Text = "&О программе...";
            // 
            // Пользователь_Label
            // 
            this.Пользователь_Label.AutoSize = true;
            this.Пользователь_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Пользователь_Label.Location = new System.Drawing.Point(1080, 7);
            this.Пользователь_Label.Name = "Пользователь_Label";
            this.Пользователь_Label.Size = new System.Drawing.Size(32, 17);
            this.Пользователь_Label.TabIndex = 5;
            this.Пользователь_Label.Text = "Null";
            // 
            // Добавить_отрудника_Button
            // 
            this.Добавить_отрудника_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Добавить_отрудника_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Добавить_отрудника_Button.Name = "Добавить_отрудника_Button";
            this.Добавить_отрудника_Button.Size = new System.Drawing.Size(196, 24);
            this.Добавить_отрудника_Button.Text = "Добавить сотрудника";
            this.Добавить_отрудника_Button.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // Изменить_сотрудника_Button
            // 
            this.Изменить_сотрудника_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Изменить_сотрудника_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Изменить_сотрудника_Button.Name = "Изменить_сотрудника_Button";
            this.Изменить_сотрудника_Button.Size = new System.Drawing.Size(215, 24);
            this.Изменить_сотрудника_Button.Text = "Изменить сотрудника";
            this.Изменить_сотрудника_Button.Click += new System.EventHandler(this.Update_Click);
            // 
            // Уволить_сотрудника_Button
            // 
            this.Уволить_сотрудника_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Уволить_сотрудника_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Уволить_сотрудника_Button.Name = "Уволить_сотрудника_Button";
            this.Уволить_сотрудника_Button.Size = new System.Drawing.Size(215, 24);
            this.Уволить_сотрудника_Button.Text = "Уволить сотрудника";
            this.Уволить_сотрудника_Button.Click += new System.EventHandler(this.DeletePerson_Click);
            // 
            // Просмотреть_сотрудников_Button
            // 
            this.Просмотреть_сотрудников_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Просмотреть_сотрудников_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Просмотреть_сотрудников_Button.Name = "Просмотреть_сотрудников_Button";
            this.Просмотреть_сотрудников_Button.Size = new System.Drawing.Size(215, 24);
            this.Просмотреть_сотрудников_Button.Text = "Просмотреть сотрудников";
            this.Просмотреть_сотрудников_Button.Click += new System.EventHandler(this.ViewPersonStrip_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            // 
            // Создать_отчеты_Button
            // 
            this.Создать_отчеты_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Создать_отчеты_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Создать_отчеты_Button.Name = "Создать_отчеты_Button";
            this.Создать_отчеты_Button.Size = new System.Drawing.Size(215, 24);
            this.Создать_отчеты_Button.Text = "Создать отчеты";
            this.Создать_отчеты_Button.Click += new System.EventHandler(this.Reports_Click);
            // 
            // Удалить_отчеты_Button
            // 
            this.Удалить_отчеты_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Удалить_отчеты_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Удалить_отчеты_Button.Name = "Удалить_отчеты_Button";
            this.Удалить_отчеты_Button.Size = new System.Drawing.Size(215, 24);
            this.Удалить_отчеты_Button.Text = "Удалить отчеты";
            this.Удалить_отчеты_Button.Click += new System.EventHandler(this.DeleteReports_Click);
            // 
            // Просмотреть_отчеты_Button
            // 
            this.Просмотреть_отчеты_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Просмотреть_отчеты_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Просмотреть_отчеты_Button.Name = "Просмотреть_отчеты_Button";
            this.Просмотреть_отчеты_Button.Size = new System.Drawing.Size(215, 24);
            this.Просмотреть_отчеты_Button.Text = "Просмотреть отчеты";
            this.Просмотреть_отчеты_Button.Click += new System.EventHandler(this.ViewReports_Click);
            // 
            // Сотрудники_в_Excel_Button
            // 
            this.Сотрудники_в_Excel_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Сотрудники_в_Excel_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Сотрудники_в_Excel_Button.Name = "Сотрудники_в_Excel_Button";
            this.Сотрудники_в_Excel_Button.Size = new System.Drawing.Size(215, 24);
            this.Сотрудники_в_Excel_Button.Text = "Сотрудники в Excel";
            this.Сотрудники_в_Excel_Button.Click += new System.EventHandler(this.Export_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Добавить_отрудника_Button,
            this.Изменить_сотрудника_Button,
            this.Уволить_сотрудника_Button,
            this.Просмотреть_сотрудников_Button,
            this.Сотрудники_в_Excel_Button,
            this.toolStripSeparator1,
            this.Создать_отчеты_Button,
            this.Удалить_отчеты_Button,
            this.Просмотреть_отчеты_Button,
            this.Обновить_базу_Button});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(199, 710);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            // 
            // Обновить_базу_Button
            // 
            this.Обновить_базу_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Обновить_базу_Button.Image = ((System.Drawing.Image)(resources.GetObject("Обновить_базу_Button.Image")));
            this.Обновить_базу_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Обновить_базу_Button.Name = "Обновить_базу_Button";
            this.Обновить_базу_Button.Size = new System.Drawing.Size(196, 24);
            this.Обновить_базу_Button.Text = "Обновить базу";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1159, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Exit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(946, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Пользователь";
            // 
            // MainForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 738);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Поле_главного_меню);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Пользователь_Label);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForms";
            this.Text = "Кадровый помошник";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForms_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Поле_главного_меню)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Поле_главного_меню;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem опрограммеToolStripMenuItem;
        private System.Windows.Forms.Label Пользователь_Label;
        private System.Windows.Forms.ToolStripButton Добавить_отрудника_Button;
        private System.Windows.Forms.ToolStripButton Изменить_сотрудника_Button;
        private System.Windows.Forms.ToolStripButton Уволить_сотрудника_Button;
        private System.Windows.Forms.ToolStripButton Просмотреть_сотрудников_Button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Создать_отчеты_Button;
        private System.Windows.Forms.ToolStripButton Удалить_отчеты_Button;
        private System.Windows.Forms.ToolStripButton Просмотреть_отчеты_Button;
        private System.Windows.Forms.ToolStripButton Сотрудники_в_Excel_Button;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton Обновить_базу_Button;
    }
}