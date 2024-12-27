using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    internal class ZeroNotAllowedException : Exception
    {

        public ZeroNotAllowedException(string message) : base(message) { }

        public override string ToString()
        {
            return $"{Message}";
        }

    }
}
