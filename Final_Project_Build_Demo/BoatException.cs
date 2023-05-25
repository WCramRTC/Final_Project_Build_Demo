using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Build_Demo
{
    internal class BoatException : Exception
    {
        public BoatException(string? message) : base(message)
        {
        }

        public BoatException()
        {

        }
    }
}
