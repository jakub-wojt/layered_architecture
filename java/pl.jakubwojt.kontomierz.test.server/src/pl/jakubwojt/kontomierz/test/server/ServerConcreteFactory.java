package pl.jakubwojt.kontomierz.test.server;

import pl.jakubwojt.kontomierz.test.common.factory.ApplicationServiceFactory;
import pl.jakubwojt.kontomierz.test.common.services.layers.base.ApplicationService;
import pl.jakubwojt.kontomierz.test.server.dao.GlobalDAO;
import pl.jakubwojt.kontomierz.test.server.services.BasketServerService;
import pl.jakubwojt.kontomierz.test.server.services.ShopServerService;
import pl.jakubwojt.kontomierz.test.server.services.SystemServerService;
import pl.jakubwojt.kontomierz.test.server.services.layers.DispatcherLayer;
import pl.jakubwojt.kontomierz.test.server.services.layers.TransportLayer;


/**
 * @author Jakub Wojt
 * Dependency injection container would be much better than this
 *  
 */
public class ServerConcreteFactory implements ApplicationServiceFactory 
{

	@Override
	public ApplicationService getApplicationService() 
	{
		GlobalDAO dao = new GlobalDAO();
		
		return new TransportLayer(
				new DispatcherLayer(
						new BasketServerService(dao), 
						new ShopServerService(dao), 
						new SystemServerService(dao)));
	}

}
