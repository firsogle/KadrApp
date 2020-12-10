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
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            {
                GridUsers.DataSource = connection.LoadGrid("SELECT [Id пользователя], Логин, Пароль, Права FROM Пользователи").Tables[0].DefaultView;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Select_Click(object sender, EventArgs e)
        {
            string id = GridUsers.Rows[GridUsers.CurrentCell.RowIndex].Cells["Id пользователя"].Value.ToString();
            string Login = GridUsers.Rows[GridUsers.CurrentCell.RowIndex].Cells["Логин"].Value.ToString();
            string Password = GridUsers.Rows[GridUsers.CurrentCell.RowIndex].Cells["Пароль"].Value.ToString();
            string Root = GridUsers.Rows[GridUsers.CurrentCell.RowIndex].Cells["Права"].Value.ToString();
            EditUserGrid service = new EditUserGrid(id, Login, Password, Root);
            service.ShowDialog();
        }
    }
}
