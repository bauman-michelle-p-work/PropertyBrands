using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

/***************************************************************************************
 *  NAME:   LeaseData01.cs
 *  TYPE:   Class
 *  DESC:   Lease Data Obj - parses lease data and as a collection can be sorted
 *  CODER:  bauman.michelle.p.work@gmail.com
 *  DATE:   2017.01
 * *************************************************************************************/
namespace PropertyBrands
{
    public class LeaseData01 : IComparable<LeaseData01>
    {
        private String leaseStr;
        private int unit1;
        private String unit2;
        private String resident;

        /// <summary>
        /// Creates a Lease record from string input
        /// Parses string to set values
        /// </summary>
        /// <param name="leaseStr0"></param>
        public LeaseData01(String leaseStr0)
        {
            // Lease String: Take out the #,- chars to separate actual values
            // Unit: made up of 2 vars, numerical and alpha part if it has one
            // Resident: string var
            this.leaseStr = leaseStr0;
            char[] delimiterChars = { '#', '-' };
            String[] leaseParts = leaseStr0.Split(delimiterChars);
            String unit = leaseParts[1].Trim();
            this.unit1 = Convert.ToInt32(Regex.Replace(unit, @"\D", ""));
            this.unit2 = (String)Regex.Replace(unit, @"[\d-]", string.Empty);
            this.resident = leaseParts[2].Trim();
        }

        /// <summary>
        /// Collection Sorting Method
        /// Sorts collection by Unit value
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(LeaseData01 other)
        {
            // sort by the numeric value for comparing unit1 unless they are equal 
            // if the compared unit1 numeric val is the same then compare the unit2 aplpha val
            return (this.unit1 == other.unit1) ? this.unit2.CompareTo(other.unit2) : this.unit1.CompareTo(other.unit1);
        }

        /// <summary>
        /// Returns a String representation for Obj
        /// Returns the initial file line input for this object
        /// </summary>
        /// <returns></returns>
        public String ToString()
        {
            return this.leaseStr;
        }
    }
}
