using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen___Game
{
    public partial class LoginForm : Form
    {
        //set up the name of the project will read "welcome to, projectname"
        const string PROJECTNAME = "MRGLOGIN";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void SigninButton_Click(object sender, EventArgs e)
        {
            
           try
            {
                /*when you type default, look for the link to the database you have made*/
                string ConnectionString = Properties.Settings.Default.UsersDBConnectionString; 
                string MySQLString;
                int MaxRows = 0;
                int Counter = 0;

                /* this links to the database connection and calls it object connection */
                DatabaseConnection objConnect = new DatabaseConnection();
                DataSet mydataset;
                DataRow RecordFromADatabase;

                objConnect.connection_string = ConnectionString;


                //to do, test this validation routine for encryptedpassword
                ValidationRoutines CheckDataEntry = new ValidationRoutines();
                CheckDataEntry.GetPassword = PasswordTextBox.Text;
                MySQLString = "(((SELECT UserID, Firstname, Email FROM Users WHERE Username = '" + UsernameTextBox.Text + "' AND UserPassword = '" + CheckDataEntry.encryptPassword() + "'";

                objConnect.SQL = MySQLString;
                objConnect.SQL = objConnect.PreventInjection();

                mydataset = objConnect.GetConnection;

                //if the record is found, get the data from the database that has been retrieved.
                MaxRows = mydataset.Tables[0].Rows.Count;
                if (MaxRows > 0)
                {
                    //this pulls out username firstname from the database, could pull more if necessary.  
                    RecordFromADatabase = mydataset.Tables[0].Rows[Counter];

                    ProfileRoutines setupUserProfile = new ProfileRoutines();
                    setupUserProfile.GetUserID = int.Parse(RecordFromADatabase.ItemArray.GetValue(0).ToString());
                    setupUserProfile.GetFirstname = RecordFromADatabase.ItemArray.GetValue(1).ToString();
                    setupUserProfile.GetUsername = UsernameTextBox.Text;
                    setupUserProfile.GetEmail = EmailTextBox.Text;

                    this.Hide();
                    SplashPage DisplaySplashForm = new SplashPage(setupUserProfile);
                    DisplaySplashForm.Show();

                }
                else
                {
                    //password error message
                    ErrorLabel.ForeColor = System.Drawing.Color.Red;
                    ErrorLabel.Text = "Invalid Username/Password Combination, please try again";
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            SignupGroup.Hide();
            //i like century gothic, change font face and size to suit
            ProjectNameLabel.Font = new Font("Century Gothic", 18);
                
            ProjectNameLabel.Text = ProjectNameLabel.Text + PROJECTNAME;
            PasswordTextBox.PasswordChar = '*';
            ConfirmPasswordTextBox.PasswordChar = '*';
        }

        private void NewUserButton_Click(object sender, EventArgs e)
        {
            SignupGroup.Show();

        }

        private void SignUpFinalButton_Click(object sender, EventArgs e)
        {
            string errormessage = "";

            //TODO change this into a function? can i send controls to a function

            //check each of the entries in the group boxes for a value
            foreach (Control control in this.LoginGroup.Controls)
            {
                if (control is TextBox)
                {
                    //check each of the items in the group to see if any of the information is blank
                    if (control.Text == "")
                    {
                        //remove the word textbox from the name of the box, so it writes the error correctly
                        string textboxname = control.Name.Replace("TextBox", " ");
                        errormessage = errormessage + textboxname + "is missing a value, please try again";
                    }
                    errormessage = errormessage + "\n\n";
                }
            }


            // check each of the entries in the signup boxes for a value, have to do 2 of these because there are 2 groups of entry
            foreach (Control control in this.SignupGroup.Controls)
            {
                if (control is TextBox)
                {
                  //check if any of the information in this group of boxes is blank
                    if (control.Text == "")
                    {
                        //remove the word textbox from the name of the box, so it writes the error correctly
                        string textboxname = control.Name.Replace("textBox", "");
                        errormessage = errormessage + textboxname + " is missing a value, please try again";
                    }
                    //add this every time so errors appear in line
                    errormessage = errormessage + "\n\n";

                }
            }

            //set up the class for the validationroutines
            ValidationRoutines CheckDataEntry = new ValidationRoutines();
            //Build function, encrypt password
            CheckDataEntry.GetPassword = PasswordTextBox.Text;
            CheckDataEntry.GetSecondPassword = ConfirmPasswordTextBox.Text;
            CheckDataEntry.GetEmail = EmailTextBox.Text;

            // verify password
            if (!CheckDataEntry.VerifyData())
            {
                errormessage = errormessage + "\n passwords do not match";
            }
            else
            {
                errormessage = errormessage + CheckDataEntry.checkpassword();
            }

            //call validation routine to check an email.
            if(!CheckDataEntry.VerifyEmail())
            {
               errormessage = errormessage + "\n email is not valid";
            }

            //strip out the layout spaces
            errormessage = errormessage.Replace("\n", "");
            //final check to display the message onto the screen
            if (errormessage != "")
            {
                ErrorLabel.Font = new Font("Century Gothic", 11);
                ErrorLabel.ForeColor = System.Drawing.Color.Red;
                ErrorLabel.Text =  errormessage;
            }
            
            else if (errormessage == "")
            {


                //Generate the security code
                string securitycode = "";
                securitycode = ValidationRoutines.GenerateSecurityCode();

                //not sure if this is agood idea, need to think of the user, but there are a lot of text boxes....may have to go back to layout

                //send the confirmation email
                EmailRoutines sendConfirmEmail = new EmailRoutines();
                sendConfirmEmail.SetWebsiteName = PROJECTNAME;
                sendConfirmEmail.GetUserEmail = EmailTextBox.Text;
                //put the signin code into their email 
                sendConfirmEmail.addtoHTML = "<p>your signin code is " + securitycode + "</p>";
                sendConfirmEmail.sendConfirmationEmail();


                //this will all move to the new form, once i've made it.
                string passwordtoinsert = CheckDataEntry.encryptPassword();

                ProfileRoutines setupUserProfile = new ProfileRoutines();
                setupUserProfile.GetUsername = UsernameTextBox.Text;
                setupUserProfile.GetEmail = EmailTextBox.Text;
                setupUserProfile.GetFirstname = FirstNameTextbox.Text;
                setupUserProfile.GetPW = passwordtoinsert;

                this.Hide();
                SecurityCodeForm DisplaySecurityForm = new SecurityCodeForm(setupUserProfile, securitycode);
                DisplaySecurityForm.Show();

            }

        }

    }
}
