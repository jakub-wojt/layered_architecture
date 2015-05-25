using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layers.Common.Dto;
using Layers.Common.Services;
using Layers.Common.Services.Layers.Base;

namespace Layers.Server.Services.Layers
{
    public class NotificationLayer : ServicesLayer
    {
        public NotificationLayer(IServicesLayer decoratedLayer) : base(decoratedLayer)
        {

        }

        public override void AddItem(ItemDto item)
        {
            base.AddItem(item);
            Notify();
        }

        public override void EditItem(ItemDto item)
        {
            base.EditItem(item);
            Notify();
        }

        public override void MakeOrder()
        {
            base.MakeOrder();
            Notify();
        }

        private static void Notify()
        {
            //NotoficationLogic
        }
    }
}
