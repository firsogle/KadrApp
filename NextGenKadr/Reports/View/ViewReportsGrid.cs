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
    public partial class ViewReportsGrid : Form
    {
        public ViewReportsGrid(int number)
        {
            InitializeComponent();
            if (number == 1)
            {
                GridReportView.DataSource = connection.ReloadGrid("SELECT * FROM Com_List").Tables[0].DefaultView;
            }
            if (number == 2)
            {
                GridReportView.DataSource = connection.ReloadGrid("SELECT * FROM Otp_List").Tables[0].DefaultView;
            }
            if (number == 3)
            {
                GridReportView.DataSource = connection.ReloadGrid("SELECT * FROM Bol_List").Tables[0].DefaultView;
            }
            if (number == 4)
            {
                GridReportView.DataSource = connection.ReloadGrid("SELECT * FROM DeletePersons").Tables[0].DefaultView;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
