using Layers.Client.Services.Layers;
using Layers.Common.Factory;
using Layers.Common.Services;
using Layers.Common.Services.Layers.Logging;
using Layers.Common.Services.Layers.Validation;

namespace Layers.Client
{
    public class ClientServiceFactory: IServiceFactory
    {
        private static readonly IServicesLayer ApplicationStack;
        private static readonly ILoggingLayer LoggingLayer;
        static ClientServiceFactory()
        {
            var tmpAppStack  =  new ValidationLayer(new LocalStorageLayer(new TransportLayer()));
            ApplicationStack = (IServicesLayer) (LoggingLayer = new LoggingLayer(tmpAppStack));
        }

        public IBasketService GetBasketService()
        {
            return ApplicationStack;
        }

        public IShopService GetShopService()
        {
            return ApplicationStack;
        }

        public IShopAdminService GetShopAdminService()
        {
            return ApplicationStack;
        }

        public IUserService GetUserService()
        {
            return ApplicationStack;
        }

        public ILoggingLayer GetLoggingLayer()
        {
            return LoggingLayer;
        }

    }
}
