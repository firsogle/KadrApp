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
    public partial class DeleteView : Form
    {
        public DeleteView()
        {
            InitializeComponent();
        }

        private void Командировка_Click(object sender, EventArgs e)
        {
            ReportsDelete service = new ReportsDelete(1);
            service.ShowDialog();
        }

        private void Отпуск_Click(object sender, EventArgs e)
        {
            ReportsDelete service = new ReportsDelete(2);
            service.ShowDialog();
        }

        private void Больничный_Click(object sender, EventArgs e)
        {
            ReportsDelete service = new ReportsDelete(3);
            service.ShowDialog();
        }

        private void Уволенные_Click(object sender, EventArgs e)
        {
            ReportsDelete service = new ReportsDelete(4);
            service.ShowDialog();
        }

        private void Закрыть_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
