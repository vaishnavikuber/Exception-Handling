using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    internal class AgeInvalidException: Exception

    {


        public AgeInvalidException(string message) : base(message) { }

        public override string ToString()
        {
            return $"Custom Exception: {Message}";
        }



    }
}
