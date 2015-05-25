using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Layers.Common.Dto;
using Layers.Common.Services;
using Layers.Common.Services.Layers.Base;

namespace Layers.Server.Services.Layers.Authorization
{
    /// <summary>
    /// Verifies if the user has required rights to call given function
    /// </summary>
    public class AuthorizationLayer: ServicesLayer
    {
        public AuthorizationLayer(IServicesLayer decoratedLayer) : base(decoratedLayer)
        {

        }


        public override void AddItem(ItemDto item)
        {
            var userRights = GetUserRights(Thread.CurrentPrincipal.Identity.Name);
            if (!userRights.Contains("AddItemToBasket"))
                throw new AuthorizationException("AddItemToBasket");
            base.AddItem(item);
        }

        public override void EditItem(ItemDto item)
        {
            var userRights = GetUserRights(Thread.CurrentPrincipal.Identity.Name);
            if (!userRights.Contains("EditItem"))
                throw new AuthorizationException("EditItem");
            base.EditItem(item);
        }

        public override void ShowItem(int itemId)
        {
            var userRights = GetUserRights(Thread.CurrentPrincipal.Identity.Name);
            if (!userRights.Contains("ShowItem"))
                throw new AuthorizationException("ShowItem");
            base.ShowItem(itemId);
        }

        public override void HideItem(int itemId)
        {
            var userRights = GetUserRights(Thread.CurrentPrincipal.Identity.Name);
            if (!userRights.Contains("ShowItem"))
                throw new AuthorizationException("ShowItem");
            base.HideItem(itemId);
        }

        public override void AddUser(string login, string password, string email)
        {
            var userRights = GetUserRights(Thread.CurrentPrincipal.Identity.Name);
            if (!userRights.Contains("AddUser"))
                throw new AuthorizationException("AddUser");

            base.AddUser(login, password, email);
        }

        public override void RemoveUser(int id)
        {
            var userRights = GetUserRights(Thread.CurrentPrincipal.Identity.Name);
            if (!userRights.Contains("RemoveUser"))
                throw new AuthorizationException("RemoveUser");

            base.RemoveUser(id);
        }


        private static IEnumerable<string> GetUserRights(string userName)
        {
            //implementation
            throw new NotImplementedException();
        }
    }
}
