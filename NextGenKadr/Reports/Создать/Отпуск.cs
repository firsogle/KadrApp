﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Word = Microsoft.Office.Interop.Word;

namespace NextGenKadr
{
    public partial class Otp : Form
    {
        string key = string.Empty;
        public Otp(string id = "")
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            key = id;
            Номер_приказа_Box.Text = "0";
            Имя_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT Имя FROM Сотрудники WHERE [Табельный номер] = {id}");
            Фамилия_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT Фамилия FROM Сотрудники WHERE [Табельный номер] = {id}");
            Отчество_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT Отчество FROM Сотрудники WHERE [Табельный номер] = {id}");
            Табельный_номер_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Табельный номер] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
           connection.Внести_cведения_об_отпусках(Табельный_номер_Box.Text, Номер_приказа_Box.Text, Дата_приказа_Box.Text, От_Picker.Text, До_Picker.Text);


            var wordApp = new Word.Application();
            var WordDoc = wordApp.Documents.Open(Path.Combine(System.Windows.Forms.Application.StartupPath, "Отпуск.docx"));

            ReplaceWordStub("{Surname}", Фамилия_Box.Text, WordDoc);
            ReplaceWordStub("{Name}", Имя_Box.Text, WordDoc);
            ReplaceWordStub("{Patronymic}", Отчество_Box.Text, WordDoc);
            ReplaceWordStub("{Surname2}", Фамилия_Box.Text, WordDoc);
            ReplaceWordStub("{Name2}", Имя_Box.Text, WordDoc);
            ReplaceWordStub("{Patronymic2}", Отчество_Box.Text, WordDoc);
            ReplaceWordStub("{DateOtp}", Дата_приказа_Box.Text, WordDoc);
            ReplaceWordStub("{NumberOtp}", Номер_приказа_Box.Text, WordDoc);
            ReplaceWordStub("{Otp1}", От_Picker.Text, WordDoc);
            ReplaceWordStub("{Otp2}", До_Picker.Text, WordDoc);

            var name = DateTime.Now.ToShortDateString() + ".docx";
            wordApp.ActiveDocument.SaveAs(FileName: name);
            wordApp.Visible = true;
        }
        public static void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);

        }
        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Номер_Enter(object sender, EventArgs e)
        {
            Номер_приказа_Box.Text = "";
        }

        private void Номер_Leave(object sender, EventArgs e)
        {
            if (Номер_приказа_Box.Text == "")
            {
                Номер_приказа_Box.Text = "0";
            }
        }
    }
}
