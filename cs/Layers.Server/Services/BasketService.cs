using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layers.Common.Dto;
using Layers.Common.Services;

namespace Layers.Server.Services
{
    public class BasketService : IBasketService
    {
        public void AddItemToBasket(int itemId, int quantity)
        {
            //bussines logic of AddItemToBasket
        }

        public void RemoveItemFromBasket(int basketItemId, int quantity)
        {
            //bussines logic of RemoveItemFromBasket
        }

        public BasketDto GetBasket()
        {
            //bussines logic of GetBasket

            return null;
        }

        public void MakeOrder()
        {
            //bussines logic of MakeOrder
        }
    }
}
