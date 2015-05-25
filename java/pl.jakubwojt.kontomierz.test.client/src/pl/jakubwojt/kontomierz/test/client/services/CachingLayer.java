package pl.jakubwojt.kontomierz.test.client.services;

import java.util.Map;

import pl.jakubwojt.kontomierz.test.common.enums.SystemDictionary;
import pl.jakubwojt.kontomierz.test.common.exceptions.SystemException;
import pl.jakubwojt.kontomierz.test.common.services.layers.base.ApplicationService;
import pl.jakubwojt.kontomierz.test.common.services.layers.base.DecoratedApplicationService;



/**
 * @author Jakub Wojt
 * Caching on client side (instead of calling method "getDictionary" 100x, values can be stored locally)
 * Overwrite only relevant (to caching) methods 
 */

public class CachingLayer extends DecoratedApplicationService {

	public CachingLayer(ApplicationService decorated) {
		super(decorated);
	}
	
	public Map getDictionary(SystemDictionary dictionary)
			throws SystemException {
		//this can be cached
		
		
		return super.getDictionary(dictionary);
	}

}
