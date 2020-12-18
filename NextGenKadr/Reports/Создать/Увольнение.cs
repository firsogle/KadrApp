using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ClosedXML.Excel;
using System.IO;
using System.Diagnostics;

namespace NextGenKadr
{
    public partial class ListDelete : Form
    {
        string key = string.Empty;
        public ListDelete(string id = "")
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            key = id;
        }
        private void ListDelete_Load(object sender, EventArgs e)
        {
          GridDelete.DataSource = connection.ReloadGrid("SELECT * FROM [Сведения об уволенных]").Tables[0].DefaultView;
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            {
                Random r = new Random();
                string name = string.Empty;
                for (int i = 0; i < 10; i++)
                {
                    char randomChar = (char)r.Next('a', 'z');
                    name = name + randomChar;
                }
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn column in GridDelete.Columns)
                {
                    dt.Columns.Add(column.HeaderText, column.ValueType);
                }
                foreach (DataGridViewRow row in GridDelete.Rows)
                {
                    dt.Rows.Add();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                    }
                }
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(dt, "Сотрудники");
                    wb.SaveAs(Path.Combine(Path.GetTempPath(), (name + ".xlsx")));
                }
                System.Diagnostics.Process.Start(Path.GetTempPath() + (name + ".xlsx"));

            }
        }
    }
}
