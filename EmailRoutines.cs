﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace LoginScreen___Game
{
    class EmailRoutines
    {
        string UserEmail;
        private static string HTMLstring;

        public string GetUserEmail
        {
            set{
                UserEmail = value;
            }
        }

        //constructor for HTML string
        static EmailRoutines()
        {
                HTMLstring = "<FONT> welcome to my email </FONT>";   
        }


        public void sendConfirmationEmail()
        {
            /***************************************************************
            /* Name: sendConfirmationEmail
            /* Descritpion: sends an email.
            /* Inputs: the persons email
            /* Ouputs: a sent email and confirmation boolean
            /* 
            /* WARNING: may need to adjust security for your email to make the email send
            /* Further improvements: at the moment the email is blank, going to need to put this into a separate class to sort all of it out
            /****************************************************************/

            //replace this with the email you want to send it from. Obviously not using my own email address
            const string FROMMAILADDRESS = "putyouremailhere";
            const string WEBSITENAME = "test";
            const string PASSWORDFOREMAILACCOUNT = "putyourpassowrdhere";

            //the contents of the email, when i get around to populating it.
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress(FROMMAILADDRESS);
                message.To.Add(new MailAddress(UserEmail));

                message.Subject = "welcome to " + WEBSITENAME;
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = HTMLstring;

                //this port is the same for gmail, yahoo, outlook 
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host, easy to change  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(FROMMAILADDRESS, PASSWORDFOREMAILACCOUNT);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                //send the message
                smtp.Send(message);
            }
            catch (Exception) { };


        }

    }
}
