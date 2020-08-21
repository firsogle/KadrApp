using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;
using NextGenKadr.Users;


namespace NextGenKadr
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AddPerson_Click(object sender, EventArgs e)
        {
            AddPerson service = new AddPerson();
            service.ShowDialog();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            MainGrid.DataSource = connection.ReloadGrid("SELECT * FROM General").Tables[0].DefaultView;
            MainGrid.AllowUserToAddRows = false;
            UserLabel.Text = Data.UserAuthorization;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string id = MainGrid.Rows[MainGrid.CurrentCell.RowIndex].Cells["ID"].Value.ToString();
            UpdatePerson service = new UpdatePerson(id);
            service.ShowDialog();
        }

        private void DeletePerson_Click(object sender, EventArgs e)
        {
            string id = MainGrid.Rows[MainGrid.CurrentCell.RowIndex].Cells["ID"].Value.ToString();
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
                foreach (DataGridViewColumn column in MainGrid.Columns)
                {
                    dt.Columns.Add(column.HeaderText, column.ValueType);
                }
                foreach (DataGridViewRow row in MainGrid.Rows)
                {
                    dt.Rows.Add();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                    }
                }
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(dt, "General");
                    wb.SaveAs(Path.Combine(Path.GetTempPath(), (name + ".xlsx")));
                }
                System.Diagnostics.Process.Start(Path.GetTempPath() + (name + ".xlsx"));

            }
        }

        private void ViewPersonStrip_Click(object sender, EventArgs e)
        {
            try
            {
                string id = MainGrid.Rows[MainGrid.CurrentCell.RowIndex].Cells["ID"].Value.ToString();
                ViewPerson service = new ViewPerson(id);
                service.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите запись сотрудника");
            }
        }

        private void ViewReports_Click(object sender, EventArgs e)
        {
            ViewReports service = new ViewReports();
            service.ShowDialog();

        }

        private void Reports_Click(object sender, EventArgs e)
        {
            string id = MainGrid.Rows[MainGrid.CurrentCell.RowIndex].Cells["ID"].Value.ToString();
            Reports service = new Reports();
            service.ShowDialog();
        }

        private void UsersList_Click(object sender, EventArgs e)
        {
            UsersList service = new UsersList();
            service.ShowDialog();
        }

        private void DeleteReports_Click(object sender, EventArgs e)
        {
            string id = MainGrid.Rows[MainGrid.CurrentCell.RowIndex].Cells["ID"].Value.ToString();
            ReportsDelete service = new ReportsDelete();
            service.ShowDialog();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            AddUser service = new AddUser();
            service.ShowDialog();
        }

        private void EditUser_Click(object sender, EventArgs e)
        {
            EditUser service = new EditUser();
            service.ShowDialog();
        }
            
        private void DeleteUser_Click(object sender, EventArgs e)
        {
            DeleteUser service = new DeleteUser();
            service.ShowDialog();
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Point MouseHook;
        private void AdminForm_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Default;
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            else
            {
                Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
                Cursor = Cursors.Hand;
            }
        }

        private void Journal_Click(object sender, EventArgs e)
        {
            Journal service = new Journal();
            service.ShowDialog();
        }

        private void Path_Click(object sender, EventArgs e)
        {
            PathToDB service = new PathToDB();
            service.ShowDialog();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Settings service = new Settings();
            service.ShowDialog();
        }
    }
}
