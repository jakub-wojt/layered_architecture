using System;

namespace Layers.Common.Services.Layers.Validation
{
    public class IncorrectLoginException : Exception
    {
        public IncorrectLoginException(string login)
        {
            throw new NotImplementedException();
        }
    }
}