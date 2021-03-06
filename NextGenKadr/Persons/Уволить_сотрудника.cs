using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextGenKadr
{
    public partial class DeletePerson : Form
    {
        string key = string.Empty;
        public DeletePerson (string id )
        {
            string key = id;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Имя_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT Имя FROM Сотрудники WHERE [Табельный номер] = {id}");
            Фамилия_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT Фамилия FROM Сотрудники WHERE [Табельный номер] = {id}");
            Отчество_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT Отчество FROM Сотрудники WHERE [Табельный номер] = {id}");
            Должность_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Должность] FROM [Сведения о заработной плате] WHERE [Табельный номер] = {id}");
            Табельный_номер_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Табельный номер] FROM [Общие сведения] WHERE [Табельный номер] = {id}");
            Номер_договора_Box.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Номер договора] FROM [Трудовая деятельность] WHERE [Табельный номер] = {id}");
            Срок_договора_Picker.Text = connection.Получить_сведения_из_базы_данных($"SELECT [Срок договора] FROM [Трудовая деятельность] WHERE [Табельный номер] = {id}");
        }
        private void Закрыть_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Уволить_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Внести_cведения_об_уволенных(Табельный_номер_Box.Text, Причина_Box.Text, Дата_увольнения_Picker.Text, Имя_Box.Text, Фамилия_Box.Text, Отчество_Box.Text);
                connection.Получить_сведения_из_базы_данных($"Delete FROM [Общие сведения] WHERE ID = {key}");
                connection.Получить_сведения_из_базы_данных($"Delete FROM [Сведения паспорта] WHERE ID = {key}");
                connection.Получить_сведения_из_базы_данных($"Delete FROM [Сведения заграниченого паспорта] WHERE ID = {key}");
                connection.Получить_сведения_из_базы_данных($"Delete FROM [Сведения об образовании] WHERE ID = {key}");
                connection.Получить_сведения_из_базы_данных($"Delete FROM [Сведения о послевузовском образовании] WHERE ID = {key}");
                connection.Получить_сведения_из_базы_данных($"Delete FROM [Сведения о воиснком учёте] WHERE ID = {key}");
                connection.Получить_сведения_из_базы_данных($"Delete FROM [Трудовая деятельность] WHERE ID = {key}");
                connection.Получить_сведения_из_базы_данных($"Delete FROM [Сведения о воиснком учёте] WHERE ID = {key}");
                connection.Получить_сведения_из_базы_данных($"Delete FROM [Сведения о заработной плате] WHERE ID = {key}");
                connection.Получить_сведения_из_базы_данных($"Delete FROM [Сотрудники] WHERE ID = {key}");

                MessageBox.Show($"Сотрудник {Фамилия_Box.Text} {Имя_Box.Text} {Отчество_Box.Text} удалён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show($"Не удалось удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}