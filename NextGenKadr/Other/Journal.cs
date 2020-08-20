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
    public partial class Journal : Form
    {
        public Journal()
        {
            InitializeComponent();
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateHournal_Click(object sender, EventArgs e)
        {


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Journal_Load(object sender, EventArgs e)
        {
            Jornal_Grid.DataSource = connection.ReloadGrid("SELECT * FROM Journal").Tables[0].DefaultView;
            Jornal_Grid.AllowUserToAddRows = false;
        }
    }
}
