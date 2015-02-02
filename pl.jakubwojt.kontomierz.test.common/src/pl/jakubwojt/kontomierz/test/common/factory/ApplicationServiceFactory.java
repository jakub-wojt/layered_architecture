package pl.jakubwojt.kontomierz.test.common.factory;

import pl.jakubwojt.kontomierz.test.common.services.layers.base.ApplicationService;

public interface ApplicationServiceFactory 
{
	public ApplicationService getApplicationService();
}
