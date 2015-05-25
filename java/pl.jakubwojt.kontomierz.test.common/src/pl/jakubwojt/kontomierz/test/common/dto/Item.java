package pl.jakubwojt.kontomierz.test.common.dto;

import java.math.BigDecimal;

public class Item 
{
	int id;
	String name;
	BigDecimal price;
	
	
	public Item(int id, String name) {
		super();
		this.id = id;
		this.name = name;
	}

	public int getId() {
		return id;
	}
	
	public String getName() {
		return name;
	}

	public BigDecimal getPrice() {
		return price;
	}

	public void setPrice(BigDecimal price) {
		this.price = price;
	}
	
	
}
