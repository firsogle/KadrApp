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

        private void Authorization_Click(object sender, EventArgs e)
        {
            string login = Login_Box.Text;
            string password = Password_Box.Text;
            string root = "";

            try
            {
                root = connection.Auth(login, password);
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
                    Data.UserAuthorization = Login_Box.Text;
                    Close();
                }

                if (root == "1")
                {
                    this.DialogResult = DialogResult.No;
                    Data.UserAuthorization = Login_Box.Text;
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
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}



