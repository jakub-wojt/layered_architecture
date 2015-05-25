using System.Collections.Generic;
using Layers.Common.Dto;
using Layers.Common.Services;
using Layers.Common.Services.Layers.Base;

namespace Layers.Server.Services.Layers
{
    public class CachingLayer : ServicesLayer
    {
        private Dictionary<int, ItemDto> _itemsCache = new Dictionary<int, ItemDto>();

        public CachingLayer(IServicesLayer decoratedLayer) : base(decoratedLayer)
        {

        }

        public override void AddItem(ItemDto item)
        {
            base.AddItem(item);
            _itemsCache[item.Id] = item;
        }

        public override void EditItem(ItemDto item)
        {
            base.EditItem(item);
            _itemsCache[item.Id] = item;
        }

        public override ItemDto GetItem(int itemId)
        {
            ItemDto item;
            if (!_itemsCache.TryGetValue(itemId, out item))
                _itemsCache[itemId] = base.GetItem(itemId);

            return item;
        }
    }
}
