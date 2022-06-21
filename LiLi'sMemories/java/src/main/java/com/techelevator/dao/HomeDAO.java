package com.techelevator.dao;

import java.util.List;

import com.techelevator.model.Home;


public interface HomeDAO {
	
    List<Home> retrieveHomesForSale();
    void addHome(Home home);
    Home retrieveHomeByMLSId(String mlsId);
    boolean deleteHome(String mlsId);
	
}
