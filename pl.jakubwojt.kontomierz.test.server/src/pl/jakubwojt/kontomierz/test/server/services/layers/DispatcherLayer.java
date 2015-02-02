package pl.jakubwojt.kontomierz.test.server.services.layers;

import java.util.Collection;
import java.util.Map;

import pl.jakubwojt.kontomierz.test.common.dto.BasketItem;
import pl.jakubwojt.kontomierz.test.common.dto.Item;
import pl.jakubwojt.kontomierz.test.common.dto.ItemDetails;
import pl.jakubwojt.kontomierz.test.common.enums.SystemDictionary;
import pl.jakubwojt.kontomierz.test.common.exceptions.BasketException;
import pl.jakubwojt.kontomierz.test.common.exceptions.ShopException;
import pl.jakubwojt.kontomierz.test.common.exceptions.SystemException;
import pl.jakubwojt.kontomierz.test.common.services.BasketService;
import pl.jakubwojt.kontomierz.test.common.services.ShopService;
import pl.jakubwojt.kontomierz.test.common.services.SystemService;
import pl.jakubwojt.kontomierz.test.common.services.layers.base.ApplicationService;

public class DispatcherLayer implements ApplicationService 
{
	private BasketService basketService;
	private ShopService shopService;
	private SystemService systemService;
	
	public DispatcherLayer(BasketService basketService,
			ShopService shopService, SystemService systemService) {
		super();
		this.basketService = basketService;
		this.shopService = shopService;
		this.systemService = systemService;
	}
	
	public void addBasketItem(BasketItem item) throws BasketException {
		basketService.addBasketItem(item);
	}
	
	public void removeBasketItem(int basketItemId) throws BasketException {
		basketService.removeBasketItem(basketItemId);
	}
	
	public Collection<BasketItem> getBasketItems() throws BasketException {
		return basketService.getBasketItems();
	}
	
	public ItemDetails getItemDetails(int itemId) throws ShopException {
		return shopService.getItemDetails(itemId);
	}
	
	public void addItem(Item item) throws ShopException {
		shopService.addItem(item);
	}
	
	public void updateItem(Item item) throws ShopException {
		shopService.updateItem(item);
	}
	
	public Map<Integer, String> getDictionary(SystemDictionary dictionary)
			throws SystemException {
		return systemService.getDictionary(dictionary);
	}
	


}
