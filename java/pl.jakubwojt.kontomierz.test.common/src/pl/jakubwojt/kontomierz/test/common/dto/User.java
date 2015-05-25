package pl.jakubwojt.kontomierz.test.common.dto;

import java.util.Date;

public class User 
{
	private int id;
	private String login;
	private Date creationDate;
	
	public User(int id, String login, Date creationDate) 
	{
		super();
		this.id = id;
		this.login = login;
		this.creationDate = creationDate;
	}

	public int getId() {
		return id;
	}
	
	public String getLogin() {
		return login;
	}
	
	public Date getCreationDate() {
		return creationDate;
	}
	
}
