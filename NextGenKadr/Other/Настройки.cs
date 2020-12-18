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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Удалить_пользователей_Click(object sender, EventArgs e)
        {
            connection.Получить_сведения_из_базы_данных("delete from [Пользователи] where Логин != 'admin'");
            MessageBox.Show("Все пользователи удалены! Кроме admin", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Удалить_сотрудников_Click(object sender, EventArgs e)
        {
            connection.Получить_сведения_из_базы_данных("delete from [Сведения о воиснком учёте]");
            connection.Получить_сведения_из_базы_данных("delete from [Сведения о заработной плате]");
            connection.Получить_сведения_из_базы_данных("delete from [Сведения о послевузовском образовании]");
            connection.Получить_сведения_из_базы_данных("delete from [Сведения об образовании]");
            connection.Получить_сведения_из_базы_данных("delete from [Трудовая деятельность]");
            connection.Получить_сведения_из_базы_данных("delete from [Общие сведения]");
            connection.Получить_сведения_из_базы_данных("delete from [Сотрудники]");
            MessageBox.Show("Все сотрудники удалены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
            
        private void Удалить_отчеты_Click(object sender, EventArgs e)
        {
            connection.Получить_сведения_из_базы_данных("delete from [Сведения об отпусках]");
            connection.Получить_сведения_из_базы_данных("delete from [Сведения о командировках]");
            connection.Получить_сведения_из_базы_данных("delete from [Сведения об уволенных]");
            connection.Получить_сведения_из_базы_данных("delete from [Сведения о больничных]");
            MessageBox.Show("Все отчеты удалены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Удалить_всё_Click(object sender, EventArgs e)
        {
            connection.Получить_сведения_из_базы_данных("delete from [Сведения об отпусках]");
            connection.Получить_сведения_из_базы_данных("delete from [Сведения о командировках]");
            connection.Получить_сведения_из_базы_данных("delete from [Сведения об уволенных]");
            connection.Получить_сведения_из_базы_данных("delete from [Сведения о больничных]");
            connection.Получить_сведения_из_базы_данных("delete from [Сведения о воиснком учёте]");
            connection.Получить_сведения_из_базы_данных("delete from [Сведения о заработной плате]");
            connection.Получить_сведения_из_базы_данных("delete from [Сведения о послевузовском образовании]");
            connection.Получить_сведения_из_базы_данных("delete from [Сведения об образовании]");
            connection.Получить_сведения_из_базы_данных("delete from [Трудовая деятельность]");
            connection.Получить_сведения_из_базы_данных("delete from [Общие сведения]");
            connection.Получить_сведения_из_базы_данных("delete from [Сотрудники]");
            connection.Получить_сведения_из_базы_данных("delete from [Пользователи] where Логин != 'admin'");
            MessageBox.Show("Все записи удалены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
