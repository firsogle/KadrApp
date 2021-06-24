using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextGenKadr.Other
{
    public partial class Grid_Журнал : Form
    {
        public Grid_Журнал()
        {
            InitializeComponent();

            Поле_список_отчетов_Grid.DataSource = connection.ReloadGrid("SELECT * FROM [Журнал]").Tables[0].DefaultView;
        }

        private void Закрыть_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}