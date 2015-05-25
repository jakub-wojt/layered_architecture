using System;
using Layers.Common.Dto;

namespace Layers.Common.Services.Layers.Validation
{
    public class IncorrectItemException : Exception
    {
        public IncorrectItemException(ItemDto item)
        {
            throw new NotImplementedException();
        }
    }
}