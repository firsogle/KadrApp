using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using NextGenKadr.Users;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace NextGenKadr
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Authorization_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Войти_Button.PerformClick();
            }
        }

        private void Login_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Войти_Button.PerformClick();
            }
        }

        private void Password_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Войти_Button.PerformClick();
            }
        }
        public static bool ByteArraysEqual(byte[] b1, byte[] b2)
        {
            if (b1 == b2) return true;
            if (b1 == null || b2 == null) return false;
            if (b1.Length != b2.Length) return false;
            for (int i = 0; i < b1.Length; i++)
            {
                if (b1[i] != b2[i]) return false;
            }
            return true;
        }

        public static bool VerifyHashedPassword(string hashedPassword, string password)
        {
            byte[] buffer4;
            if (hashedPassword == null)
            {
                return false;
            }
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            byte[] src = Convert.FromBase64String(hashedPassword);
            if ((src.Length != 0x31) || (src[0] != 0))
            {
                return false;
            }
            byte[] dst = new byte[0x10];
            Buffer.BlockCopy(src, 1, dst, 0, 0x10);
            byte[] buffer3 = new byte[0x20];
            Buffer.BlockCopy(src, 0x11, buffer3, 0, 0x20);
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, dst, 0x3e8))
            {
                buffer4 = bytes.GetBytes(0x20);
            }
            return ByteArraysEqual(buffer3, buffer4);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Авторизация(object sender, EventArgs e)
        {
            string login = Логин_Box.Text;
            string password = Пароль_Box.Text;
            string root = "";
            string salt = "";

            try
            {
                salt= connection.Salt(login);
                if (VerifyHashedPassword(salt, password) == true)
                {
                    root = connection.Auth(login, salt);
                }
                else
                {
                    MessageBox.Show("Неправильный пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("База повреждена, вход невозможен, укажите правильную базу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PathToDB service = new PathToDB();
                service.ShowDialog();
            }
            try
            {
                if (root == "0")
                {
                    this.DialogResult = DialogResult.OK;
                    Data.UserAuthorization = Логин_Box.Text;
                    Close();
                }

                if (root == "1")
                {
                    this.DialogResult = DialogResult.No;
                    Data.UserAuthorization = Логин_Box.Text;
                    Close();
                }
            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("База не найдена, укажите путь к базе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PathToDB service = new PathToDB();
                service.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Добавить_пользователя service = new Добавить_пользователя();
            service.ShowDialog();
        }

        private void Кадровик_Label_Click(object sender, EventArgs e)
        {

        }
    }
}



