using System;

namespace Arkanoid.Exceptions
{
    public class IdlePlayerException : Exception
    {
        public IdlePlayerException(string message) : base(message)
        {
        }
    }
}