using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Validator
    {
        public bool HasCapitalLetter(string p_value)
        {
            if (p_value.Any(char.IsUpper))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasDigit(string p_value)
        {
            if (p_value.Any(char.IsDigit))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public bool HasLength(string p_value, int p_minimumLength, int p_maximumLength)
        {
            if (p_value.Length >= p_minimumLength && p_value.Length <= p_maximumLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasSmallLetter(string p_value)
        {
            if (p_value.Any(char.IsLower))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasSpecialCharacter(string p_value)
        {
            if (p_value.Any(char.IsSymbol) || p_value.Any(char.IsPunctuation))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsAlphabet(string p_value)
        {
            if (p_value.Any(char.IsNumber) || p_value.Any(char.IsSymbol) || p_value.Any(char.IsPunctuation))
            {
                return false;
            }
            else if (p_value.Any(char.IsLetter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsAlphaNumeric(string p_value)
        {
            if ( p_value.Any(char.IsSymbol) || p_value.Any(char.IsPunctuation))
            {
                return false;
            }
            else if (p_value.Any(char.IsLetterOrDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsEmailId(string p_value)
        {
            try
            {
                MailAddress email = new MailAddress(p_value);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public bool IsInteger(string p_value)
        {
            if (p_value.Any(char.IsLetter) || p_value.Any(char.IsSymbol) || p_value.Any(char.IsPunctuation))
            {
                return false;
            }
            else if (p_value.Any(char.IsNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsName(string p_value)
        {
            if (p_value.Any(char.IsNumber) || p_value.Any(char.IsSymbol) || p_value.Any(char.IsPunctuation))
            {
                return false;
            }
            else if (p_value.Any(char.IsLetter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNullOrEmpty(string p_value)
        {
            if (p_value.All(char.IsWhiteSpace) || p_value.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidateAge(DateTime p_dateOfBirth, int p_minimumAgeRequired)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            if (now.Year - p_dateOfBirth.Year >= p_minimumAgeRequired)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidateAge(DateTime p_dateOfBirth, int p_minimumAgeRequired, int p_maximumAgeAllowed)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            int yearDifference = now.Year - p_dateOfBirth.Year;
            if (yearDifference >= p_minimumAgeRequired && yearDifference <= p_maximumAgeAllowed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
