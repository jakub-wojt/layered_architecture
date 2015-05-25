using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layers.Common.Dto;

namespace Layers.Common.Services
{
    public interface IShopAdminService
    {
        void AddItem(ItemDto item);
        void EditItem(ItemDto item);
        void HideItem(int itemId);
        void ShowItem(int itemId);
    }
}
