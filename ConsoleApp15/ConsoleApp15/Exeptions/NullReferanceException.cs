using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15.Exeptions
{
    internal class Exeption
    {
        public class NullReferanceException : ApplicationException
        {
            public NullReferanceException(string message) : base(message)
            {

            }
        }
    }
}
