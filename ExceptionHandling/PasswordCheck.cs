using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    internal class PasswordCheck
    {

        public static void Password(string password)
        {
            try
            {
                if (password.Length < 8)
                {
                    throw new WeakPasswordException("password should have least 8 characters");
                }

                Console.WriteLine("Password is strong");
            }
            catch(WeakPasswordException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        

    }
}
