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
            this.StartPosition = FormStartPosition.CenterScreen;
            key = id;
            Номер_листа_нетрудоспособности_Box.Text = "0";
           
            Имя_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT Имя FROM Сотрудники WHERE [Табельный номер] = {id}");
            Фамилия_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT Фамилия FROM Сотрудники WHERE [Табельный номер] = {id}");
            Отчество_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT Отчество FROM Сотрудники WHERE [Табельный номер] = {id}");
            Табельный.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Табельный номер] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
        }

        private void Report_Click(object sender, EventArgs e)
        {
            
               connection.Внести_cведения_о_больничных(Номер_листа_нетрудоспособности_Box.Text, Название_организации_выдавшей_листокBox.Text, Табельный.Text, От_Picker.Text, До_Picker.Text, Код_причины.Text, Дата_документа_Box.Text);
               connection.Запись_в_журнал(Фамилия_Box.Text, "Создана запись больничного", "Приказы", Data.UserAuthorization);
               MessageBox.Show("Больничный создан!");


        }
        private static void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
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
        private void Закрыть_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Номер_листа_нетрудоспособности_Box_Enter(object sender, EventArgs e)
        {
            Номер_листа_нетрудоспособности_Box.Text = "";
        }

        private void Номер_листа_нетрудоспособности_Box_Leave(object sender, EventArgs e)
        {
            if (Номер_листа_нетрудоспособности_Box.Text == "")
            {
                Номер_листа_нетрудоспособности_Box.Text = "0";
            }
        }

        private void Номер_приказа_Enter(object sender, EventArgs e)
        {
            Код_причины.Text = "";
        }

        private void Номер_листа_нетрудоспособности_Leave(object sender, EventArgs e)
        {
            if (Код_причины.Text == "")
            {
                Код_причины.Text = "1";
            }
        }
    }
}