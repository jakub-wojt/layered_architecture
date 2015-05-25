using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Layers.Common.Dto
{
    public class BasketItemDto
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
