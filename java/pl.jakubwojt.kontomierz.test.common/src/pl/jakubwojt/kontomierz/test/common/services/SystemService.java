package pl.jakubwojt.kontomierz.test.common.services;

import java.util.Map;

import pl.jakubwojt.kontomierz.test.common.enums.SystemDictionary;
import pl.jakubwojt.kontomierz.test.common.exceptions.SystemException;

/**
 * @author Jakub Wojt
 * 
 * Service which provides system related data 
 * (dictionaries, static data, system settings etc ...
 */

public interface SystemService 
{
	Map<Integer, String> getDictionary(SystemDictionary dictionary) throws SystemException;
}