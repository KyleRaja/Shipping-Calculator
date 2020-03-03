using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace proj_06_KR_V1._0.zip
{
    public partial class Form1 : Form
    {
        //Create object for the Shipping class 
        Shipping shippingCalculator;


        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // The exitToolStripMenuItem1 method
            // Purpose: To exit out of the window and close the application.
            // Parameters: Only able to exit out of window and application.  
            // Returns: None
            //void exitToolStripMenuItem1_Click(object sender, EventArgs e)
            this.Close();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // The aboutToolStripMenuItem method
            // Purpose: To get a profile about the person or company responsible for creating the application.
            // Parameters: Only able to give specific information on a company or person responsible for creating the application 
            // and the event arguments
            // Returns: After exiting from about windown, it will return to the exit window. 
            // void aboutToolStripMenuItem_Click(object sender, EventArgs e)
            MessageBox.Show("Kyle Raja\nCS1400\nproject 6");
        
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            
            
            double weight = double.Parse(typeBox.Text);
            int item = int.Parse(typeBox.Text);
            bool surcharge = false;

            int shipMethod = shipBox.SelectedIndex;
            int category = categBox.SelectedIndex;
           
 

            if (yesRadioBtn.Checked)
            {
                surcharge = true;
            }

            if (categBox.SelectedIndex == 0)
            {
                shippingCalculator = new Shipping(shipMethod, category, weight, surcharge);

            }
            else
            {
                shippingCalculator = new Shipping(shipMethod, category, item, surcharge);
            }

            double total = shippingCalculator.CalcShipping();
            totalLbl.Text = String.Format("{0:C}", total);


        }

        private void categBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categBox.SelectedIndex == 0)
            {
                label5.Text = "Weight of shipment";

            }
            else
            {
                label5.Text = "Number of items";
            }
        }


    }
}
