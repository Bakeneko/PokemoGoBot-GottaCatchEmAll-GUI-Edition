using System;

namespace RocketAPI.Exceptions
{
    [Serializable]
    public class GoogleException : Exception
    {
        public GoogleException(string message) : base(message)
        {
            
        }
    }
}
