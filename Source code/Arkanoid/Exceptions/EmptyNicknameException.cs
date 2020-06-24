using System;

namespace Arkanoid.Exceptions
{
    public class EmptyNicknameException : Exception
    {
        public EmptyNicknameException(string message) : base(message)
        {
        }
    }
}