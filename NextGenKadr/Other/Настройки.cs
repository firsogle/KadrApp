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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Del_Reports_Click(object sender, EventArgs e)
        {
            connection.ReadDB("DELETE from [Сведения об отпусках]");
            connection.ReadDB("delete from [Сведения о командировках]");
            connection.ReadDB("delete from [Сведения об уволенных]");
            connection.ReadDB("delete from [Сведения о больничных]");
        }

        private void Del_Persons_Click(object sender, EventArgs e)
        {

        }

        private void Del_users_Click(object sender, EventArgs e)
        {

        }

        private void Del_DB(object sender, EventArgs e)
        {
            connection.ReadDB("DELETE from [Сведения об отпусках]");
            connection.ReadDB("delete from [Сведения о командировках]");
            connection.ReadDB("delete from [Сведения об уволенных]");
            connection.ReadDB("delete from [Сведения о больничных]");
        }
    }
}
