package pl.jakubwojt.kontomierz.test.server.services;

import java.util.Collection;

import pl.jakubwojt.kontomierz.test.common.dto.BasketItem;
import pl.jakubwojt.kontomierz.test.common.exceptions.BasketException;
import pl.jakubwojt.kontomierz.test.common.services.BasketService;
import pl.jakubwojt.kontomierz.test.server.dao.GlobalDAO;

/**
 * @author Jakub Wojt
 * Basket business class
 */

public class BasketServerService implements BasketService{

	private GlobalDAO dao;

	public BasketServerService(GlobalDAO dao){
		this.dao = dao;
	}
	
	@Override
	public void addBasketItem(BasketItem item) throws BasketException {
		// implementation of business functionality without non-necessary noise
		
	}

	@Override
	public void removeBasketItem(int basketItemId) throws BasketException {
		// implementation of business functionality without non-necessary noise
	}

	@Override
	public Collection<BasketItem> getBasketItems() throws BasketException {
		// implementation of business functionality without non-necessary noise
		return null;
	}

}