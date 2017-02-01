using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/***************************************************************************************
 *  NAME:   LeaseDataForm.cs
 *  TYPE:   WinForm
 *  DESC:   Displays form for user to browse to a data file for processing and display
 *          unit number / resident name data. 
 *          sort lease data read from a file
 *          print the sorted data to STDOUT. 
 *  FUNC:
 *          Sorts   data file
 *          DATA:   Text File
 *                  Lines to take in 2 values
 *                  Values: Lease Data - Strings in Text File
 *                          Unit - Sorted String
 *                          Name - Associated 
 *  CODER:  bauman.michelle.p.work@gmail.com
 *  DATE:   2017.01
 * *************************************************************************************/
namespace PropertyBrands
{
    /// <summary>
    ///     Form Display
    ///     Browse Button to load data Text file for processing
    /// </summary>
    public partial class LeaseDataForm : Form
    {
        // Lease Data Obj
        protected LeaseDataSet leaseData2 = null;

        public LeaseDataForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// File Browse Ctrl: User selects file
        /// Lease Data Obj: Created from file
        ///     Processes and Displays Data
        /// </summary>
        protected void DataProcess()
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Select a File";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                leaseData2 = new LeaseDataSet(theDialog.FileName);
                leaseData2.Display();
            }
        }

        private void FileBrowse_Click(object sender, EventArgs e)
        {
            DataProcess();
        }
    }
}
