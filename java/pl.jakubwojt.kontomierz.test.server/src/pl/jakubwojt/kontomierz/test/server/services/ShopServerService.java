package pl.jakubwojt.kontomierz.test.server.services;

import pl.jakubwojt.kontomierz.test.common.dto.Item;
import pl.jakubwojt.kontomierz.test.common.dto.ItemDetails;
import pl.jakubwojt.kontomierz.test.common.exceptions.ShopException;
import pl.jakubwojt.kontomierz.test.common.services.ShopService;
import pl.jakubwojt.kontomierz.test.server.dao.GlobalDAO;

public class ShopServerService implements ShopService{

	private GlobalDAO dao;

	public ShopServerService(GlobalDAO dao){
		this.dao = dao;
	}
	
	@Override
	public ItemDetails getItemDetails(int itemId) throws ShopException {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public void addItem(Item item) throws ShopException {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void updateItem(Item item) throws ShopException {
		// TODO Auto-generated method stub
		
	}

}