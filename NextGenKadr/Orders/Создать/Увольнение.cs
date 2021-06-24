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
    public partial class ListDelete : Form
    {
        string key = string.Empty;

        public ListDelete(string id = "")
        {
            InitializeComponent();
            key = id;
            this.StartPosition = FormStartPosition.CenterScreen;
            Имя_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT Имя FROM [Сведения об уволенных] WHERE [Id увольнения] = {id}");
            Фамилия_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT Фамилия FROM [Сведения об уволенных] WHERE [Id увольнения] = {id}");
            Отчество_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT Отчество FROM [Сведения об уволенных] WHERE [Id увольнения] = {id}");
            Должность_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Должность] FROM [Сведения об уволенных] where [Id увольнения]= {id}");
            Подразделение_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Подразделение] FROM [Сведения об уволенных] WHERE [Id увольнения] = {id}");
            Табельный_номер_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Табельный номер] FROM [Сведения об уволенных] WHERE [Id увольнения] = {id}");

            Номер_документаBox.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Номер документа] FROM [Сведения об уволенных] WHERE [Id увольнения] = {id}");
            Дата_приказаPicker1Picker1.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Дата приказа] FROM [Сведения об уволенных] WHERE [Id увольнения] = {id}");
            Дата_договораPicker2.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Дата заключения договора] FROM [Сведения об уволенных] WHERE [Id увольнения] = {id}");
            Номер_договора_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Номер договора] FROM [Сведения об уволенных] WHERE [Id увольнения] = {id}");
            Дата_увольнения_Picker.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Дата увольнения] FROM [Сведения об уволенных] WHERE [Id увольнения] = {id}");

            Причина_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Основание] FROM [Сведения об уволенных] WHERE [Табельный номер] = {id}");
            Основание_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Номер основания] FROM [Сведения об уволенных] WHERE [Табельный номер] = {id}");
            Дата_основания_Picker.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Дата основания] FROM [Сведения об уволенных] WHERE [Табельный номер] = {id}");

        }

        private void Создать_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            var WordDoc = wordApp.Documents.Open(Path.Combine(System.Windows.Forms.Application.StartupPath, "Т-8.docx"));

            int Day1 = DateTime.Parse(Дата_договораPicker2.Text).Day;
            int month1 = DateTime.Parse(Дата_договораPicker2.Text).Month;
            string Year1 = DateTime.Parse(Дата_договораPicker2.Text).ToString("yy");
            int Day2 = DateTime.Parse(Дата_увольнения_Picker.Text).Day;
            int month2 = DateTime.Parse(Дата_увольнения_Picker.Text).Month;
            string Year2 = DateTime.Parse(Дата_увольнения_Picker.Text).ToString("yy");

            ReplaceWordStub("[Номер документа]", Номер_документаBox.Text, WordDoc);
            ReplaceWordStub("[Дата приказа]", Дата_приказаPicker1Picker1.Text, WordDoc);
            ReplaceWordStub("[ДДдог]", Convert.ToString(Day1), WordDoc);
            ReplaceWordStub("[ММдог]", Convert.ToString(month1), WordDoc);
            ReplaceWordStub("[ГГдог]", Convert.ToString(Year1), WordDoc);
            ReplaceWordStub("[Номер Договора]", Номер_договора_Box.Text, WordDoc);
            ReplaceWordStub("[ДДув]", Convert.ToString(Day2), WordDoc);
            ReplaceWordStub("[ММув]", Convert.ToString(month2), WordDoc);
            ReplaceWordStub("[ГГув]", Convert.ToString(Year2), WordDoc);
            ReplaceWordStub("[Табельный номер]", Табельный_номер_Box.Text, WordDoc);
            ReplaceWordStub("[Фамилия]", Фамилия_Box.Text, WordDoc);
            ReplaceWordStub("[Имя] ", Имя_Box.Text, WordDoc);
            ReplaceWordStub("[Отчество]", Отчество_Box.Text, WordDoc);
            ReplaceWordStub("[Подразделение]", Подразделение_Box.Text, WordDoc);
            ReplaceWordStub("[Должность]", Должность_Box.Text, WordDoc);
            ReplaceWordStub("[Основание]", Причина_Box.Text, WordDoc);
            ReplaceWordStub("[Номер основания]", Основание_Box.Text, WordDoc);
            ReplaceWordStub("[Дата основания]", Дата_основания_Picker.Text, WordDoc);



            connection.Запись_в_журнал(Фамилия_Box.Text, "Сотрудник уволен", "Приказы", Data.UserAuthorization);

            var name = DateTime.Now.ToShortDateString() + ".docx";
            try
            {
                wordApp.ActiveDocument.SaveAs(FileName: name);
                wordApp.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Закройте прошлый отчет");
                throw;
            }
        }

        private static void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);

        }

        private void Закрыть_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}