using System;
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
   public partial class Com : Form
    {
       string key = string.Empty;
        public Com(string id = "")
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            key = id;
            Имя_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT Имя FROM Сотрудники WHERE [Табельный номер] = {id}");
            Фамилия_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT Фамилия FROM Сотрудники WHERE [Табельный номер] = {id}");
            Отчество_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT Отчество FROM Сотрудники WHERE [Табельный номер] = {id}");
            Табельный_номер_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Табельный номер] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Должность_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Дожность],  where [Табельный номер]= {id}");
            Должность_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Подразделение],  where [Табельный номер]= {id}");
        }

        private void Report_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Внести_cведения_о_командировках(Номер_приказа_Box.Text, Дата_приказа_Box.Text, Табельный_номер_Box.Text, Цель_Box.Text, Место_командировки_Box.Text, ДниBox.Text, От_Picker.Text, До_Picker.Text, Финансирование_Box.Text, Задание_Box.Text, dateTimePicker1.Text);
            }
            catch (Exception sit1)
            {
                MessageBox.Show(sit1.Message);
                return;
            }
            var wordApp = new Word.Application();
            
                int Day1 = DateTime.Parse(От_Picker.Text).Day;
                int month1 = DateTime.Parse(От_Picker.Text).Month;
                string Year1 = DateTime.Parse(От_Picker.Text).ToString("yy");

                int Day2 = DateTime.Parse(До_Picker.Text).Day;
                int month2 = DateTime.Parse(До_Picker.Text).Month;
                string Year2 = DateTime.Parse(До_Picker.Text).ToString("yy");
                var WordDoc = wordApp.Documents.Open(Path.Combine(System.Windows.Forms.Application.StartupPath, "Т-9.docx"));

                ReplaceWordStub("[Номер документа]", Номер_приказа_Box.Text, WordDoc);
                ReplaceWordStub("[Дата приказа]", Дата_приказа_Box.Text, WordDoc);
                ReplaceWordStub("[Фамилия]", Фамилия_Box.Text, WordDoc);
                ReplaceWordStub("[Имя]", Имя_Box.Text, WordDoc);
                ReplaceWordStub("[Отчество]", Отчество_Box.Text, WordDoc);
                ReplaceWordStub("[Табельный номер]", Табельный_номер_Box.Text, WordDoc);
                ReplaceWordStub("[Подразделение]", Подразделение_Box.Text, WordDoc);
                ReplaceWordStub("[Должность]", Должность_Box.Text, WordDoc);
                ReplaceWordStub("[Место]", Место_командировки_Box.Text, WordDoc);
                ReplaceWordStub("[Дней]", ДниBox.Text, WordDoc);

                ReplaceWordStub("[ДДот]", Day1.ToString(), WordDoc);
                ReplaceWordStub("[ММот]", month1.ToString(), WordDoc);
                ReplaceWordStub("[ГГот]", Year1, WordDoc);

                ReplaceWordStub("[ДДдо]", Day2.ToString(), WordDoc);
                ReplaceWordStub("[ММдо]", month2.ToString(), WordDoc);
                ReplaceWordStub("[ГГдо]", Year2, WordDoc);

                ReplaceWordStub("[Цель]", Цель_Box.Text, WordDoc);
                ReplaceWordStub("[Источник финансов]", Финансирование_Box.Text, WordDoc);
                ReplaceWordStub("[Задание]", Задание_Box.Text, WordDoc);
                ReplaceWordStub("[Дата задания]", dateTimePicker1.Text, WordDoc);



            var name = DateTime.Now.ToShortDateString() + ".docx";
            connection.Запись_в_журнал(Фамилия_Box.Text, "Создана запись командировки", "Приказы", Data.UserAuthorization);
            try
            {
                wordApp.ActiveDocument.SaveAs(FileName: name);
                wordApp.Visible = true;
            }
            catch (Exception )
            {
                MessageBox.Show("Закройте прошлый отчет");
            }
        }
        private static void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);

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

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Закрыть_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}