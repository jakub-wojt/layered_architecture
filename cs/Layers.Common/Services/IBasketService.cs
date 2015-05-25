using Layers.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.Common.Services
{
    public interface IBasketService
    {
        void AddItemToBasket(int itemId, int quantity);
        void RemoveItemFromBasket(int basketItemId, int quantity);
        BasketDto GetBasket();
        void MakeOrder();
    }
}
