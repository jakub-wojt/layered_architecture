package pl.jakubwojt.kontomierz.test.common.services.layers.base;

import java.util.Collection;
import java.util.Map;

import pl.jakubwojt.kontomierz.test.common.dto.BasketItem;
import pl.jakubwojt.kontomierz.test.common.dto.Item;
import pl.jakubwojt.kontomierz.test.common.dto.ItemDetails;
import pl.jakubwojt.kontomierz.test.common.enums.SystemDictionary;
import pl.jakubwojt.kontomierz.test.common.exceptions.BasketException;
import pl.jakubwojt.kontomierz.test.common.exceptions.ShopException;
import pl.jakubwojt.kontomierz.test.common.exceptions.SystemException;

public class DecoratedApplicationService implements ApplicationService
{
	ApplicationService decorated;
	
	public DecoratedApplicationService(ApplicationService decorated) 
	{
		this.decorated = decorated;
	}

	public void addBasketItem(BasketItem item) throws BasketException 
	{
		decorated.addBasketItem(item);
	}

	public void removeBasketItem(int basketItemId) throws BasketException {
		decorated.removeBasketItem(basketItemId);
	}

	public Map<Integer, String> getDictionary(SystemDictionary dictionary)
			throws SystemException {
		return decorated.getDictionary(dictionary);
	}

	public Collection<BasketItem> getBasketItems() throws BasketException {
		return decorated.getBasketItems();
	}

	public ItemDetails getItemDetails(int itemId) throws ShopException {
		return decorated.getItemDetails(itemId);
	}

	public void addItem(Item item) throws ShopException {
		decorated.addItem(item);
	}


	public void updateItem(Item item) throws ShopException {
		decorated.updateItem(item);
	}

	
}
