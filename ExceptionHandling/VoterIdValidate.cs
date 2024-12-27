using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    internal class VoterIdValidate
    {

        public static void CheckValid(int age)
        {
            try
            {
                if (age < 18)
                {
                    throw new AgeInvalidException("You are not eligible to vote");
                }
                Console.WriteLine("You are eligible to vote");
            }
            catch(AgeInvalidException e)
            {
                Console.WriteLine($" {e.ToString()}");
            }
        }
    }
}
