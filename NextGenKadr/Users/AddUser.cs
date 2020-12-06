using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextGenKadr.Users
{
    public partial class AddUser : Form
    {
        string key = string.Empty;
        public AddUser(string id = "")
        {
            InitializeComponent();
            key = id;
        }

        private void Authorization_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1.PerformClick();
            }
        }

        private void Login_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1.PerformClick();
            }
        }

        private void Password_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            string login = Login_Box.Text;
            string password = Password_Box.Text;
            string root = RootBox.Text;

            if (string.IsNullOrEmpty(connection.ReadDB($"SELECT Login FROM Users WHERE Login = '{login}'")))
            {
               //добавить проверку на заполнение 3 полей
              // connection.Build($"INSERT INTO Users (Login, Password, Root) VALUES ('{login}','{password}','{root}')");
               // connection.Build($"INSERT INTO Journal ([User], Time, Action, Famaly) VALUES (N'{Data.UserAuthorization}',N'{Data.Today}',N'{"Увольнение сотрудника"}',N'{login}')");
                MessageBox.Show("Логин создан!");
               Close();

            }
            else
            {
                MessageBox.Show("Логин занят! Попробуйте другой!");
            }

        }
    }
}
