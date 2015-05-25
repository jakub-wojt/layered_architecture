using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layers.Common.Dto;
using Layers.Common.Services;

namespace Layers.Server.Services
{
    public class ShopService : IShopService
    {
        public IEnumerable<ItemDto> GetItems(string query)
        {
            //implementation of business logic
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDto> GetOrders()
        {
            //implementation of business logic
            throw new NotImplementedException();
        }

        public ItemDto GetItem(int itemId)
        {
            //implementation of business logic
            throw new NotImplementedException();
        }
    }
}
