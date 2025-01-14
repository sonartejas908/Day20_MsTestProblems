﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day20_Ms_Test_UserRegistration
{
   public  class Patterns
    {
        public string Regex_Name = "^[A-Z][a-z]{2,}$";

        public bool validateName(string name)
        {
            return Regex.IsMatch(name, Regex_Name);
        }

        public string Regex_Email = "^[a-zA-Z0-9]+([_+-.][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, Regex_Email);
        }

        public string Regex_MobileNum = "^([0-9]{2}[ ])?[0-9]{10}$";
        public bool validateMobileNum(string MobileNum)
        {
            return Regex.IsMatch(MobileNum, Regex_MobileNum);
        }

        public string Regex_Password = "((?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{8,})";
        public bool validatePassword(string Password)
        {
            return Regex.IsMatch(Password, Regex_Password);
        }
    }
}
