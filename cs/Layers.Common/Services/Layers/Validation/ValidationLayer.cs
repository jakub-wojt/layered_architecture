using System.Collections.Generic;
using Layers.Common.Dto;
using Layers.Common.Services.Layers.Base;

namespace Layers.Common.Services.Layers.Validation
{
    public class ValidationLayer : ServicesLayer
    {
        public ValidationLayer(IServicesLayer decoratedLayer) : base(decoratedLayer)
        {
        }

        public override void AddUser(string login, string password, string email)
        {
            if (!IsCorrectLogin(login))
                throw new IncorrectLoginException(login);

            if (!IsCorrectPassword(password))
                throw new IncorrectPasswordException(password);
            base.AddUser(login, password, email);
        }

        public override IEnumerable<ItemDto> GetItems(string query)
        {
            if (!IsCorrectQuery(query))
                throw new IncorrectQueryException(query);

            return base.GetItems(query);
        }

        public override void EditItem(ItemDto item)
        {
            if (!IsCorrectItem(item))
                throw new IncorrectItemException(item);

            base.EditItem(item);
        }

        public override void AddItem(ItemDto item)
        {
            if (!IsCorrectItem(item))
                throw new IncorrectItemException(item);

            base.AddItem(item);
        }

        private static bool IsCorrectItem(ItemDto item)
        {
            throw new System.NotImplementedException();
        }

        private static bool IsCorrectPassword(string password)
        {
            //implementation
            return true;
        }

        private static bool IsCorrectLogin(string login)
        {
            //implementation
            return true;
        }

        private static bool IsCorrectQuery(string query)
        {
            //implementation
            return true;
        }
    }
}