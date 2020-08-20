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
            if (!string.IsNullOrEmpty(Surname_Box.Text = connection.ReadDB($"SELECT Фамилия FROM General WHERE ID = {key}")))
            {
                Surname_Box.Text = connection.ReadDB($"SELECT Фамилия FROM General WHERE ID = {key}");
            }
            if (!string.IsNullOrEmpty(Name_Box.Text = connection.ReadDB($"SELECT Имя FROM General WHERE ID = {key}")))
            {
                Name_Box.Text = connection.ReadDB($"SELECT Имя FROM General WHERE ID = {key}");
            }
            if (!string.IsNullOrEmpty(Patronymic_Box.Text = connection.ReadDB($"SELECT Отчество FROM General WHERE ID = {key}")))
            {
                Patronymic_Box.Text = connection.ReadDB($"SELECT Отчество FROM General WHERE ID = {key}");
            }
            if (!string.IsNullOrEmpty(Number_ID.Text = connection.ReadDB($"SELECT [Табельный номер] FROM General WHERE ID = {key}")))
            {
                Number_ID.Text = connection.ReadDB($"SELECT [Табельный номер] FROM General WHERE ID = {key}");
            }

        }

        private void Report_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Build($"INSERT INTO Bol_List (Фамилия, Имя, Отчество, [Табельный номер], [Номер приказа], [Дата приказа], [Номер документа], [Дата документа],[Начало больничного], [Конец больничного]) VALUES (N'{Surname_Box.Text}',N'{Name_Box.Text}',N'{Patronymic_Box.Text}',N'{Number_ID.Text}',N'{NumberOtp_Box.Text}',N'{DateOtp_Box.Text}',N'{NumberDoc_Box.Text}',N'{DateDoc_Box.Text}',N'{Bol1_Picker.Text}',N'{Bol2_Picker.Text}')");
            }
            catch (Exception sit1)
            {
                MessageBox.Show(sit1.Message);
                return;
            }

            var wordApp = new Word.Application();
            var WordDoc = wordApp.Documents.Open(Path.Combine(System.Windows.Forms.Application.StartupPath, "Больничный.docx"));

            ReplaceWordStub("{Surname}", Surname_Box.Text, WordDoc);
            ReplaceWordStub("{Name}", Name_Box.Text, WordDoc);
            ReplaceWordStub("{Patronymic}", Patronymic_Box.Text, WordDoc);
            ReplaceWordStub("{Surname2}", Surname_Box.Text, WordDoc);
            ReplaceWordStub("{Name2}", Name_Box.Text, WordDoc);
            ReplaceWordStub("{Patronymic2}", Patronymic_Box.Text, WordDoc);

            ReplaceWordStub("{Number_ID}", Number_ID.Text, WordDoc);

            ReplaceWordStub("{NumberOtp}", NumberOtp_Box.Text, WordDoc);
            ReplaceWordStub("{DateOtp}", DateOtp_Box.Text, WordDoc);

            ReplaceWordStub("{NumberDoc}", NumberDoc_Box.Text, WordDoc);
            ReplaceWordStub("{DateDoс}", DateDoc_Box.Text, WordDoc);

            ReplaceWordStub("{Bol1}", Bol1_Picker.Text, WordDoc);
            ReplaceWordStub("{Bol2}", Bol2_Picker.Text, WordDoc);


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
    }
}