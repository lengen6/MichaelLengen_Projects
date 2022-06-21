package com.techelevator.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.security.access.prepost.PreAuthorize;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.ResponseStatus;
import org.springframework.web.bind.annotation.RestController;

import com.techelevator.dao.HomeDAO;
import com.techelevator.model.Home;

/*   
     DAO methods for reference:
 
    	List<Home> retrieveHomesForSale();
    	void addHome(Home home);
    	Home retrieveHomeByMLSId(String mlsId);
    	boolean deleteHome(String mlsId);

 */

@RestController
@CrossOrigin
public class HomeController {
	
	private HomeDAO homeDAO;
	
    public HomeController(HomeDAO homeDAO) {

        this.homeDAO = homeDAO;
    }		
	
    /**
     * Return all homes
     *
     * @return List<Home>  -  a list of all homes in the system
     */
	@RequestMapping(path = "/homes", method = RequestMethod.GET)
	public List<Home> getHomes() {
		return homeDAO.retrieveHomesForSale();
	}    


    /**
     * Add a new home
     *
     * @return 201 Created if successful
     */	
    @ResponseStatus(HttpStatus.CREATED)
    @RequestMapping(path = "/homes", method = RequestMethod.POST)
    public void addHome(@RequestBody Home home) {
        homeDAO.addHome(home);
    }

	
}
