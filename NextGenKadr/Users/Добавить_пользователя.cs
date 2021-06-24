using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace NextGenKadr.Users
{
    public partial class Добавить_пользователя : Form
    {
        string key = string.Empty;
        public Добавить_пользователя(string id = "")
        {
            InitializeComponent();
            key = id;
            Пользователь_radioButton.Checked = true;

        }
        public static string HashPassword(string password)
        {
            byte[] salt;
            byte[] buffer2;
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, 0x10, 0x3e8))
            {
                salt = bytes.Salt;
                buffer2 = bytes.GetBytes(0x20);
            }
            byte[] dst = new byte[0x31];
            Buffer.BlockCopy(salt, 0, dst, 1, 0x10);
            Buffer.BlockCopy(buffer2, 0, dst, 0x11, 0x20);
            return Convert.ToBase64String(dst);
        }
        
        private void Authorization_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Создать_пользователя_Box.PerformClick();
            }
        }

        private void Login_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Создать_пользователя_Box.PerformClick();
            }
        }

        private void Password_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Создать_пользователя_Box.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            string login = Логин_Box.Text;
            string password = Пароль_Box.Text;
            string root = string.Empty;
            string TabNumber = string.Empty;



            if (Логин_Box.TextLength < 5)
            {
                MessageBox.Show("Введённый логин короче пяти символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (Пароль_Box.TextLength < 5 || Повтор_пароля_Box.TextLength < 5)
            {
                MessageBox.Show("Введённый пароль короче пяти символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (Администратор_radioButton.Checked == false && Пользователь_radioButton.Checked == false)
            {
                MessageBox.Show("Выберите уровень прав пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (Логин_Box.Text == "" || Пароль_Box.Text == "" || Повтор_пароля_Box.Text == "")
            {
                MessageBox.Show("Не все поля формы заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (Пароль_Box.Text != Повтор_пароля_Box.Text)
            {
                MessageBox.Show("Введённые пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

             TabNumber = connection.Получить_сведения_из_базы_данных($"SELECT Логин FROM Пользователи WHERE Логин = '{login}'");
            
             if (TabNumber == Логин_Box.Text)
            {
                MessageBox.Show("Логин занят! Попробуйте другой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                if (Администратор_radioButton.Checked == true)
                {
                    root = "0";
                }
                else
                {
                    root = "1";
                }
                connection.Внести_нового_пользователя(login, HashPassword(password), root);
                MessageBox.Show("Пользователь создан!");
                connection.Запись_в_журнал(Логин_Box.Text, "Создание пользователя", "Пользователи", Data.UserAuthorization);
                Close();
            }


        }
    }

}
