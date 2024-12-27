using System;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------Exception--------------------");

            //VoterIdValidate.CheckValid(17);

            //PasswordCheck.Password("dewfc");

            Calculate(0);
        }

        public static void Calculate(int num)
        {
            try
            {
                if (num <= 0)
                {
                    throw new ZeroNotAllowedException("number zero or less than zero is not allowed");
                }
                Console.WriteLine($"the square root of {num} is {Math.Sqrt(num)}");
            }
            catch(ZeroNotAllowedException e)
            {
                Console.WriteLine($"Excwption: {e.ToString()}");
            }
        }
    }
}
