using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Boat reservation
a. Start a new project.
b. Build this Form, with the controls shown. In this app, the user will make a reservation to rent a boat - either a canoe, a kayak or a paddleboard. 
   The app will check the number of people renting, and make sure the number of adults and children are acceptable for the type of boat selected. 
c. The user will not be able to make a reservation until they have entered acceptable information.
d. In your Form designer, in the properties for the Reserve button, set the Enabled property to false so it can't be clicked. 
e. In your form's Load event, add the strings "Canoe", "Kayak" and "Paddleboard" to the combobox. 
f. The user will select the type of boat from the ComboBox.They will enter the number of adults and the number of children who will be using the boat.
g. They will then click the Check reservation button. The app will examine the type of boat, number of adults and number of children. 
   If the data is valid, enable the Reserve button and disable the input controls (ComboBox, number of adults TextBox, number of children TextBox).  
   Display a "Valid" message in the label to the right of the Check reservation button. The user can now click the Reserve button.
   They will see a confirmation MessageBox with details about their reservation. 
h. If the data is not valid (for example, there are more adults than will fit into the boat, or non-numerical input is entered, or negative numbers are entered) 
   the user will see a MessageBox with an error message explaining specifically what is wrong. Display an "Invalid data" message in the label 
   to the right of the Check reservation button.The Reserve button will not be enabled. The input controls will remain enabled, 
   so user will be able to change the information entered.  
i. You will need to add event handlers to the buttons to provide this functionality. 
j. The Reset button will clear the two TextBoxes, enable the Check reservation button, and disable the Reserve button.
k. The Exit button should close the Form and end the app. 
l. Here are the rules for renting each type of boat:
    A kayak can only be rented by one adult. Children may not rent a kayak. So exactly 1 adult and 0 children.
    A canoe can be rented by two adults, OR one adult and one child. There must be exactly two people, at least one adult.
    A paddleboard can be rented by one adult, OR one adult and one child. Two adults are not permitted. 
m. You must write methods to help implement this app. Suggestion: a method CheckCanoe that is given the number of adults and number of children, 
   and returns true if the numbers of adults and children are allowed, false otherwise. Similar for kayaks and paddleboards.
   Either start by writing and calling your own methods, or write all the code and refactor it into methods. 
n. Use sensible names for all the controls you use in code.
o. Configure the tab order so the user can tab between the controls in a logical way.
p. Comment your code!
*/

namespace Boat_reservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxboat.Items.Add("Canoe");
            cbxboat.Items.Add("Kayak");
            cbxboat.Items.Add("kayak");


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
