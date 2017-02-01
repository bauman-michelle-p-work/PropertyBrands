package PropertyBrands;
import java.util.*;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.List;

/***************************************************************************************
 *  NAME:   LeaseDataSet.cs
 *  TYPE:   Class
 *  DESC:   Creates a List of LeaseData01 objs from file input   
 *          Prints a sorted collection of lease data to STDOUT
 *  CODER:  bauman.michelle.p.work@gmail.com
 *  DATE:   2017.01
 * *************************************************************************************/
public class LeaseDataSet   
{
	// List of LeastData01 objs
    public ArrayList<LeaseData01> leases2;
    public LeaseDataSet(String data) throws Exception {
        leases2 = new ArrayList<LeaseData01>();
        processData(data);
    }
    
    // Loops through each file line to create a new LeastData01
    public void processData(String data) throws Exception {
        List<String> filelines = Files.readAllLines(Paths.get(data));
        for (String st : filelines) leases2.add(new LeaseData01(st));
    }

    public void display() {
    	Collections.sort(leases2);
		for (LeaseData01 d1 : leases2) System.out.println(d1.leaseStr);
    }
}


