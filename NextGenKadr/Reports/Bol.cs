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
    public partial class Bol : Form
    {
        string key = string.Empty;
        public Bol(string id = "")
        {
            InitializeComponent();
            key = id;
            Имя_Box.Text = connection.ReadDB($"SELECT Имя FROM Сотрудники WHERE [Табельный номер] = {id}");
            Фамилия_Box.Text = connection.ReadDB($"SELECT Фамилия FROM Сотрудники WHERE [Табельный номер] = {id}");
            Отчество_Box.Text = connection.ReadDB($"SELECT Отчество FROM Сотрудники WHERE [Табельный номер] = {id}");
            Табельный_номер_Box.Text = connection.ReadDB($"SELECT [Табельный номер] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
        }

        private void Report_Click(object sender, EventArgs e)
        {
            try
            {
               connection.Внести_cведения_о_больничных(Табельный_номер_Box.Text, Номер_листа_нетрудоспособности_Box.Text, От_Picker.Text, До_Picker.Text, Номер_приказа_Box.Text, Дата_приказа_Box.Text, Дата_документа_Box.Text);
            }
            catch (Exception sit1)
            {
                MessageBox.Show(sit1.Message);
                return;
            }

            var wordApp = new Word.Application();
            var WordDoc = wordApp.Documents.Open(Path.Combine(System.Windows.Forms.Application.StartupPath, "Больничный.docx"));

            ReplaceWordStub("{Surname}", Фамилия_Box.Text, WordDoc);
            ReplaceWordStub("{Name}", Имя_Box.Text, WordDoc);
            ReplaceWordStub("{Patronymic}", Отчество_Box.Text, WordDoc);
            ReplaceWordStub("{Surname2}", Фамилия_Box.Text, WordDoc);
            ReplaceWordStub("{Name2}", Имя_Box.Text, WordDoc);
            ReplaceWordStub("{Patronymic2}", Отчество_Box.Text, WordDoc);

            ReplaceWordStub("{Number_ID}", Табельный_номер_Box.Text, WordDoc);

            ReplaceWordStub("{NumberOtp}", Номер_приказа_Box.Text, WordDoc);
            ReplaceWordStub("{DateOtp}", Дата_приказа_Box.Text, WordDoc);

            ReplaceWordStub("{NumberDoc}", Номер_листа_нетрудоспособности_Box.Text, WordDoc);
            ReplaceWordStub("{DateDoс}", Дата_документа_Box.Text, WordDoc);

            ReplaceWordStub("{Bol1}", От_Picker.Text, WordDoc);
            ReplaceWordStub("{Bol2}", До_Picker.Text, WordDoc);

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
        public static void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);

        }
        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}