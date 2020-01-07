﻿using System;
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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void SigninButton_Click(object sender, EventArgs e)
        {
            /* this links to the database connection and calls it object connection */
            DatabaseConnection objConnect;

            DataSet mydataset;
            DataRow RecordFromADatabase;

            try
            {
                string ConnectionString;
                string MySQLString;
                int MaxRows = 0;
                int Counter = 0;

                // doing this for simplicity and portability, if i need to change text box, the rest will still work
                string Username = UsernameTextBox.Text;
                string Password = PasswordTextBox.Text;


                objConnect = new DatabaseConnection();
                /*when you type default, look for the link to the database you have made*/
                ConnectionString = Properties.Settings.Default.UsersDBConnectionString;

                objConnect.connection_string = ConnectionString;


                MySQLString = "(((SELECT UserID, Firstname, Email FROM Users WHERE Users.Username = '" + Username + "' AND Users.Password = '" + Password + "'";


                objConnect.SQL = ValidationRoutines.PreventInjection(MySQLString);




                mydataset = objConnect.GetConnection;

                //if the record is found, get the data from the database that has been retrieved.
                MaxRows = mydataset.Tables[0].Rows.Count;
                if (MaxRows > 0)
                {
                    //this pulls out username firstname from the database, could pull more if necessary. 

                    //IMPROVEMENT make sure this is stored in a collection/userclass for future use.
                    RecordFromADatabase = mydataset.Tables[0].Rows[Counter];
                    string userIDfromdatabase = RecordFromADatabase.ItemArray.GetValue(0).ToString();
                    string Firstnammefromdatabase = RecordFromADatabase.ItemArray.GetValue(1).ToString();
                    MessageBox.Show(Firstnammefromdatabase + userIDfromdatabase);
                    this.Hide();
                    CharacterForm DisplayCharForm = new CharacterForm();
                    DisplayCharForm.Show();
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

        }

        private void NewUserButton_Click(object sender, EventArgs e)
        {
            SignupGroup.Show();

        }

        private void SignUpFinalButton_Click(object sender, EventArgs e)
        {
            string valueinTextbox;
            string errormessage = "";

            string encryptedpassword = ValidationRoutines.encryptPassword(PasswordTextBox.Text);
            MessageBox.Show(encryptedpassword);

            /* this links to the database connection and calls it object connection */
            DatabaseConnection objConnect;
            string ConnectionString;
            string MySQLString;

            //TODO change this into a function? can i send controls to a function

            //check each of the entries in the group boxes for a value
            foreach (Control control in this.LoginGroup.Controls)
            {
                if (control is TextBox)
                {
                    valueinTextbox = control.Text;
                    if (valueinTextbox == "")
                    {
                        string textboxname = control.Name.Replace("textBox", "");
                        errormessage = errormessage + textboxname + "is missing a value, please try again";
                    }

                }
            }


            // check each of the entries in the signup boxes for a value
            foreach (Control control in this.SignupGroup.Controls)
            {
                if (control is TextBox)
                {
                    valueinTextbox = control.Text;
                    if (valueinTextbox == "")
                    {
                        string textboxname = control.Name.Replace("textBox", "");
                        errormessage = errormessage + textboxname + " is missing a value, please try again\n";
                    }

                }
            }

            // verify password
            if (!ValidationRoutines.VerifyData(PasswordTextBox.Text, ConfirmPasswordTextBox.Text))
            {
                errormessage = errormessage + "\n passwords do not match";
            }
            else
            {
                errormessage = errormessage + ValidationRoutines.checkpassword(PasswordTextBox.Text);
            }

            //call validation routine to check an email.
            if(ValidationRoutines.VerifyEmail(EmailTextBox.Text))
            {
               errormessage = errormessage + "\n email is not valid";
            }

          

            //final check to display the message onto the screen
            if (errormessage != "")
            {
                ErrorLabel.Text = "ERROR \n\n" + errormessage;
            }
            else if (errormessage == "")
            {
                MessageBox.Show("no errors add to database");


                objConnect = new DatabaseConnection();
                /*when you type default, look for the link to the database you have made*/
                ConnectionString = Properties.Settings.Default.UsersDBConnectionString;

                objConnect.connection_string = ConnectionString;

                //Build function, encrypt password


                //write code to get last userid and insert it into DB
            //NOT YET FINISHED
                    MySQLString = "INSERT INTO Users(Firstname, Username, UserPassword) VALUES ('" + FirstNameTextbox.Text + "' , '" + UsernameTextBox.Text + "', 'password')";


                    objConnect.SQL = ValidationRoutines.PreventInjection(MySQLString);

                    MessageBox.Show(objConnect.InsertItem);
            }

        }

    }
}