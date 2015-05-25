using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Layers.Common.Dto
{
    public class ItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        decimal Price { get; set; }
    }
}
