//Programmer : Bryan Miranda
//Project : Assignment 4
//Date: 04/22/2021
//Description : Assignment 4 Hopkins Film School Registration Form
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Added namespace to allow use of stream reader/write class

namespace Miranda_4
{
    public partial class RegistrationForm : Form
    {
        //declaration of class level constants 
        private const decimal LIVE_ACTION_CLASS_PRICE = 79.95m; // pricing for live action class
        private const decimal ANIMATION_CLASS_PRICE = 99.95m; // Pricing for animation class 
        private const decimal MAXIMUM_COURSES = 4; // Max number of classes that can be selected.

        // Decalring Class level variables
        private int numberofClasses;// Number of classes selected
        private decimal PricePerClass; // Price per class selection
        private decimal TotalPrice; // Total calculation Variable

        public RegistrationForm()
        {
            InitializeComponent();
        }
        private void RegistrationForm_Load_1(object sender, EventArgs e)
        {
            //Added current date string method for the registration date text box
            datemaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyy");

            //Creating class level array as stated for the combo box status selection
            string[] status = { "Actor", "Producer", "Director", "Animator", "Cinematographer", "Drama Teacher", "Light Technician", "Sound Technician" };
            
            // Loading array status in the combo box
            for (int i = 0; i < status.Length; i++)
                statuscomboBox.Items.Add(status[i]);

            //Updating label for list box with max number of classes
            classesLabel.Text = "Classes (maximum of " + MAXIMUM_COURSES + "):";

            // Custom PopulateList method to populate classes list below as mentioned 
            PopulateList();

            //Custom Update totals also created for displaying total values
            UpdateTotals();
        }
        //This radio button will combine the actions of both the radio buttons 
        private void liveradioButton_CheckedChanged(object sender, EventArgs e)
        {
            PopulateList();

            UpdateTotals();
        }

        private void classlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotals(); // Calling custom method to update totals
        }

        private void saveStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declaring local variables to save information 
            string classList = ""; // Holding facility for the list of courses selected
            string PaymentType; // Type of payemnt selected
            string ReceiptPreference; // Email selection of receipt

            //if statement being created when all data is filled . will not save until fields are filled
            if (numberofClasses == 0)
            {

                MessageBox.Show("At least 1 class has to be selected in order to register.",
                    "Class Selection is Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numberofClasses > MAXIMUM_COURSES)
            {
                MessageBox.Show("No More than" + MAXIMUM_COURSES + "classes can be selected.",
                    "Error in Class Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (firstnametextBox.Text == "" || lastnametextBox.Text == "")
            {
                MessageBox.Show("First and last name must be entered for information to be valid.",
                    "Data is missing in certain fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (emailtextBox.Text == "")
            {
                MessageBox.Show("Email is required to proceed please fill this portion out.",
                    "Data is missing in certain fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dobmaskedTextBox.MaskCompleted == false)
            {
                MessageBox.Show("Date of birth must be entered in order to proceed please fill this portion out",
                    "Data is missing in certain fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // Process the information
            {
                // loop for all items in list box
                for (int counter = 0; counter < classlistBox.Items.Count; counter++)
                {
                    //Using get selected method to figure out if list item is selected
                    if (classlistBox.GetSelected(counter))
                    {
                        classList += classlistBox.Items[counter] + "\r\n";
                    }
                }
                //values set for payment types for use in output format
                if (cashradioButton.Checked)
                {
                    PaymentType = "Cash";
                }
                else
                {
                    PaymentType = "Check";
                }
                //now we do the email values if selected
                if (emailcheckBox.Checked)
                {
                    ReceiptPreference = "Yes";
                }
                else
                {
                    ReceiptPreference = "No";
                }
                //Displaying Message box with the summary of the registration
                MessageBox.Show("REGISTRATION SUMMARY: \n\n" +
                    "Registration Date: " + datemaskedTextBox.Text + "\n"+
                    "Name: " + firstnametextBox.Text + " " + lastnametextBox.Text
                    + "\n" +
                    "Email Address: " + emailtextBox.Text + "\n" +
                    "Date of Birth: " + dobmaskedTextBox.Text + "\n" +
                    "Status:" + statuscomboBox.Text + "\n\n" +
                    "Classes Purchased: \n" + classList + "\n" +
                    "Total Classes:" + totalclassesamountLabel.Text + "\n" +
                    "Price Per Class: " + totalpriceamountLabel.Text + "\n\n" +
                    "Payment Type:" + PaymentType + "\n" +
                    "Email Receipt Requested: " + ReceiptPreference,
                    "Registration Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Try catch created for saving information to an external file
                try
                {
                    //Registration details being saved to file 
                    StreamWriter outputFile; // Declaring normal streamwrite for use in writing file
                    outputFile = File.AppendText("RegistrationData.txt"); // The output file its going to
                    outputFile.WriteLine("REGISTRATION SUMMARY: ");
                    outputFile.WriteLine("Registration Data:" + datemaskedTextBox.Text);
                    outputFile.WriteLine("Name:" + firstnametextBox.Text + " " + lastnametextBox.Text);
                    outputFile.WriteLine("Email Address" + emailtextBox.Text);
                    outputFile.WriteLine("Date of Birth" + dobmaskedTextBox.Text);
                    outputFile.WriteLine("Status:" + statuscomboBox.Text);
                    outputFile.WriteLine("Classes Purchased: \r\n" + classList);
                    outputFile.WriteLine("Total Classes:" + totalclassesamountLabel.Text);
                    outputFile.WriteLine("Price Per Class:" + priceperclassamountLabel.Text);
                    outputFile.WriteLine("Total Price:" + totalpriceamountLabel.Text);
                    outputFile.WriteLine("Payment Type:" + PaymentType);
                    outputFile.WriteLine("Email Receipt Requested:" + ReceiptPreference);

                    outputFile.WriteLine(); // Blank Line to seperate the orders in the file

                    outputFile.Close();// Closes the stream writer
                }
                catch (Exception ex)
                {
                    //Displaying message if errors occur when writing the file into the txt document
                    MessageBox.Show(ex.Message);
                }
                //Call custom method for resetting form to original state
                ResetForm();
            }                     
        }

        private void clearStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm(); // Custom method to reset form
        }
        //Exit menu click even instead of the normal exit button
        private void exitStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declaring variable to hold selections in the dialog box
            DialogResult selection;
            selection = MessageBox.Show("Are you sure you want to exit the client?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Appropriate action based on users selection
            if (selection == DialogResult.Yes)
            {
                this.Close(); // Closes the form
            }
        }

        private void aboutStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instance being created for the about information
            AboutForm myAboutForm = new AboutForm();

            //Displays the about form information
            myAboutForm.ShowDialog();
        }
        // Customer method for the populate list to pull the information from the files in debug folder
        private void PopulateList()
        {
            //Clearing current contents that are in the the list box
            classlistBox.Items.Clear();

            //statement created for input files so its readable
            try
            {
                StreamReader inputFile; // streamreader for reading files that are selected

                //Load events for selection of each of the following radio buttons
                if (liveradioButton.Checked) // Declaring if live action button selected . Information in accorandance with this button will show in list box
                {
                    inputFile = File.OpenText("LiveActionClasses.txt"); //Selection of file 
                    while (!inputFile.EndOfStream) // verification 
                    {
                        classlistBox.Items.Add(inputFile.ReadLine());
                    }
                    inputFile.Close(); // Closes input file
                }
                else
                {
                    inputFile = File.OpenText("AnimationClasses.txt"); //if live action not selected . goes to animation 
                    while (!inputFile.EndOfStream)
                    {
                        classlistBox.Items.Add(inputFile.ReadLine());
                    }
                }
                inputFile.Close();//Closes file after reading data
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }
        //Update totals custom method to display registration totals
        private void UpdateTotals()
        {
            numberofClasses = 0;// Starting value of number of classses selected
            TotalPrice = 0.00m; // starting value of total registration price            
            //price setting per class based on selection
            if (liveradioButton.Checked)
            {
                PricePerClass = LIVE_ACTION_CLASS_PRICE;
            }
            else
            {
                PricePerClass = ANIMATION_CLASS_PRICE;
            }
            //loop for all classes in list box when selected
            for (int counter = 0; counter < classlistBox.Items.Count; counter++)
            {
                // get selected format used again 
                if (classlistBox.GetSelected(counter))
                {
                    numberofClasses++; //Increments in a +1 format
                }
            }
            //Calculation total
            TotalPrice = numberofClasses * PricePerClass;

            //Updating display of totals on form
            totalclassesamountLabel.Text = numberofClasses.ToString();
            priceperclassamountLabel.Text = PricePerClass.ToString();
            totalpriceamountLabel.Text = TotalPrice.ToString();
        }
        //Custom method for clearing the form
        private void ResetForm()
        {
            datemaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
            firstnametextBox.Text = "";
            lastnametextBox.Text = "";
            emailtextBox.Text = "";
            dobmaskedTextBox.Text = "";
            statuscomboBox.Text = "";
            liveradioButton.Checked = true;
            classlistBox.ClearSelected(); // Clear list box
            cashradioButton.Checked = true;
            emailcheckBox.Checked = false;
            UpdateTotals(); // Call customer method to reset totals
            datemaskedTextBox.Focus(); // revert focus to first field
        }

    }
}
