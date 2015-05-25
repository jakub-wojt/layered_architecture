using System;
using System.Collections.Generic;
using Layers.Common.Dto;

namespace Layers.Common.Services.Layers.Base
{
    public class ServicesLayer : IServicesLayer
    {
        private readonly IServicesLayer _decoratedLayer;
        protected ServicesLayer(IServicesLayer decoratedLayer)
        {
            if(decoratedLayer == null)
                throw new ArgumentNullException("decoratedLayer");

            this._decoratedLayer = decoratedLayer;
        }

        public virtual void AddItemToBasket(int itemId, int quantity)
        {
            _decoratedLayer.AddItemToBasket(itemId, quantity);
        }

        public virtual void RemoveItemFromBasket(int basketItemId, int quantity)
        {
            _decoratedLayer.RemoveItemFromBasket(basketItemId, quantity);
        }

        public virtual BasketDto GetBasket()
        {
            return _decoratedLayer.GetBasket();
        }

        public virtual void MakeOrder()
        {
            _decoratedLayer.MakeOrder();
        }

        public virtual IEnumerable<ItemDto> GetItems(string query)
        {
            return _decoratedLayer.GetItems(query);
        }

        public virtual IEnumerable<OrderDto> GetOrders()
        {
            return _decoratedLayer.GetOrders();
        }

        public virtual ItemDto GetItem(int itemId)
        {
            return _decoratedLayer.GetItem(itemId);
        }

        public virtual void AddUser(string login, string password, string email)
        {
            _decoratedLayer.AddUser(login, password, email);
        }

        public virtual void RemoveUser(int id)
        {
            _decoratedLayer.RemoveUser(id);
        }

        public virtual void AssignRoles(int userId, int[] rolesIds)
        {
            _decoratedLayer.AssignRoles(userId, rolesIds);
        }

        public virtual void AddItem(ItemDto item)
        {
            _decoratedLayer.AddItem(item);
        }

        public virtual void EditItem(ItemDto item)
        {
            _decoratedLayer.EditItem(item);
        }

        public virtual void HideItem(int itemId)
        {
            _decoratedLayer.HideItem(itemId);
        }

        public virtual void ShowItem(int itemId)
        {
            _decoratedLayer.ShowItem(itemId);
        }
    }
}
