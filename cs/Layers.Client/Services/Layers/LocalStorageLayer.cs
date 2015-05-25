using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layers.Common.Services;
using Layers.Common.Services.Layers.Base;

namespace Layers.Client.Services.Layers
{
    public class LocalStorageLayer : ServicesLayer
    {
        public LocalStorageLayer(IServicesLayer decoratedLayer) : base(decoratedLayer)
        {

        }

        public override void ShowItem(int itemId)
        {
            base.ShowItem(itemId);
        }

        public override void HideItem(int itemId)
        {
            base.HideItem(itemId);
        }
    }
}
