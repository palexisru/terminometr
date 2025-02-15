using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllAI
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MDI_parent_form mfp; 
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mfp = new MDI_parent_form();
            Application.Run(mfp);
        }
    }
}
