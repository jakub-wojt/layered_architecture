package pl.jakubwojt.kontomierz.test.client;

import pl.jakubwojt.kontomierz.test.client.services.CachingLayer;
import pl.jakubwojt.kontomierz.test.client.services.TransportLayer;
import pl.jakubwojt.kontomierz.test.client.services.ValidationLayer;
import pl.jakubwojt.kontomierz.test.common.factory.ApplicationServiceFactory;
import pl.jakubwojt.kontomierz.test.common.services.layers.base.ApplicationService;

public class ClientServiceFactory implements ApplicationServiceFactory 
{
	public ApplicationService getApplicationService() {
		return new CachingLayer(new ValidationLayer(new TransportLayer()));
	}
}
