using System;

namespace Layers.Common.Services.Layers.Validation
{
    public class IncorrectPasswordException : Exception
    {
        public IncorrectPasswordException(string password)
        {
            throw new NotImplementedException();
        }
    }
}