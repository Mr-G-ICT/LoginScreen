using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LoginScreen___Game
{
    class ValidationRoutines
    {
       public static string GenerateSecurityCode()
        {
            /********************************************************
            /*Name: GenerateSecurityCode
            /*Description: generate a 6 digit security code
            /*Inputs: none
            /*OutputsP a string that contains the securty code. simple reason is it's easy to tack a number on a string and it 
            /* plus user will enter the string
            /*********************************************************/ 
            string SecurityCode = "code is";
            int GeneratedNum = 0;

            Random Dice = new Random();

            //generate a 6 digit unique code every time.
            for(int count = 0; count < 6; count++)
            {
                GeneratedNum = Dice.Next(0, 9);
                SecurityCode = SecurityCode + Convert.ToString(GeneratedNum);
            }

            return SecurityCode;
        }


        public static string encryptPassword(string Password)
        {
            /******************************************************
            /*name: Encrypt Password
            /* Description: After the user has had the password verified and validated, then encrypt it prior to inserting into the database
            /* Inputs : a password to be encrypted  
            /* Outputs: the encrypted password
            /********************************************************************/
            string encryptedPassword = "";
            int ASCIIValue;
            int KeyASCIIValue;
            const string KEY = "ABCDE";
            const int NUMKEY = 5;
            char[] CharKey = KEY.ToCharArray();
            int letterkey;
            int count = 0 ;

            //simple cypher with a AlphaKey, going to extend this to a greater key encryption later.
            foreach (char letter in Password.ToCharArray())
            {
                ASCIIValue = (int)letter;

                if (count < KEY.Length)
                { 
                letterkey = CharKey[count];
                    KeyASCIIValue = (int)letterkey;
                    KeyASCIIValue = KeyASCIIValue;
                    KeyASCIIValue = KeyASCIIValue % NUMKEY;

                    ASCIIValue = ASCIIValue + KeyASCIIValue;
                    count = count + 1;
                }
                else
                {
                    count = 0;
                }

                encryptedPassword = encryptedPassword + (char)ASCIIValue;    
            }
               




            return encryptedPassword;
        }

        public static string checkpassword(string Password) 
        {
            /******************************************************
            /*name: Check Password
            /* Description: check that the password meets complexityrequirements
            /* Inputs : a password to be checked for complexity 
            /* Outputs: the error message stating what is missing
            /********************************************************************/
            string response;
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";

            //start of with the error message, if it's found remove the error
            response = "password must contain at least 1 symbol";

            //roll through each of the special characters
            foreach (var symbol in specialChar)
            {
                if (Password.Contains(symbol))
                {
                    //remove the error message
                    response = "";
                    break;
                }
            }

            //using the passwords all command rather than regex as it's faster on CPU comparison
            if (!Password.All(char.IsLetter))
                {
                response = response + " letter";
            }
            //check that there is a digit in the password, if not then add the error to the code.
            if(!Password.All(char.IsDigit))
            {
                response = response + " and number";
            }

            return response;
        }


        public static void AvoidSequences()
        { 
/******************************************************
/*name: Avoid Sequences
/* Description: checks that a password does not have large sequences of characters the same and returns an error if they do
/* Inputs : a password to be checked  
/* Outputs: true/false depending on if the password is valid or not
/********************************************************************/



       
    }


        public static bool VerifyData(string data1, string data2)
        {
        /******************************************************/
        /*name: Verify Data
        /*Description: verifies if 2 pieces of data match, simple authenticaion
        /*Inputs : 2 strings
        /*Outputs: true/false depending on matching or not
        /* Possible improvements: could build in the trim function 
        /*********************************************************/    
            if (data1 == data2)
            {
                return true;
                
            }else
            {
                return false;
            }
        }

        public static bool VerifyEmail(string Email)
        {
            /******************************************************
            /*name: VerifyEmail
            /* Description: Checks to see if the entry of an email is in a valid order using a mask
            /* Inputs : an email to be checked
            /* Outputs: true/false depending on if the Email is valid or not
            /* 
            /*Improvements: could add an array with potential file extensions that would be valid for an email 
            /********************************************************************/

            int GetPositionOfAt = 0;
            int GetPositionOfDot = 0;
            bool validemail = false;

            GetPositionOfAt = Email.IndexOf("@");
            GetPositionOfDot = Email.LastIndexOf(".");

            //check it has all the valid email contents
            if ((GetPositionOfAt > 0) && (GetPositionOfDot > 0) && Email.Length > 0)
            {
                validemail = true;
            }
            if (GetPositionOfDot > GetPositionOfAt)
            {
                validemail = true;
            }



            return validemail;
        }

        


   public static string PreventInjection(string MySQLString)
       /*********************************************************************************
       /* name: PreventInjection
       /* routine to check for potential SQL injection, removing sequences before the SELECT, INSERT, DELETE statement*/
       /* Inputs: an string of SQL
       /* Outputs: a trimmed piece of SQL code
       /* 
       /* potential improvements: trim the end of the sentence the same way to remove the potential of crashes,
       /* need to check mid sentences as well, as once SELECT has been used, shouldn't again
       /****************************************************************************************************/
        {
           //trim off any leading spaces
            MySQLString.Trim();


            char letter = MySQLString[0];
            //check each of the initial letters all SQL should start with SELECT, INSERT, DELETE
            for (int count = 0; count < MySQLString.Length - 1; count++)
            {
                letter = MySQLString[count];
                if (letter != 'S' && letter != 'I' && letter != 'D')
                {
                   MySQLString =  MySQLString.TrimStart(letter);


                }
              
            }//endfor

            return MySQLString;
        }


    }
}
