using System;
using System.Collections.Generic;
using System.Text;

namespace Day20_Ms_Test_UserRegistration
{
    public class Program
    {
        static Patterns patterns = new Patterns();
        public bool FirstNameInput(string fname)
        {
            
            {
                bool Status = patterns.validateName(fname);
                return Status;  
            }
        }
        public bool LastNameInput(string lname)
        {

            {
                bool Status = patterns.validateName(lname);
                return Status;
            }
        }
        public bool EmailInput(string email)
        {

            {
                bool Status = patterns.validateEmail(email);
                return Status;
            }
        }
        public bool MobileInput(string mobileNum)
        {

            {
                bool Status = patterns.validateMobileNum(mobileNum);
                return Status;
            }
        }
        public bool PasswordInput(string password)
        {

            {
                bool Status = patterns.validatePassword(password);
                return Status;
            }
        }




    }
}
