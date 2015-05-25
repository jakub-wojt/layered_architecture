package pl.jakubwojt.kontomierz.test.server.services;

import java.util.Map;

import pl.jakubwojt.kontomierz.test.common.enums.SystemDictionary;
import pl.jakubwojt.kontomierz.test.common.exceptions.SystemException;
import pl.jakubwojt.kontomierz.test.common.services.SystemService;
import pl.jakubwojt.kontomierz.test.server.dao.GlobalDAO;

public class SystemServerService implements SystemService {

	
	private GlobalDAO dao;

	public SystemServerService(GlobalDAO dao){
		this.dao = dao;
	}
	
	@Override
	public Map<Integer, String> getDictionary(SystemDictionary dictionary)
			throws SystemException {
		// TODO Auto-generated method stub
		return null;
	}

}