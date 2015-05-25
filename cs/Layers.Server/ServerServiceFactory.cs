using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layers.Common.Factory;
using Layers.Common.Services;
using Layers.Common.Services.Layers.Logging;
using Layers.Common.Services.Layers.Validation;
using Layers.Server.Services.Layers;
using Layers.Server.Services.Layers.Authorization;
using Layers.Server.Services.Layers.Transport;

namespace Layers.Server.Services
{
    public class ServerServiceFactory: IServiceFactory
    {

        private static readonly ILoggingLayer LoggingLayer;
        private static readonly ITransportLayer TransportLayer;
        private static readonly IServicesLayer ApplicationStack ;
        static ServerServiceFactory()
        {
            ApplicationStack = (IServicesLayer) 
                (TransportLayer = new TransportLayer( (IServicesLayer) 
                    (LoggingLayer = new LoggingLayer(
                        new NotificationLayer(
                            new AuthorizationLayer(
                                new ValidationLayer(
                                new CachingLayer(
                                    new DispatcherLayer(new ShopAdminService(), new BasketService(), new ShopService(), new UserService())))))))));
        }

        public ITransportLayer GetTransportLayer()
        {
            return TransportLayer;
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
