using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    internal class WeakPasswordException : Exception
    {

        public WeakPasswordException(string message) : base(message) { }

        public override string ToString()
        {
            return $"Custom Exception: {Message}";
        }
    }
}
