using System;

namespace Arkanoid.Exceptions
{
    public class NotStartedException : Exception
    {
        public NotStartedException(string message) : base(message)
        {
        }
    }
}