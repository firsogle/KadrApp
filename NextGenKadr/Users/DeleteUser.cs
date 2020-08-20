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
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            {
                GridUsers.DataSource = connection.LoadGrid("SELECT Id, Login, Password, Root FROM Users").Tables[0].DefaultView;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Select_CLick(object sender, EventArgs e)
        {
            string id = GridUsers.Rows[GridUsers.CurrentCell.RowIndex].Cells["ID"].Value.ToString();
            DialogResult result = MessageBox.Show("Удалить запись?", "Выйти", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                connection.DeletePerson($"Delete FROM Users WHERE ID = {id}");
                GridUsers.DataSource = connection.LoadGrid("SELECT Id, Login, Password, Root FROM Users").Tables[0].DefaultView;
            }
        }
    }
}
