package PropertyBrands;
import java.io.*;
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.SwingUtilities;
 
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
public class LeaseDataForm extends JPanel implements ActionListener {

	static private final String newline = "\n";
    JButton openButton;
    JFileChooser fc;
    LeaseDataSet lease;
 
    /// <summary>
    ///     Form Display
    ///     Browse Button to load data Text file for processing
    /// </summary>
    public LeaseDataForm() {
        super(new BorderLayout());
        fc = new JFileChooser();
        openButton = new JButton("Choose Lease Data File");
        openButton.addActionListener(this);
        JPanel buttonPanel = new JPanel(); 
        buttonPanel.add(openButton);
        add(buttonPanel, BorderLayout.PAGE_START);
    }
 
    public void DataProcess(File file)
    {        
        try {
			this.lease = new LeaseDataSet(file.getAbsolutePath());
			this.lease.display();
		} catch (Exception e1) {
			e1.printStackTrace();
		}
    }
    
    public void actionPerformed(ActionEvent e) 
    {
        if (e.getSource() == openButton) 
        {
            if (fc.showOpenDialog(LeaseDataForm.this) == JFileChooser.APPROVE_OPTION) {
            	DataProcess(fc.getSelectedFile());
            }
        }
    }
 
    
    
    private static void createAndShowGUI() {
        JFrame frame = new JFrame("Lease Data");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.add(new LeaseDataForm());
        frame.pack();
        frame.setVisible(true);
    }
 
    public static void main(String[] args) {
        SwingUtilities.invokeLater(new Runnable() {
            public void run() {
                UIManager.put("swing.boldMetal", Boolean.FALSE); 
                createAndShowGUI();
            }
        });
    }
}
