using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace _04.Passord_Validator;
class Program
{
    static void Main(string[] args)
    {
        //        Create a program that checks if a given password is valid.
        //The password validation rules are:
        //	•	It should contain 6 – 10 characters(inclusive)
        //	•	It should contain only letters and digits
        //	•	It should contain at least 2 digits
        //
        //If it is not valid, for any unfulfilled rule print the corresponding message:
        //	•	"Password must be between 6 and 10 characters"
        //	•	"Password must consist only of letters and digits"
        //	•	"Password must have at least 2 digits"

        string password = Console.ReadLine();

        bool isLenghtValid = IsPasswordLenghtValid(password);
        bool isHavingDigAndLetters = IsPassowrdContaingDigAndLettValid(password);
        bool isHavingTwoDigits = DoesPassowrContaintsTwoDigits(password);

        if(!isLenghtValid)
        {
            Console.WriteLine("Password must be between 6 and 10 characters");
        }
          if(!isHavingDigAndLetters)
        {
            Console.WriteLine("Password must consist only of letters and digits");
        }
        if(!isHavingTwoDigits)
        {
            Console.WriteLine("Password must have at least 2 digits");
        }
        if(isLenghtValid && isHavingTwoDigits && isHavingDigAndLetters)
        {
            Console.WriteLine("Password is valid");
        }

    } 

        static bool IsPasswordLenghtValid(string password)
        {
            bool isValid = password.Length >= 6 && password.Length <= 10;
            return isValid;
        }

        static bool IsPassowrdContaingDigAndLettValid(string password)
        {
            foreach(char character in password)
            {
                if(!char.IsLetterOrDigit(character))
                {
                    return false;
                }

                
            }
            return true;
        }

        static bool DoesPassowrContaintsTwoDigits(string password)
        {
            int digitsCount = 0;

            foreach(char ch in password)
            {
                if(char.IsDigit(ch))
                {
                    digitsCount++;
                }
            }
            return digitsCount >= 2;
        }





    
}

