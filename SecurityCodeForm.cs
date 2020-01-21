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
    public partial class SecurityCodeForm : Form
    {
        public SecurityCodeForm(ProfileRoutines SetupUserProfile, string PassedSecurityCode)
        {
            InitializeComponent();
            SingleUserProfile = SetupUserProfile;
            Securitycode = PassedSecurityCode;
        }

        //globalvariables as i have to get the data from previous form.
        private ProfileRoutines SingleUserProfile = new ProfileRoutines();
        private string Securitycode;

        private void ConfirmSecurityCodeButton_Click(object sender, EventArgs e)
        {

            //remove this when fully tested
            MessageBox.Show(Securitycode);



            if (Securitycode == ConfirmSecurityTextBox.Text)
            {
                /* this links to the database connection and calls it object connection */
                DatabaseConnection objConnect;
                string ConnectionString;
                string MySQLString;

                objConnect = new DatabaseConnection();
                /*when you type default, look for the link to the database you have made*/
                ConnectionString = Properties.Settings.Default.UsersDBConnectionString;

                objConnect.connection_string = ConnectionString;

                //write code to get last userid and insert it into DB
                MySQLString = "INSERT INTO Users(Firstname, Username, UserPassword, Email) VALUES ('" + SingleUserProfile.GetFirstname + "' , '" + SingleUserProfile.GetUsername + "', ' " + SingleUserProfile.GetPW + "', ' " + SingleUserProfile.GetEmail + "')";

                objConnect.SQL = MySQLString;
                objConnect.SQL = objConnect.PreventInjection();

                MessageBox.Show(objConnect.InsertItem);

                //once they have entered the passcode, clear out the password value in their profile, security.
                SingleUserProfile.GetPW = "";


                this.Hide();
                SplashPage DisplaySplashForm = new SplashPage(SingleUserProfile);
                DisplaySplashForm.Show();

            }
            else
            {
                MessageBox.Show("please try again");

            }
        }
    }
}
