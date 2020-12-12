using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NextGenKadr
{
    public partial class PathToDB : Form
    {
        public string Path;

        public PathToDB()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public string OpenFile()
        {
            FileStream filestream = new FileStream("Path.txt", FileMode.Open, FileAccess.Read);

            try
            {
                
                if ((File.Exists("Path.txt")))
                {
                    StreamReader inputfile = new StreamReader(filestream);
                    Path = Convert.ToString(inputfile.ReadLine());
                    PathToDB_TextBox.Text = Path;
                    filestream.Close();
                    PathToDB_TextBox.Text = Path;
                    return Path;

                }
                else
                {
                   
                    byte[] info = new UTF8Encoding(true).GetBytes(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\KadrApp\NextGenKadr\DataBase_Kadry.mdf; Integrated Security = True"); 
                    filestream.Write(info, 0, info.Length);
                    StreamReader inputfile = new StreamReader(filestream);
                    Path = Convert.ToString(inputfile.ReadLine());
                    filestream.Close();
                    return Path;
                }
            }
            catch
            {
                MessageBox.Show("База не найдена, укажите путь к базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                filestream.Close();
                return Path;
            }
        }
        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void Изменить_путь_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                UpdatePath(OPF.FileName);
                MessageBox.Show("База найдена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void UpdatePath(string Path)
        {
            StreamWriter file;
            FileInfo fi = new FileInfo("Path.txt");
            PathToDB_TextBox.Text = Path;
            file = fi.CreateText();   
            file.WriteLine(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = "+Path+"; Integrated Security = True");
            file.Close();
            PathToDB_TextBox.Text = Path;
        }

        private void PathToDB_Load(object sender, EventArgs e)
        {
            FileStream filestream = new FileStream("Path.txt", FileMode.Open, FileAccess.Read);
            StreamReader inputfile = new StreamReader(filestream);
            PathToDB_TextBox.Text = Convert.ToString(inputfile.ReadLine());
            filestream.Close();
        }

    }
}