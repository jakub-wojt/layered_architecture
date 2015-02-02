package pl.jakubwojt.kontomierz.test.common.services;

import pl.jakubwojt.kontomierz.test.common.dto.Item;
import pl.jakubwojt.kontomierz.test.common.dto.ItemDetails;
import pl.jakubwojt.kontomierz.test.common.exceptions.ShopException;

public interface ShopService 
{
	ItemDetails getItemDetails(int itemId) throws ShopException;
	void addItem(Item item) throws ShopException;
	void updateItem(Item item) throws ShopException;
}
