package pl.jakubwojt.kontomierz.test.common.services.layers;

import pl.jakubwojt.kontomierz.test.common.exceptions.BasketException;
import pl.jakubwojt.kontomierz.test.common.exceptions.ShopException;
import pl.jakubwojt.kontomierz.test.common.exceptions.SystemException;
import pl.jakubwojt.kontomierz.test.common.services.layers.base.ApplicationService;
import pl.jakubwojt.kontomierz.test.common.services.layers.base.ExecutorApplicationService;

public class ErrorsLoggerLayer extends ExecutorApplicationService
{	
	public ErrorsLoggerLayer(ApplicationService decorated) 
	{
		super(decorated);
	}

	@Override
	protected <T> T Execute(Function<T> action)  throws BasketException, ShopException, SystemException 
	{
		try
		{
			T result = action.run();
			return result;
		} 
		catch (BasketException | ShopException | SystemException e) 
		{
			e.printStackTrace();
			throw e;
		}
	}

	@Override
	protected void Execute(Action action) throws BasketException, ShopException, SystemException {
		
			try {
				action.run();
			} catch (BasketException | ShopException | SystemException e) 
			{
				e.printStackTrace();
				throw e;
			}
		
	}

	
}
