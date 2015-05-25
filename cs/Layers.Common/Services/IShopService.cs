using Layers.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.Common.Services
{
    public interface IShopService
    {
        IEnumerable<ItemDto> GetItems(string query);
        IEnumerable<OrderDto> GetOrders();

        ItemDto GetItem(int itemId);
    }
}
