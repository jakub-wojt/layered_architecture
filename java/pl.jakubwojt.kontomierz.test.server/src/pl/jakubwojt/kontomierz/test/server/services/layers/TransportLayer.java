package pl.jakubwojt.kontomierz.test.server.services.layers;

import pl.jakubwojt.kontomierz.test.common.services.layers.base.ApplicationService;
import pl.jakubwojt.kontomierz.test.common.services.layers.base.DecoratedApplicationService;


/**
 * @author Jakub Wojt
 * This layer can be responsible for starting HttpServer, handling requests / responses / http errors
 */

public class TransportLayer extends DecoratedApplicationService{

	public TransportLayer(ApplicationService decorated) 
	{
		super(decorated);
	}

}
