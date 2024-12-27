using System;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------Exception--------------------");

            //VoterIdValidate.CheckValid(17);

            PasswordCheck.Password("dewfc");
        }
    }
}
