import axios from 'axios';

export default {

   // write methods to call the backend services
   //  axios.get
   //  axios.put / post / delete
   //  axios calls always returns a promise 

   search() {
      return axios.get('/homes')     //Making an HTTP GET request to: 'localhost:8080/homes'
                                     //pending state while waiting for response
                                     // when it gets the response it's state is fulfilled
   },


   addHome(home)  {
       return axios.post('/homes', home)
   }



}