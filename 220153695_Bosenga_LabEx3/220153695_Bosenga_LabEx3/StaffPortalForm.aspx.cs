using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using BusinessLayerClass;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _220153695_Bosenga_LabEx3
{
    public partial class StaffPortalForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        // Class of the business logic layer 
        BLL obj = new BLL();

        //button function that display the email address and the age of the staff member 
        protected void btnCreate(object sender, EventArgs e)
        {
            try
            {
                //check if the textbox is empty to ask the user to fill it before displaying address and age
                if (txtId.Text == "" || txtName.Text == ""|| txtSurname.Text == "" )
                {
                    string MessageBoxTitle = "UJ STAFF PORTAL";
                    string MessageBoxContent = "Please Fill Your Form";
                    MessageBox.Show(MessageBoxContent, MessageBoxTitle );
                    ClearEverything();
                }
                //if not empty then they can display
                else
                {
                    txtEmail.Text = obj.DisplayEmail(txtName.Text, txtSurname.Text);
                    txtAge.Text = obj.DisplayAge(txtId.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearEverything();

            }
        }
        //button function that save the IDNumber, the name, the surname, the email and the age to the database
        protected void btnSave(object sender, EventArgs e)
        {
            try
            {
                // check if the textbox is empty to ask the user to fill it before adding it to the database since we cannot add an empty record
                if (txtId.Text == "" || txtName.Text == "" || txtSurname.Text == "" || txtEmail.Text == "" || txtAge.Text == "")
                {
                    MessageBox.Show("Please Fill Your Form", "UJ STAFF PORTAL");
                    ClearEverything();
                }
                else
                {
                    obj.WriteToDatabase(txtId.Text, txtName.Text, txtSurname.Text, txtEmail.Text, txtAge.Text);
                    ClearEverything();
                    MessageBox.Show("Record Saved Succesfully", "UJ STAFF PORTAL");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearEverything();
            }
        }
        //button function that read or display all our data(inside the table) of the database in the listBox
        protected void btnRead(object sender, EventArgs e)
        {
            try
            {
                List<string> membersTable = obj.ReadFromDataBase();
                ListBox1.Items.Clear();
                foreach (var member in membersTable)
                {
                    ListBox1.Items.Add(member);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //button function to clear
        protected void btnClear(object sender, EventArgs e)
        {
            ClearEverything();

        }
        //A void function to clear everything so that I can use it in my clear button and my save button
        public void ClearEverything()
        {
            ListBox1.Items.Clear();
            txtId.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtEmail.Text = "";
            txtAge.Text = "";
        }
        // Function to exit or close the web application
        protected void btnExit(object sender, EventArgs e)
        {
            string MessageBoxTitle = "UJ STAFF PORTAL";
            string MessageBoxContent = "Sure, you wanna exit?";

            DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}