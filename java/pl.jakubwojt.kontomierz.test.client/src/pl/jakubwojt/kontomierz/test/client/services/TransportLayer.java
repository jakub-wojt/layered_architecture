package pl.jakubwojt.kontomierz.test.client.services;

import java.util.Collection;
import java.util.Map;

import pl.jakubwojt.kontomierz.test.common.dto.BasketItem;
import pl.jakubwojt.kontomierz.test.common.dto.Item;
import pl.jakubwojt.kontomierz.test.common.dto.ItemDetails;
import pl.jakubwojt.kontomierz.test.common.enums.SystemDictionary;
import pl.jakubwojt.kontomierz.test.common.exceptions.BasketException;
import pl.jakubwojt.kontomierz.test.common.exceptions.ShopException;
import pl.jakubwojt.kontomierz.test.common.exceptions.SystemException;
import pl.jakubwojt.kontomierz.test.common.services.layers.base.ApplicationService;



/**
 * @author Jakub Wojt
 * Opening opening http connections, serialization requests / deserialization of responses (including exceptions), handling http errors. 
 */


public class TransportLayer implements ApplicationService 
{

	public TransportLayer() {
		
	}

	public void addBasketItem(BasketItem item) throws BasketException {
		 // opening http connection, request serialization, sending / handling responses
	}

	public void removeBasketItem(int basketItemId) throws BasketException {
		// TODO Auto-generated method stub
		
	}

	public Collection getBasketItems() throws BasketException {
		// TODO Auto-generated method stub
		return null;
	}

	public ItemDetails getItemDetails(int itemId) throws ShopException {
		// TODO Auto-generated method stub
		return null;
	}

	public void addItem(Item item) throws ShopException {
		// TODO Auto-generated method stub
		
	}

	public void updateItem(Item item) throws ShopException {
		// TODO Auto-generated method stub
		
	}

	public Map getDictionary(SystemDictionary dictionary)
			throws SystemException {
		// TODO Auto-generated method stub
		return null;
	}

}
