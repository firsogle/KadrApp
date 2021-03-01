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
                Поле_список_отчетов_Grid.DataSource = connection.ReloadGrid("SELECT * FROM [Сведения о командировках]")
                    .Tables[0].DefaultView;
            }

            if (number == 2)
            {
                Поле_список_отчетов_Grid.DataSource = connection.ReloadGrid("SELECT * FROM [Сведения о больничных]")
                    .Tables[0].DefaultView;
            }

            if (number == 3)
            {
                this.Выбрать_запись_Button.Enabled = false;
                Поле_список_отчетов_Grid.DataSource = connection.ReloadGrid("SELECT * FROM [Сведения об уволенных]")
                    .Tables[0].DefaultView;
            }

            if (number == 4)
            {
                Поле_список_отчетов_Grid.DataSource = connection.ReloadGrid("SELECT * FROM [Сведения об отпусках]").Tables[0]
                    .DefaultView;
            }

            if (number == 5)
            {
                this.Выбрать_запись_Button.Enabled = true;
                Поле_список_отчетов_Grid.DataSource = connection.ReloadGrid("SELECT * FROM [Сведения об уволенных]")
                    .Tables[0].DefaultView;
            }
        }


        private void Закрыть_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Экспорт_Click(object sender, EventArgs e)
        {
            string id = Поле_список_отчетов_Grid.Rows[Поле_список_отчетов_Grid.CurrentCell.RowIndex].Cells["Табельный номер"].Value.ToString();
            ListDelete service = new ListDelete(id);
            service.ShowDialog();
        }
    }
}
