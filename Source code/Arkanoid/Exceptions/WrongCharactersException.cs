using System;

namespace Arkanoid.Exceptions
{
    public class WrongCharactersException : Exception
    {
        public WrongCharactersException(string message) : base(message)
        {
        }
    }
}