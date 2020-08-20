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
            AdminForm test2 = new AdminForm();
            MainForms test3 = new MainForms();

            Application.Run(test);

            if (test.DialogResult == DialogResult.OK)
                Application.Run(new AdminForm());
            if (test.DialogResult == DialogResult.No)
                Application.Run(new MainForms());
           
        }
    }
}
