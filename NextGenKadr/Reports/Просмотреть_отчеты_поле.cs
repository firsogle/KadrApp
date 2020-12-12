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
            this.StartPosition = FormStartPosition.CenterScreen;
            if (number == 1)
            {
                GridReportView.DataSource = connection.ReloadGrid("SELECT * FROM [Сведения о командировках]").Tables[0].DefaultView;
            }
            if (number == 2)
            {
                GridReportView.DataSource = connection.ReloadGrid("SELECT * FROM [Сведения о больничных]").Tables[0].DefaultView;
            }
            if (number == 3)
            {
               
                GridReportView.DataSource = connection.ReloadGrid("SELECT * FROM [Сведения об уволенных]").Tables[0].DefaultView;
            }
            if (number == 4)
            {
                GridReportView.DataSource = connection.ReloadGrid("SELECT * FROM [Сведения об отпусках]").Tables[0].DefaultView;
            }
           

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
