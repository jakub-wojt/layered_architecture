using Layers.Common.Services;

namespace Layers.Common.Factory
{
    public interface IServiceFactory
    {
        IBasketService GetBasketService();
        IShopService GetShopService();
        IShopAdminService GetShopAdminService();
        IUserService GetUserService();
    }
}
