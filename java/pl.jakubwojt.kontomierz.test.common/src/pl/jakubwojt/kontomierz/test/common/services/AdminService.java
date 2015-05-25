package pl.jakubwojt.kontomierz.test.common.services;

import pl.jakubwojt.kontomierz.test.common.dto.User;
import pl.jakubwojt.kontomierz.test.common.exceptions.AdminException;

public interface AdminService 
{
	public void addUser(User user) throws AdminException;
	public void removeUser(int userId) throws AdminException;
}
