package pl.jakubwojt.kontomierz.test.common.services.layers;

import pl.jakubwojt.kontomierz.test.common.exceptions.ShopException;

public class ItemValidationException extends ShopException{

	public ItemValidationException(String string) {
		super(string);
	}

	/**
	 * 
	 */
	private static final long serialVersionUID = 3873200638300852607L;

}
