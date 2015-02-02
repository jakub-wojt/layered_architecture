package pl.jakubwojt.kontomierz.test.common.dto;

import java.util.Date;

/**
 * @author Jakub Wojt
 * Contains data regarding user basket
 */

public class Basket 
{
	private int id;
	private int userId;
	private Date creationDate;
	
	public Basket(int id, int userId, Date creationDate) {
		super();
		this.id = id;
		this.userId = userId;
		this.creationDate = creationDate;
	}
	
	public int getId() {
		return id;
	}
	
	public int getUserId() {
		return userId;
	}
	
	public Date getCreationDate() {
		return creationDate;
	}
	
	
}
