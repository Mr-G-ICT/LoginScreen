using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LoginScreen___Game
{
    class ValidationRoutines
    {
        string UserPassword;
        string UserEmail;
        string SecondPassword;
        
        //don't like calling this password and second password as it limits 
        //the potential use for the authenticaion of 2 piece of confirmation data
        public string GetPassword
        {
            set { UserPassword = value; }
        }

        public string GetSecondPassword
        {
            set { SecondPassword = value; }
        }

        public string GetEmail
        {
            set { UserEmail = value;  }
        }


       public string GenerateSecurityCode()
        {
            /********************************************************
            /*Name: GenerateSecurityCode
            /*Description: generate a 6 digit security code
            /*Inputs: none
            /*OutputsP a string that contains the securty code. simple reason is it's easy to tack a number on a string and it 
            /* plus user will enter the string
            /*********************************************************/ 
            string SecurityCode = "";
            int GeneratedNum = 0;
            const int NUMDIGITS = 7;

            Random Dice = new Random();

            //generate a 6 digit unique code every time.
            for(int count = 0; count < NUMDIGITS; count++)
            {
                GeneratedNum = Dice.Next(0, 9);
                SecurityCode = SecurityCode + Convert.ToString(GeneratedNum);
            }

            return SecurityCode;
        }

        public string GeneratePassword()
        {
            /**************************************************************/
            /* Name: GeneratePassword
            /* Description: Generates a randompassword based on criteria at top of page
            /* INputs: none
            /* Outputs: a new password string
            /*************************************************************/
            const int PASSWORDLENGTH = 15;
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            string newPassword = "";

            Random dice = new Random();


            for (int count = 1; count <= PASSWORDLENGTH; count++)
            {
                //goes from 1 - 5 because C# needs one more than the upper bound to recognise 4
                int diceRoll = dice.Next(1, 5);

                //work out what digit is to be generated
                switch (diceRoll)
                {
                    case (1):
                        //use ASCII to generate the uppercase letter
                        diceRoll = dice.Next(65, 91);
                        newPassword = newPassword + Convert.ToChar(diceRoll);
                        break;
                    case (2):
                        //use ASCII to generate the lowercase letter
                        diceRoll = dice.Next(97, 123);
                        newPassword = newPassword + Convert.ToChar(diceRoll);

                        break;
                    case (3):
                        //generate Num
                        diceRoll = dice.Next(0, 10);
                        newPassword = newPassword + Convert.ToString(diceRoll);
                        break;

                    case (4):
                        //generate Symbol
                        diceRoll = dice.Next(0, specialChar.Length);
                        newPassword = newPassword + specialChar[diceRoll];
                        break;

                }
            }
            return newPassword;
        }


        public string encryptPassword()
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
            foreach (char letter in UserPassword.ToCharArray())
            {
                ASCIIValue = (int)letter;

                if (count < KEY.Length)
                { 
                letterkey = CharKey[count];
                    KeyASCIIValue = (int)letterkey;
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

        public string checkpassword() 
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
                if (UserPassword.Contains(symbol))
                {
                    //remove the error message
                    response = "";
                    break;
                }
            }

            //using the passwords all command rather than regex as it's faster on CPU comparison
            if (UserPassword.All(char.IsLetter))
                {
                response = response + " letter";
            }
            //check that there is a digit in the password, if not then add the error to the code.
            if(UserPassword.All(char.IsDigit))
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


        public bool VerifyData()
        {
        /******************************************************/
        /*name: Verify Data
        /*Description: verifies if 2 pieces of data match, simple authenticaion
        /*Inputs : 2 strings
        /*Outputs: true/false depending on matching or not
        /* Possible improvements: could build in the trim function 
        /*********************************************************/    
            if (SecondPassword == UserPassword)
            {
                return true;
                
            }else
            {
                return false;
            }
        }

        public bool VerifyEmail()
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

            GetPositionOfAt = UserEmail.IndexOf('@');
            GetPositionOfDot = UserEmail.LastIndexOf('.');
            //check it has all the valid email contents
            
           if ((GetPositionOfAt > 0) && (GetPositionOfDot > 0) && (UserEmail.Length > 0))
            {
                validemail = true;
            }
           if (GetPositionOfDot < GetPositionOfAt)
            {
                validemail = true;
            }



            return validemail;
        }

        




    }
}
