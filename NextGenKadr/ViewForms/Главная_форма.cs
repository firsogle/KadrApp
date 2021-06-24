using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;
using NextGenKadr.Users;


namespace NextGenKadr
{
    public partial class MainForms : Form
    {
        public MainForms()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AddPerson_Click(object sender, EventArgs e)
        {
            AddPerson service = new AddPerson();
            service.ShowDialog();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {

            Добавить_пользователя service = new Добавить_пользователя();
            service.ShowDialog();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            Поле_главного_меню.DataSource = connection.ReloadGrid("SELECT * FROM Сотрудники").Tables[0].DefaultView;
            Поле_главного_меню.AllowUserToAddRows = false;
            Пользователь_Label.Text = Data.UserAuthorization;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string id = Поле_главного_меню.Rows[Поле_главного_меню.CurrentCell.RowIndex].Cells["Табельный номер"].Value.ToString();
            UpdatePerson service = new UpdatePerson(id);
            service.ShowDialog();
        }

        private void DeletePerson_Click(object sender, EventArgs e)
        {
            string id = Поле_главного_меню.Rows[Поле_главного_меню.CurrentCell.RowIndex].Cells["Табельный номер"].Value.ToString();
            DeletePerson service = new DeletePerson(id);
            service.ShowDialog();
        }

        private void Export_Click(object sender, EventArgs e)
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
                foreach (DataGridViewColumn column in Поле_главного_меню.Columns)
                {
                    dt.Columns.Add(column.HeaderText, column.ValueType);
                }
                foreach (DataGridViewRow row in Поле_главного_меню.Rows)
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
        private void ViewPersonStrip_Click(object sender, EventArgs e)
        {
            try
            {
                string id = Поле_главного_меню.Rows[Поле_главного_меню.CurrentCell.RowIndex].Cells["Табельный номер"].Value.ToString();
                ViewPerson service = new ViewPerson(id);
                service.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбран сотрудник, сначала создайте сотрудника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        private void ViewReports_Click(object sender, EventArgs e)
        {
            View_orders service = new View_orders();
            service.ShowDialog();
        }
        private void Reports_Click(object sender, EventArgs e)
        {
            string id = Поле_главного_меню.Rows[Поле_главного_меню.CurrentCell.RowIndex].Cells["Табельный номер"].Value.ToString();
            Reports service = new Reports();
            service.ShowDialog();
        }
        private void DeleteReports_Click(object sender, EventArgs e)
        {
            string id = Поле_главного_меню.Rows[Поле_главного_меню.CurrentCell.RowIndex].Cells["Табельный номер"].Value.ToString();
            DeleteView service = new DeleteView();
            service.ShowDialog();
        }
        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Point MouseMain;
        private void MainForms_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) MouseMain = e.Location;
            Location = new Point((Size)Location - (Size)MouseMain + (Size)e.Location);
        }
        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) MouseMain = e.Location;
            Location = new Point((Size)Location - (Size)MouseMain + (Size)e.Location);
        }

        private void MainForms_Activated(object sender, EventArgs e)
        {
            Поле_главного_меню.DataSource = connection.ReloadGrid("SELECT * FROM Сотрудники").Tables[0].DefaultView;
        }
    }
}
