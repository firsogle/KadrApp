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
    public partial class UsersList : Form
    {
        string key = string.Empty;
        public UsersList(string id = "")
        {
            InitializeComponent();
            key = id;
        }

        private void UsersList_Load(object sender, EventArgs e)
        {
            {
                GridUsers.DataSource = connection.ReloadGrid("SELECT [Id пользователя], Логин, Пароль, Права FROM Пользователи").Tables[0].DefaultView;
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
