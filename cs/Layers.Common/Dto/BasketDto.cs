using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.Common.Dto
{
    public class BasketDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public IEnumerable<BasketItemDto> Items { get; set; }
    }
}
