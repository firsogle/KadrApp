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
                GridUsers.DataSource = connection.LoadGrid("SELECT Id, Login, Password, Root FROM Users").Tables[0].DefaultView;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Select_Click(object sender, EventArgs e)
        {
            string id = GridUsers.Rows[GridUsers.CurrentCell.RowIndex].Cells["ID"].Value.ToString();
            string Login = GridUsers.Rows[GridUsers.CurrentCell.RowIndex].Cells["Login"].Value.ToString();
            string Password = GridUsers.Rows[GridUsers.CurrentCell.RowIndex].Cells["Password"].Value.ToString();
            string Root = GridUsers.Rows[GridUsers.CurrentCell.RowIndex].Cells["Root"].Value.ToString();
            EditUserGrid service = new EditUserGrid(id, Login, Password, Root);
            service.ShowDialog();
        }
    }
}
