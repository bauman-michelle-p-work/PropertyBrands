package PropertyBrands;

/***************************************************************************************
 *  NAME:   LeaseData01.cs
 *  TYPE:   Class
 *  DESC:   Lease Data Obj - parses lease data and as a collection can be sorted
 *  CODER:  bauman.michelle.p.work@gmail.com
 *  DATE:   2017.01
 * *************************************************************************************/
public class LeaseData01 implements Comparable<LeaseData01> 
{
	// Lease Data Vars
    public Integer unit1;
    public String unit2;
    public String resident;
    public String leaseStr;
    public String delimiters = "[#-]";
    
    /// <summary>
    /// Creates a Lease record from string input
    /// Parses string to set values
    /// </summary>
    /// <param name="leaseStr0"></param>
    public LeaseData01(String leaseStr0) throws Exception {
        
        // Lease String: Take out the #,- chars to separate actual values
        // Unit: made up of 2 vars, numerical and alpha part if it has one
        // Resident: string var
    	this.leaseStr = new String(leaseStr0);
        String[] leaseParts = leaseStr0.split(delimiters);
        String unit = new String(leaseParts[1].trim());
        String unit01 = new String(unit);         String unit02 = new String(unit);
        this.unit1= Integer.parseInt(unit01.replaceAll("(\\p{Alpha})", ""));
        this.unit2 = unit02.replaceAll("[\\d-]", "");
        this.resident = leaseParts[2].trim();        
    }
    
    /// <summary>
    /// Collection Sorting Method
    /// Sorts collection by Unit value
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    @Override
    public int compareTo(LeaseData01 other){        
       return (this.unit1 == other.unit1) ? this.unit2.compareTo(other.unit2) : this.unit1.compareTo(other.unit1); 
    }
    
    /// <summary>
    /// Returns a String representation for Obj
    /// Returns the initial file line input for this object
    /// </summary>
    /// <returns></returns>
    @Override
    public String toString(){        
    	return this.leaseStr;
    }
}


