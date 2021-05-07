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
    public partial class View_orders : Form
    {
        public View_orders()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Com_Click(object sender, EventArgs e)
        {
            ViewReportsGrid service = new ViewReportsGrid(1);
            service.ShowDialog();
        }
        private void Bol_Click(object sender, EventArgs e)
        {
            ViewReportsGrid service = new ViewReportsGrid(2);
            service.ShowDialog();
        }
        private void ListDelete_Click(object sender, EventArgs e)
        {
            ViewReportsGrid service = new ViewReportsGrid(3);
            service.ShowDialog();
        }
        private void Otp_Click(object sender, EventArgs e)
        {
            ViewReportsGrid service = new ViewReportsGrid(4);
            service.ShowDialog();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
