package pl.jakubwojt.kontomierz.test.client.services;

import pl.jakubwojt.kontomierz.test.common.dto.Item;
import pl.jakubwojt.kontomierz.test.common.exceptions.ShopException;
import pl.jakubwojt.kontomierz.test.common.services.layers.DataValiadationLayer;
import pl.jakubwojt.kontomierz.test.common.services.layers.base.ApplicationService;



/**
 * @author Jakub Wojt
 * Validation on client side (only relevant methods should be overwritten)
 */


public class ValidationLayer extends DataValiadationLayer {

	public ValidationLayer(ApplicationService decorated) {
		super(decorated);
	}
	
	public void updateItem(Item item) throws ShopException 
	{
		//client validation routine
		super.updateItem(item);
	}

}
