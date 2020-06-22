using System;

namespace Arkanoid.Exceptions
{
    public class MaxCharactersException : Exception
    {
        public MaxCharactersException(string message) : base(message)
        {
        }
    }
}