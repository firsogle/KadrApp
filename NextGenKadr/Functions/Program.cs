using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace NextGenKadr
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Authorization test = new Authorization();
            Application.Run(test);

            if (test.DialogResult == DialogResult.OK)
                Application.Run(new AdminForm());
            if (test.DialogResult == DialogResult.No)
                Application.Run(new MainForms());
           
        }
    }

    static class Data
    {
        public static string UserAuthorization { get; set; }
        public static DateTime Today { get; }
    }



}
