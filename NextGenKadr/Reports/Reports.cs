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
    public partial class Reports : Form
    {
        string key = string.Empty;
        public Reports (string id = "")
        {
            InitializeComponent();
            key = id;
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            {
                GridReport.DataSource = connection.LoadGrid("SELECT ID, Фамилия, Имя, Отчество, Должность FROM General").Tables[0].DefaultView;
            }
        }

        private void Com_Click(object sender, EventArgs e)
        {
            string id = GridReport.Rows[GridReport.CurrentCell.RowIndex].Cells["ID"].Value.ToString();
            Com service = new Com(id);
            service.ShowDialog();
        }

        private void Bol_Click(object sender, EventArgs e)
        {
            string id = GridReport.Rows[GridReport.CurrentCell.RowIndex].Cells["ID"].Value.ToString();
            Bol service = new Bol(id);
            service.ShowDialog();
        }

        private void Otp_Click(object sender, EventArgs e)
        {
            string id = GridReport.Rows[GridReport.CurrentCell.RowIndex].Cells["ID"].Value.ToString();
            Otp service = new Otp(id);
            service.ShowDialog();
        }

        private void ListDelete_Click(object sender, EventArgs e)
        {
            string id = GridReport.Rows[GridReport.CurrentCell.RowIndex].Cells["ID"].Value.ToString();
            ListDelete service = new ListDelete(id);
            service.ShowDialog();
        }
    }
}
