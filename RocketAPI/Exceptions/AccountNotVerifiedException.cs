using System;

namespace RocketAPI.Exceptions
{
    [Serializable]
    public class AccountNotVerifiedException : Exception
    {
        public AccountNotVerifiedException(string message) : base(message)
        {
            
        }
    }
}