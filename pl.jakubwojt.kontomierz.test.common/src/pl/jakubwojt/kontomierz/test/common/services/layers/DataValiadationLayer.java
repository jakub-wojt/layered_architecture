package pl.jakubwojt.kontomierz.test.common.services.layers;

import pl.jakubwojt.kontomierz.test.common.dto.Item;
import pl.jakubwojt.kontomierz.test.common.exceptions.ShopException;
import pl.jakubwojt.kontomierz.test.common.services.layers.base.ApplicationService;
import pl.jakubwojt.kontomierz.test.common.services.layers.base.DecoratedApplicationService;


/**
 * @author Jakub Wojt
 * Common (for client & server) validation routines 
 */

public class DataValiadationLayer extends DecoratedApplicationService
{

	public DataValiadationLayer(ApplicationService decorated) {
		super(decorated);
	}
	
	@Override
	public void addItem(Item item) throws ShopException {
		if(item.getName() == null || item.getName().trim().length() == 0)
			throw new ItemValidationException("Item name cant be empty");
		else super.addItem(item);
	}
	

}
