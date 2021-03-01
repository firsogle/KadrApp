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
            Имя_Box.Text =connection.Получить_сведения_из_базы_данных($"SELECT Имя FROM [Сведения об уволенных] WHERE [Табельный номер] = {id}");
            Фамилия_Box.Text =connection.Получить_сведения_из_базы_данных($"SELECT Фамилия FROM [Сведения об уволенных] WHERE [Табельный номер] = {id}");
            Отчество_Box.Text =connection.Получить_сведения_из_базы_данных($"SELECT Отчество FROM [Сведения об уволенных] WHERE [Табельный номер] = {id}");
            Причина_Box.Text =connection.Получить_сведения_из_базы_данных($"SELECT [Причина] FROM [Сведения об уволенных] WHERE [Табельный номер] = {id}");
            Табельный_номер_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Табельный номер] FROM [Сведения об уволенных] WHERE [Табельный номер] = {id}");
            Дата_увольнения_Picker.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Дата увольнения] FROM [Сведения об уволенных] WHERE [Табельный номер] = {id}");

        }

        private void Создать_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            var WordDoc = wordApp.Documents.Open(Path.Combine(System.Windows.Forms.Application.StartupPath, "Командировка.docx"));

            ReplaceWordStub("{Фамилия}", Фамилия_Box.Text, WordDoc);
            ReplaceWordStub("{Имя}", Имя_Box.Text, WordDoc);
            ReplaceWordStub("{Отчество}", Отчество_Box.Text, WordDoc);
            ReplaceWordStub("{Фамилия2}", Фамилия_Box.Text, WordDoc);
            ReplaceWordStub("{Имя2}", Имя_Box.Text, WordDoc);
            ReplaceWordStub("{Отчество2}", Отчество_Box.Text, WordDoc);

            ReplaceWordStub("{Табельный_номер}", Табельный_номер_Box.Text, WordDoc);
            ReplaceWordStub("{Дата_увольнения}", Дата_увольнения_Picker.Text, WordDoc);
            ReplaceWordStub("{Причина}", Причина_Box.Text, WordDoc);

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