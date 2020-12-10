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
            User_radioButton.Checked = true;

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
            string root = string.Empty;
            string TabNumber = string.Empty;



            if (Login_Box.TextLength < 5)
            {
                MessageBox.Show("Введённый логин короче пяти символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (Password_Box.TextLength < 5 || ReTypePassword_Box.TextLength < 5)
            {
                MessageBox.Show("Введённый пароль короче пяти символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (Admin_radioButton.Checked == false && User_radioButton.Checked == false)
            {
                MessageBox.Show("Выберите уровень прав пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (Login_Box.Text == "" || Password_Box.Text == "" || ReTypePassword_Box.Text == "")
            {
                MessageBox.Show("Не все поля формы заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (Password_Box.Text != ReTypePassword_Box.Text)
            {
                MessageBox.Show("Введённые пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }




             TabNumber = connection.id($"SELECT Логин FROM Пользователи WHERE Логин = '{login}'");
            
            
            if (TabNumber == Login_Box.Text)
            {
                MessageBox.Show("Логин занят! Попробуйте другой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                if (Admin_radioButton.Checked == true)
                {
                    root = "0";
                }
                else
                {
                    root = "1";
                }
                connection.Внести_нового_пользователя(login, password, root);
                MessageBox.Show("Пользователь создан!");
                Close();
            }


        }

    }

}
