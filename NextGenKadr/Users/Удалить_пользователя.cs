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
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            {
                Поле_пользователей_Grid.DataSource = connection.ReloadGrid("SELECT [Id пользователя], Логин, Пароль, Права FROM Пользователи").Tables[0].DefaultView;
            }
        }

        private void Select_CLick(object sender, EventArgs e)
        {
            string id = Поле_пользователей_Grid.Rows[Поле_пользователей_Grid.CurrentCell.RowIndex].Cells["Id пользователя"].Value.ToString();
            DialogResult result = MessageBox.Show("Удалить запись?", "Выйти", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                connection.Получить_сведения_из_базы_данных($"Delete FROM Пользователи WHERE [Id пользователя] = {id}");
                Поле_пользователей_Grid.DataSource = connection.ReloadGrid("SELECT [Id пользователя], Логин, Пароль, Права FROM Пользователи").Tables[0].DefaultView;
            }
        }

        private void Закрыть_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
