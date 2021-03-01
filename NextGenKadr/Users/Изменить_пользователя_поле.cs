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
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            {
                Поле_пользователей_Grid.DataSource = connection.ReloadGrid("SELECT [Id пользователя], Логин, Пароль, Права FROM Пользователи").Tables[0].DefaultView;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Select_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Поле_пользователей_Grid.Rows[Поле_пользователей_Grid.CurrentCell.RowIndex].Cells["Id пользователя"].Value.ToString());
            string Login = Поле_пользователей_Grid.Rows[Поле_пользователей_Grid.CurrentCell.RowIndex].Cells["Логин"].Value.ToString();
            string Password = Поле_пользователей_Grid.Rows[Поле_пользователей_Grid.CurrentCell.RowIndex].Cells["Пароль"].Value.ToString();
            string Root = Поле_пользователей_Grid.Rows[Поле_пользователей_Grid.CurrentCell.RowIndex].Cells["Права"].Value.ToString();
            EditUserGrid service = new EditUserGrid(id, Login, Password, Root);
            service.ShowDialog();
        }

        private void Закрыть_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
