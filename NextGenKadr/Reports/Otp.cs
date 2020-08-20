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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Build($"INSERT INTO Otp_List (Фамилия, Имя, Отчество, [Табельный номер], [Номер приказа], [Начало отпуска], [Конец отпуска], [Дата приказа]) VALUES (N'{Surname_Box.Text}',N'{Name_Box.Text}',N'{Patronymic_Box.Text}',N'{Number_ID.Text}',N'{NumberOtp_Box.Text}',N'{Otp1_Picker.Text}',N'{Otp2_Picker.Text}',N'{DateOtp_Box.Text}')");
            }
            catch (Exception sit1)
            {
                MessageBox.Show(sit1.Message);
                return;
            }

            var wordApp = new Word.Application();
            var WordDoc = wordApp.Documents.Open(Path.Combine(System.Windows.Forms.Application.StartupPath, "Отпуск.docx"));

            ReplaceWordStub("{Surname}", Surname_Box.Text, WordDoc);
            ReplaceWordStub("{Name}", Name_Box.Text, WordDoc);
            ReplaceWordStub("{Patronymic}", Patronymic_Box.Text, WordDoc);
            ReplaceWordStub("{Surname2}", Surname_Box.Text, WordDoc);
            ReplaceWordStub("{Name2}", Name_Box.Text, WordDoc);
            ReplaceWordStub("{Patronymic2}", Patronymic_Box.Text, WordDoc);
            ReplaceWordStub("{DateOtp}", DateOtp_Box.Text, WordDoc);
            ReplaceWordStub("{NumberOtp}", NumberOtp_Box.Text, WordDoc);
            ReplaceWordStub("{Otp1}", Otp1_Picker.Text, WordDoc);
            ReplaceWordStub("{Otp2}", Otp2_Picker.Text, WordDoc);

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
    }
}
