using DocumentFormat.OpenXml.Office2010.Excel;
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
    public partial class EditUserGrid : Form
    {
        int id32 ;
        string root =string.Empty;

        public EditUserGrid(int id, string Login, string Password, string Root)
        {
            InitializeComponent();
            Login_Box.Text = Login;
            Password_Box.Text = Password;
            id32 = id;
            User_radioButton.Checked = true;
 
        }

       private void Edit_Click(object sender, EventArgs e)
        {
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

            if (Admin_radioButton.Checked == true)
            {
               root = "0";
            }
            else
            {
                root = "1";
            }
            connection.Обновить_сотрудника(id32,Login_Box.Text,Password_Box.Text, root);
            MessageBox.Show("Запись изменена");
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
