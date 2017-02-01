using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/***************************************************************************************
 *  NAME:   LeaseDataSet.cs
 *  TYPE:   Class
 *  DESC:   Creates a List of LeaseData01 objs from file input   
 *          Prints a sorted collection of lease data to STDOUT
 *  CODER:  bauman.michelle.p.work@gmail.com
 *  DATE:   2017.01
 * *************************************************************************************/
namespace PropertyBrands
{
    public class LeaseDataSet
    {
        // List of LeastData01 objs
        private List<LeaseData01> leases;
        public LeaseDataSet(String data)
        {
            leases = new List<LeaseData01>();
            ProcessData(data);
        }

        // Loops through each file line to create a new LeastData01
        private void ProcessData(String data)
        {
            string[] filelines = File.ReadAllLines(data);
            for (int i = 0; i < filelines.Length; i++) leases.Add(new LeaseData01(filelines[i]));
        }

        // Prints each LeastData01 obj
        public void Display()
        {
            leases.Sort();
            foreach (LeaseData01 d1 in leases) Console.WriteLine(d1.ToString());
        }
    }
}
