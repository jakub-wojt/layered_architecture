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

public abstract class ExecutorApplicationService implements ApplicationService
{
	protected interface Function<T>
	{
		public T run() throws BasketException, SystemException, ShopException;
	}
	
	protected interface Action
	{
		public void run() throws BasketException, ShopException, SystemException;
	}

	private ApplicationService decorated;
	
	public ExecutorApplicationService(ApplicationService decorated) {
		this.decorated = decorated;
	}
	
	protected abstract <T> T Execute(Function<T> action) throws BasketException, SystemException, ShopException;
	
	protected abstract void Execute(Action action) throws BasketException, SystemException, ShopException;
	
	@Override
	public void addBasketItem(final BasketItem item) throws BasketException 
	{
		try {
			Execute(new Action() 
			{
				@Override
				public void run() throws BasketException 
				{
					decorated.addBasketItem(item);
				}
			});
		} 
		catch (SystemException | ShopException e) 
		{
			// addBasketItem can't throw these exceptions
		}
	}
	
	@Override
	public Collection<BasketItem> getBasketItems() throws BasketException {
		try {
			return Execute(new Function<Collection<BasketItem>>() 
					{
				@Override
				public Collection<BasketItem> run() throws BasketException {
					return decorated.getBasketItems();
				}
			});
		} catch (SystemException | ShopException e) {
			// these exception wont be thrown
			return null;
		}
	}
	
	@Override
	public Map<Integer, String> getDictionary(final SystemDictionary dictionary) throws SystemException 
	{
		try {
			return Execute(new Function<Map<Integer, String>>(){
				@Override
				public Map<Integer, String> run() throws BasketException, SystemException {
					return decorated.getDictionary(dictionary);
				}
			});
		} catch (BasketException | ShopException e) { return null; }
	}
	
	@Override
	public void addItem(final Item item) throws ShopException {
		try {
			Execute(new Action(){
				@Override
				public void run() throws BasketException, ShopException {
					decorated.addItem(item);
				}
			});
		} catch (BasketException | SystemException e) {
		}
		
	}
	
	@Override
	public ItemDetails getItemDetails(final int itemId) throws ShopException {
		try {
			return Execute(new Function<ItemDetails>(){
			@Override
			public ItemDetails run() throws BasketException, SystemException, ShopException {
				return decorated.getItemDetails(itemId);
			}
});
		} catch (BasketException | SystemException e) { return null;}
	}
	
	@Override
	public void removeBasketItem(final int basketItemId) throws BasketException {
		try {
			Execute(new Action(){
				@Override
				public void run() throws BasketException, ShopException {
					decorated.removeBasketItem(basketItemId);
				}
			});
		} catch (SystemException | ShopException e) { }
	}
	
	@Override
	public void updateItem(final Item item) throws ShopException {
		try {
			Execute(new Action(){
				@Override
				public void run() throws BasketException, ShopException {
					decorated.updateItem(item);
				}
			});
		} catch (BasketException | SystemException e) { }
	}
}
