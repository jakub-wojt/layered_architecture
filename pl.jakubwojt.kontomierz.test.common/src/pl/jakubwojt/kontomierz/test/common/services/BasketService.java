package pl.jakubwojt.kontomierz.test.common.services;

import java.util.Collection;

import pl.jakubwojt.kontomierz.test.common.dto.BasketItem;
import pl.jakubwojt.kontomierz.test.common.exceptions.BasketException;

public interface BasketService 
{
	public void addBasketItem(BasketItem item) throws BasketException;
	public void removeBasketItem(int basketItemId)throws BasketException;
	public Collection<BasketItem> getBasketItems()throws BasketException;
}
