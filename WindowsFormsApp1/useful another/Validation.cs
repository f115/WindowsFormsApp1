using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysecondFormsApp1
{
    public static class Validation
    {
        public static bool Validate(params string[] txbxs)
        {
            
            foreach (string txbx in txbxs)
            {
                if (!string.IsNullOrEmpty(txbx))
                {
                    throw new ArgumentNullException();
                }

            }
            return valid;
        }
        public static sbyte IsAgeValueValid(sbyte age, sbyte limit)
        {
            if (string.IsNullOrEmpty(age))
                throw new ArgumentNullException("age field is empty");
            if (!sbyte.TryParse(age, out sbyte result))
                throw new FormatExeption("age isn't valid");
            if (sbyte.Parse(age) < limit)
                throw new InvalidAgeValueException("age is less than 0 , please enter valid age");
            return result;
        }

        public static bool IsEmailValid(string email)
        {
            if (email.Contains"@")){
                return true;
            }


            else return false;

        }

        public static bool IsPasswordValid(string password)
        {
            if (password.Length >= 4 ){
                return true;
            }


            else return false;

        }
    }
}
