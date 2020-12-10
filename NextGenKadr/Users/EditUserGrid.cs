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
        string id32 = string.Empty;
        string Login32;
        string Password32;
        string Root32;

        public EditUserGrid(string id, string Login, string Password, string Root)
        {
            InitializeComponent();
            Login32 = Login;
            Password32 = Password;
            Root32 = Root;
            id32 = id;

            User_radioButton.Checked = true;
        }

        private void EditUserGrid_Load(object sender, EventArgs e)
        {
           
            Login_Box.Text = Login32;
            Password_Box.Text = Password32;
            Root_Box.Text = Root32;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
       private void Edit_Click(object sender, EventArgs e)
        {
           // connection.Build($"Update Users SET Login=N'{Login_Box.Text}', Password=N'{Password_Box.Text}', Root=N'{Root_Box.Text}' WHERE ID = {id32}");
            MessageBox.Show("Запись изменена");
            Close();

        }
    }
}
