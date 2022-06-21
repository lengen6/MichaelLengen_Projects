package com.littleLdevelopment.dao;

import java.util.List;

import com.littleLdevelopment.model.Home;


public interface HomeDAO {
	
    List<Home> retrieveHomesForSale();
    void addHome(Home home);
    Home retrieveHomeByMLSId(String mlsId);
    boolean deleteHome(String mlsId);
	
}
