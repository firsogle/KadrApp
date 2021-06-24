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
    public partial class Otp : Form
    {
        string key = string.Empty;
        public Otp(string id = "")
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

        private void button1_Click(object sender, EventArgs e)
        {
          
           connection.Внести_cведения_об_отпусках(Табельный_номер_Box.Text, Номер_документаBox.Text, Дата_приказаBOX.Text, Переод_работы__Box.Text, Переод_работы_по_Box.Text, Тип_отпуска_Box.Text, Начало_А.Text, Конец_А.Text, Начало_Б.Text, Конец_Б.Text, Начало_В.Text, Конец_В.Text, Дней_А.Text, Дней_Б.Text, Дней_В.Text);

            int Day1 = DateTime.Parse(Переод_работы__Box.Text).Day;
            int month1 = DateTime.Parse(Переод_работы__Box.Text).Month;
            string Year1 = DateTime.Parse(Переод_работы__Box.Text).ToString("yy");

            int Day2 = DateTime.Parse(Переод_работы_по_Box.Text).Day;
            int month2 = DateTime.Parse(Переод_работы_по_Box.Text).Month;
            string Year2 = DateTime.Parse(Переод_работы_по_Box.Text).ToString("yy");

            int Day3 = DateTime.Parse(Начало_А.Text).Day;
            int month3 = DateTime.Parse(Начало_А.Text).Month;
            string Year3 = DateTime.Parse(Начало_А.Text).ToString("yy");

            int Day4 = DateTime.Parse(Конец_А.Text).Day;
            int month4 = DateTime.Parse(Конец_А.Text).Month;
            string Year4 = DateTime.Parse(Конец_А.Text).ToString("yy");

            int Day5 = DateTime.Parse(Начало_Б.Text).Day;
            int month5 = DateTime.Parse(Начало_Б.Text).Month;
            string Year5 = DateTime.Parse(Начало_Б.Text).ToString("yy");

            int Day6 = DateTime.Parse(Конец_Б.Text).Day;
            int month6 = DateTime.Parse(Конец_Б.Text).Month;
            string Year6 = DateTime.Parse(Конец_Б.Text).ToString("yy");

            int Day7 = DateTime.Parse(Начало_В.Text).Day;
            int month7 = DateTime.Parse(Начало_В.Text).Month;
            string Year7 = DateTime.Parse(Начало_В.Text).ToString("yy");

            int Day8 = DateTime.Parse(Конец_В.Text).Day;
            int month8 = DateTime.Parse(Конец_В.Text).Month;
            string Year8 = DateTime.Parse(Конец_В.Text).ToString("yy");

            var wordApp = new Word.Application();
            var WordDoc = wordApp.Documents.Open(Path.Combine(System.Windows.Forms.Application.StartupPath, "Т-6.docx"));

            ReplaceWordStub("[Номер документа]", Номер_документаBox.Text, WordDoc);
            ReplaceWordStub("[Дата приказа]", Дата_приказаBOX.Text, WordDoc);
            ReplaceWordStub("[Фамилия]", Фамилия_Box.Text, WordDoc);
            ReplaceWordStub("[Имя]", Имя_Box.Text, WordDoc);
            ReplaceWordStub("[Отчество]", Отчество_Box.Text, WordDoc);
            ReplaceWordStub("[Должность]", Должность_Box.Text, WordDoc);
            ReplaceWordStub("[Подразделение]", Подразделение_Box.Text, WordDoc);
            ReplaceWordStub("[Табельный номер]", Табельный_номер_Box.Text, WordDoc);

            ReplaceWordStub("[ДДпер]", Day1.ToString(), WordDoc);
            ReplaceWordStub("[ммпер]", month1.ToString(), WordDoc);
            ReplaceWordStub("[ггпер]", Year1, WordDoc);

            ReplaceWordStub("[ДДпердо]", Day2.ToString(), WordDoc);
            ReplaceWordStub("[ммпердо]", month2.ToString(), WordDoc);
            ReplaceWordStub("[ггпердо]", Year2, WordDoc);

            ReplaceWordStub("[ДнейА]", Дней_А.Text, WordDoc);
            ReplaceWordStub("[ДнейБ]", Дней_Б.Text, WordDoc);
            ReplaceWordStub("[ДнейВ]", Дней_В.Text, WordDoc);

            ReplaceWordStub("[ДДотА]", Day3.ToString(), WordDoc);
            ReplaceWordStub("[ММотА]", month3.ToString(), WordDoc);
            ReplaceWordStub("[ГГотА]", Year3, WordDoc);

            ReplaceWordStub("[ДДдоА]", Day4.ToString(), WordDoc);
            ReplaceWordStub("[ММдоА]", month4.ToString(), WordDoc);
            ReplaceWordStub("[ГГдоА]", Year4, WordDoc);

            ReplaceWordStub("[Тип отпуска]", Тип_отпуска_Box.Text, WordDoc);

            ReplaceWordStub("[ДДотБ]", Day5.ToString(), WordDoc);
            ReplaceWordStub("[ММотБ]", month5.ToString(), WordDoc);
            ReplaceWordStub("[ГГотБ]", Year5, WordDoc);

            ReplaceWordStub("[ДДдоБ]", Day6.ToString(), WordDoc);
            ReplaceWordStub("[ММдоБ]", month6.ToString(), WordDoc);
            ReplaceWordStub("[ГГдоБ]", Year6, WordDoc);

            ReplaceWordStub("[ДДотВ]", Day7.ToString(), WordDoc);
            ReplaceWordStub("[ММотВ]", month7.ToString(), WordDoc);
            ReplaceWordStub("[ГГотВ]", Year7, WordDoc);

            ReplaceWordStub("[ДДдоВ]", Day8.ToString(), WordDoc);
            ReplaceWordStub("[ММдоВ]", month8.ToString(), WordDoc);
            ReplaceWordStub("[ГГдоВ]", Year8, WordDoc);



            var name = DateTime.Now.ToShortDateString() + ".docx";
            wordApp.ActiveDocument.SaveAs(FileName: name);
            wordApp.Visible = true;

            connection.Запись_в_журнал(Фамилия_Box.Text, "Создана запись отпуска", "Приказы", Data.UserAuthorization);
            MessageBox.Show("Отпуск создан!");
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
            Дней_Б.Text = "";
        }

        private void Номер_Leave(object sender, EventArgs e)
        {
            if (Дней_Б.Text == "")
            {
                Дней_Б.Text = "1";
            }
        }
    }
}
