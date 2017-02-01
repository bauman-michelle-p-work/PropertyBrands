using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************************************
 *  NAME:   Program.cs
 *  TYPE:   WinForm
 *  DESC:   Launches Windows Form for processing of Lease data
 *  CODER:  bauman.michelle.p.work@gmail.com
 *  DATE:   2017.01
 * *************************************************************************************/
namespace PropertyBrands
{
    static class Program
    {
        /// <summary>
        /// Launch Lease Processing Form
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LeaseDataForm());
        }
    }
}
