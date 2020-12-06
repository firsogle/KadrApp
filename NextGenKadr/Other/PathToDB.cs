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
             OpenFile();
        }

        public string OpenFile()
        {

            try
            {
                string PathtoDB;
                if ((File.Exists("Path.txt")))
                {
                    FileStream input = new FileStream("Path.txt", FileMode.Open, FileAccess.Read);
                    StreamReader inputfile = new StreamReader(input);
                    PathtoDB = inputfile.ReadLine();

                    Path = Convert.ToString(PathtoDB);
                    PathToDB_TextBox.Text = Path;

                    return Path;
                }
                else
                {
                    using (FileStream fs = File.Create("Path.txt", 1024))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes(
                            @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\KadrApp\NextGenKadr\DataBase_Kadry.mdf; Integrated Security = True");
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                        Path = Convert.ToString(info);
                    }
                    return Path;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка");
                return Path;
            }
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
