using System.Collections.Generic;
using System.Net;
using System.Net.Cache;
using Layers.Common.Dto;
using Layers.Common.Services;
using Layers.Common.Services.Layers.Base;

namespace Layers.Client.Services.Layers
{
    /// <summary>
    /// Class responsible for handling requests (reading socket, deserializing data, etc ...) and sending responses (data serialization, sending data to stream)
    /// </summary>
    public class TransportLayer : IServicesLayer
    {
        public TransportLayer()
        {
            //WFC, REST Webservice anything
        }

        public IEnumerable<ItemDto> GetItems(string query)
        {
            //create request
            //send request
            //return result
            return null;
        }

        public IEnumerable<OrderDto> GetOrders()
        {
            throw new System.NotImplementedException();
        }

        public ItemDto GetItem(int itemId)
        {
            HttpWebRequest getItemRequest = HttpWebRequest.CreateHttp("http://127.0.0.1");
            //request serialization
            //response deserialization
            return null;
        }

        //and so on, and so forth
        public void AddItemToBasket(int itemId, int quantity)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveItemFromBasket(int basketItemId, int quantity)
        {
            throw new System.NotImplementedException();
        }

        public BasketDto GetBasket()
        {
            throw new System.NotImplementedException();
        }

        public void MakeOrder()
        {
            throw new System.NotImplementedException();
        }

        public void AddUser(string login, string password, string email)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveUser(int id)
        {
            throw new System.NotImplementedException();
        }

        public void AssignRoles(int userId, int[] rolesIds)
        {
            throw new System.NotImplementedException();
        }

        public void AddItem(ItemDto item)
        {
            throw new System.NotImplementedException();
        }

        public void EditItem(ItemDto item)
        {
            throw new System.NotImplementedException();
        }

        public void HideItem(int itemId)
        {
            throw new System.NotImplementedException();
        }

        public void ShowItem(int itemId)
        {
            throw new System.NotImplementedException();
        }
    }
}
