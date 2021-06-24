namespace NextGenKadr
{
    partial class Otp
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
            this.Создать_отчет_Button = new System.Windows.Forms.Button();
            this.Закрыть_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Должность_Box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Фамилия_Box = new System.Windows.Forms.TextBox();
            this.Подразделение_Box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Имя_Box = new System.Windows.Forms.TextBox();
            this.Отчество_Box = new System.Windows.Forms.TextBox();
            this.Табельный_номер_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Переод_работы__Box = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.Номер_документаBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Дата_приказаBOX = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.Переод_работы_по_Box = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Тип_отпуска_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Конец_Б = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.Дней_Б = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Начало_Б = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Конец_А = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.Дней_А = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Начало_А = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Конец_В = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.Дней_В = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Начало_В = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Создать_отчет_Button
            // 
            this.Создать_отчет_Button.Location = new System.Drawing.Point(355, 632);
            this.Создать_отчет_Button.Name = "Создать_отчет_Button";
            this.Создать_отчет_Button.Size = new System.Drawing.Size(139, 58);
            this.Создать_отчет_Button.TabIndex = 0;
            this.Создать_отчет_Button.Text = "Сформировать приказ";
            this.Создать_отчет_Button.UseVisualStyleBackColor = true;
            this.Создать_отчет_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Закрыть_Button
            // 
            this.Закрыть_Button.Location = new System.Drawing.Point(549, 632);
            this.Закрыть_Button.Name = "Закрыть_Button";
            this.Закрыть_Button.Size = new System.Drawing.Size(139, 58);
            this.Закрыть_Button.TabIndex = 54;
            this.Закрыть_Button.Text = "Закрыть";
            this.Закрыть_Button.UseVisualStyleBackColor = true;
            this.Закрыть_Button.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Должность_Box);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Фамилия_Box);
            this.groupBox1.Controls.Add(this.Подразделение_Box);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label62);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Имя_Box);
            this.groupBox1.Controls.Add(this.Отчество_Box);
            this.groupBox1.Controls.Add(this.Табельный_номер_Box);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(44, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 273);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сведения сотрудника";
            // 
            // Должность_Box
            // 
            this.Должность_Box.Location = new System.Drawing.Point(146, 192);
            this.Должность_Box.Name = "Должность_Box";
            this.Должность_Box.ReadOnly = true;
            this.Должность_Box.Size = new System.Drawing.Size(184, 22);
            this.Должность_Box.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 82;
            this.label9.Text = "Подразделение";
            // 
            // Фамилия_Box
            // 
            this.Фамилия_Box.Location = new System.Drawing.Point(146, 61);
            this.Фамилия_Box.Name = "Фамилия_Box";
            this.Фамилия_Box.ReadOnly = true;
            this.Фамилия_Box.Size = new System.Drawing.Size(184, 22);
            this.Фамилия_Box.TabIndex = 10;
            // 
            // Подразделение_Box
            // 
            this.Подразделение_Box.Location = new System.Drawing.Point(146, 224);
            this.Подразделение_Box.Name = "Подразделение_Box";
            this.Подразделение_Box.ReadOnly = true;
            this.Подразделение_Box.Size = new System.Drawing.Size(184, 22);
            this.Подразделение_Box.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Имя";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(21, 195);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(81, 17);
            this.label62.TabIndex = 66;
            this.label62.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Отчество";
            // 
            // Имя_Box
            // 
            this.Имя_Box.Location = new System.Drawing.Point(146, 96);
            this.Имя_Box.Name = "Имя_Box";
            this.Имя_Box.ReadOnly = true;
            this.Имя_Box.Size = new System.Drawing.Size(184, 22);
            this.Имя_Box.TabIndex = 12;
            // 
            // Отчество_Box
            // 
            this.Отчество_Box.Location = new System.Drawing.Point(146, 131);
            this.Отчество_Box.Name = "Отчество_Box";
            this.Отчество_Box.ReadOnly = true;
            this.Отчество_Box.Size = new System.Drawing.Size(184, 22);
            this.Отчество_Box.TabIndex = 14;
            // 
            // Табельный_номер_Box
            // 
            this.Табельный_номер_Box.Location = new System.Drawing.Point(146, 164);
            this.Табельный_номер_Box.Name = "Табельный_номер_Box";
            this.Табельный_номер_Box.ReadOnly = true;
            this.Табельный_номер_Box.Size = new System.Drawing.Size(184, 22);
            this.Табельный_номер_Box.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "Табельный номер";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Тип_отпуска_Box);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Переод_работы__Box);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.Номер_документаBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Дата_приказаBOX);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Переод_работы_по_Box);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(417, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 273);
            this.groupBox2.TabIndex = 96;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Документы";
            // 
            // Переод_работы__Box
            // 
            this.Переод_работы__Box.CustomFormat = "yyyy.MM.dd";
            this.Переод_работы__Box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Переод_работы__Box.Location = new System.Drawing.Point(164, 136);
            this.Переод_работы__Box.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.Переод_работы__Box.Name = "Переод_работы__Box";
            this.Переод_работы__Box.Size = new System.Drawing.Size(167, 22);
            this.Переод_работы__Box.TabIndex = 94;
            this.Переод_работы__Box.Value = new System.DateTime(2020, 6, 23, 18, 40, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 17);
            this.label12.TabIndex = 93;
            this.label12.Text = "Переод работы от";
            // 
            // Номер_документаBox
            // 
            this.Номер_документаBox.Location = new System.Drawing.Point(164, 64);
            this.Номер_документаBox.Name = "Номер_документаBox";
            this.Номер_документаBox.Size = new System.Drawing.Size(167, 22);
            this.Номер_документаBox.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 78;
            this.label7.Text = "Номер документа";
            // 
            // Дата_приказаBOX
            // 
            this.Дата_приказаBOX.CustomFormat = "yyyy.MM.dd";
            this.Дата_приказаBOX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Дата_приказаBOX.Location = new System.Drawing.Point(164, 99);
            this.Дата_приказаBOX.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.Дата_приказаBOX.Name = "Дата_приказаBOX";
            this.Дата_приказаBOX.Size = new System.Drawing.Size(167, 22);
            this.Дата_приказаBOX.TabIndex = 83;
            this.Дата_приказаBOX.Value = new System.DateTime(2020, 6, 23, 18, 40, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 80;
            this.label8.Text = "Дата приказа";
            // 
            // Переод_работы_по_Box
            // 
            this.Переод_работы_по_Box.CustomFormat = "yyyy.MM.dd";
            this.Переод_работы_по_Box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Переод_работы_по_Box.Location = new System.Drawing.Point(162, 169);
            this.Переод_работы_по_Box.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.Переод_работы_по_Box.Name = "Переод_работы_по_Box";
            this.Переод_работы_по_Box.Size = new System.Drawing.Size(167, 22);
            this.Переод_работы_по_Box.TabIndex = 76;
            this.Переод_работы_по_Box.Value = new System.DateTime(2020, 6, 23, 18, 40, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Переод работы по";
            // 
            // Тип_отпуска_Box
            // 
            this.Тип_отпуска_Box.Location = new System.Drawing.Point(164, 209);
            this.Тип_отпуска_Box.Name = "Тип_отпуска_Box";
            this.Тип_отпуска_Box.Size = new System.Drawing.Size(167, 22);
            this.Тип_отпуска_Box.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 96;
            this.label1.Text = "Тип отпуска";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Конец_Б);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.Дней_Б);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.Начало_Б);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(417, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 199);
            this.groupBox3.TabIndex = 97;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Отпуск за свой счет";
            // 
            // Конец_Б
            // 
            this.Конец_Б.CustomFormat = "yyyy.MM.dd";
            this.Конец_Б.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Конец_Б.Location = new System.Drawing.Point(164, 137);
            this.Конец_Б.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.Конец_Б.Name = "Конец_Б";
            this.Конец_Б.Size = new System.Drawing.Size(167, 22);
            this.Конец_Б.TabIndex = 94;
            this.Конец_Б.Value = new System.DateTime(2020, 6, 23, 18, 40, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 17);
            this.label11.TabIndex = 93;
            this.label11.Text = "Начало отпуска";
            // 
            // Дней_Б
            // 
            this.Дней_Б.Location = new System.Drawing.Point(164, 64);
            this.Дней_Б.Name = "Дней_Б";
            this.Дней_Б.Size = new System.Drawing.Size(167, 22);
            this.Дней_Б.TabIndex = 77;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 17);
            this.label13.TabIndex = 78;
            this.label13.Text = "Количество дней";
            // 
            // Начало_Б
            // 
            this.Начало_Б.CustomFormat = "yyyy.MM.dd";
            this.Начало_Б.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Начало_Б.Location = new System.Drawing.Point(164, 99);
            this.Начало_Б.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.Начало_Б.Name = "Начало_Б";
            this.Начало_Б.Size = new System.Drawing.Size(167, 22);
            this.Начало_Б.TabIndex = 83;
            this.Начало_Б.Value = new System.DateTime(2020, 6, 23, 18, 40, 0, 0);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 137);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 17);
            this.label15.TabIndex = 4;
            this.label15.Text = "Окончание отпуска";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Конец_А);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.Дней_А);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.Начало_А);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(44, 324);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(352, 199);
            this.groupBox4.TabIndex = 98;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Оплачиваемый";
            // 
            // Конец_А
            // 
            this.Конец_А.CustomFormat = "yyyy.MM.dd";
            this.Конец_А.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Конец_А.Location = new System.Drawing.Point(164, 137);
            this.Конец_А.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.Конец_А.Name = "Конец_А";
            this.Конец_А.Size = new System.Drawing.Size(167, 22);
            this.Конец_А.TabIndex = 94;
            this.Конец_А.Value = new System.DateTime(2020, 6, 23, 18, 40, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 17);
            this.label10.TabIndex = 93;
            this.label10.Text = "Начало отпуска";
            // 
            // Дней_А
            // 
            this.Дней_А.Location = new System.Drawing.Point(164, 64);
            this.Дней_А.Name = "Дней_А";
            this.Дней_А.Size = new System.Drawing.Size(167, 22);
            this.Дней_А.TabIndex = 77;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 17);
            this.label14.TabIndex = 78;
            this.label14.Text = "Количество дней";
            // 
            // Начало_А
            // 
            this.Начало_А.CustomFormat = "yyyy.MM.dd";
            this.Начало_А.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Начало_А.Location = new System.Drawing.Point(164, 99);
            this.Начало_А.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.Начало_А.Name = "Начало_А";
            this.Начало_А.Size = new System.Drawing.Size(167, 22);
            this.Начало_А.TabIndex = 83;
            this.Начало_А.Value = new System.DateTime(2020, 6, 23, 18, 40, 0, 0);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 137);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(138, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "Окончание отпуска";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Конец_В);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.Дней_В);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.Начало_В);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Location = new System.Drawing.Point(786, 324);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(347, 199);
            this.groupBox5.TabIndex = 98;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Всего дней";
            // 
            // Конец_В
            // 
            this.Конец_В.CustomFormat = "yyyy.MM.dd";
            this.Конец_В.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Конец_В.Location = new System.Drawing.Point(164, 137);
            this.Конец_В.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.Конец_В.Name = "Конец_В";
            this.Конец_В.Size = new System.Drawing.Size(167, 22);
            this.Конец_В.TabIndex = 94;
            this.Конец_В.Value = new System.DateTime(2020, 6, 23, 18, 40, 0, 0);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 17);
            this.label17.TabIndex = 93;
            this.label17.Text = "Начало отпуска";
            // 
            // Дней_В
            // 
            this.Дней_В.Location = new System.Drawing.Point(164, 64);
            this.Дней_В.Name = "Дней_В";
            this.Дней_В.Size = new System.Drawing.Size(167, 22);
            this.Дней_В.TabIndex = 77;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 67);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(122, 17);
            this.label18.TabIndex = 78;
            this.label18.Text = "Количество дней";
            // 
            // Начало_В
            // 
            this.Начало_В.CustomFormat = "yyyy.MM.dd";
            this.Начало_В.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Начало_В.Location = new System.Drawing.Point(164, 99);
            this.Начало_В.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.Начало_В.Name = "Начало_В";
            this.Начало_В.Size = new System.Drawing.Size(167, 22);
            this.Начало_В.TabIndex = 83;
            this.Начало_В.Value = new System.DateTime(2020, 6, 23, 18, 40, 0, 0);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 137);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(138, 17);
            this.label19.TabIndex = 4;
            this.label19.Text = "Окончание отпуска";
            // 
            // Otp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1154, 741);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Закрыть_Button);
            this.Controls.Add(this.Создать_отчет_Button);
            this.Name = "Otp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать приказ отпуска сотрудника";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Создать_отчет_Button;
        private System.Windows.Forms.Button Закрыть_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Должность_Box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Фамилия_Box;
        private System.Windows.Forms.TextBox Подразделение_Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Имя_Box;
        private System.Windows.Forms.TextBox Отчество_Box;
        private System.Windows.Forms.TextBox Табельный_номер_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Тип_отпуска_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Переод_работы__Box;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Номер_документаBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Дата_приказаBOX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker Переод_работы_по_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker Конец_Б;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Дней_Б;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker Начало_Б;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker Конец_А;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Дней_А;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker Начало_А;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker Конец_В;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Дней_В;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker Начало_В;
        private System.Windows.Forms.Label label19;
    }
}