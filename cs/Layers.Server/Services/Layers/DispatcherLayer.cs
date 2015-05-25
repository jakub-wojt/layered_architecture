using System.Collections.Generic;
using Layers.Common.Dto;
using Layers.Common.Services;

namespace Layers.Server.Services.Layers
{
    public class DispatcherLayer : IServicesLayer
    {
        private readonly IShopAdminService _shopAdminService;
        private readonly IBasketService _basketService;
        private readonly IShopService _shopService;
        private readonly IUserService _userService;

        public DispatcherLayer(IShopAdminService shopAdminService, IBasketService basketService, IShopService shopService, IUserService userService)
        {
            _shopAdminService = shopAdminService;
            _basketService = basketService;
            _shopService = shopService;
            _userService = userService;
        }

        public void AddItem(ItemDto item)
        {
            _shopAdminService.AddItem(item);
        }

        public void EditItem(ItemDto item)
        {
            _shopAdminService.EditItem(item);
        }

        public void HideItem(int itemId)
        {
            _shopAdminService.HideItem(itemId);
        }

        public void ShowItem(int itemId)
        {
            _shopAdminService.ShowItem(itemId);
        }

        public void AddItemToBasket(int itemId, int quantity)
        {
            _basketService.AddItemToBasket(itemId, quantity);
        }

        public void RemoveItemFromBasket(int basketItemId, int quantity)
        {
            _basketService.RemoveItemFromBasket(basketItemId, quantity);
        }

        public BasketDto GetBasket()
        {
            return _basketService.GetBasket();
        }

        public void MakeOrder()
        {
            _basketService.MakeOrder();
        }

        public IEnumerable<ItemDto> GetItems(string query)
        {
            return _shopService.GetItems(query);
        }

        public IEnumerable<OrderDto> GetOrders()
        {
            return _shopService.GetOrders();
        }

        public ItemDto GetItem(int itemId)
        {
            return _shopService.GetItem(itemId);
        }

        public void AddUser(string login, string password, string email)
        {
            _userService.AddUser(login, password, email);
        }

        public void RemoveUser(int id)
        {
            _userService.RemoveUser(id);
        }

        public void AssignRoles(int userId, int[] rolesIds)
        {
            _userService.AssignRoles(userId, rolesIds);
        }
    }
}
