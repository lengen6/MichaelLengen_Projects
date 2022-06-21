<template>
  <div>
    <div id="searchHomes">

        <label for = "zip">Enter your zip code to find your dream home</label>
        <input type="text" name="zip" v-model="zipFilter"/>

    </div> 
    <div id="main-div">
      <p v-if="filteredHomes.length == 0">No Results Found</p>
      <div class="divTable minimalistBlack" v-if="filteredHomes.length > 0">
        <div class="divTableHeading">
          <div class="divTableRow">
            <div class="divTableHead"></div>
            <div class="divTableHead">MLS Number</div>
            <div class="divTableHead">Address</div>
            <div class="divTableHead">Description</div>
            <div class="divTableHead">Price</div>
          </div>
        </div>
        <div class="divTableBody">
          <div class="divTableRow" v-for="home in filteredHomes" v-bind:key="home.mlsNumber">
            <div class="divTableCell">
                <img v-bind:src="home.imageName" />
            </div>
            <div class="divTableCell">{{home.mlsNumber}}</div>
            <div class="divTableCell">
                <p>{{home.address.addressLine}}</p>
                <p>{{home.address.city}}, {{home.address.state}} {{home.address.zipCode}}</p>     
             </div>
            <div class="divTableCell">{{home.description}}</div>
            <div class="divTableCell">${{home.price}}</div>
          </div>
        </div>
      </div>
    </div>


  </div>
</template>

<script>
export default {
    name: 'home-search',
    data() {
        return {
           zipFilter: ''

        };
    },
    computed: {
        filteredHomes() {
           const homes = this.$store.state.homes;

           return homes.filter(home => {
               return this.zipFilter == '' ? true : this.zipFilter == home.address.zipCode;
           });

        }
    },
    methods: {
        // would handle any events here...
    }

}
</script>

<style scoped>

#main-div {
    margin: 30px;
}

#searchHomes {
    margin: 30px;
}

input[type=text] {
    margin: 30px;
    width: 15%;
    padding: 12px 17px;
    border: 2px solid green;
    border-radius: 6px;
}

img {
    width: 175px;
    height: auto;
}


div.minimalistBlack {
   margin:auto; 
  border: 2px solid #06B712;
  width: 80%;
  text-align: left;
  border-collapse: collapse;
}
.divTable.minimalistBlack .divTableCell, .divTable.minimalistBlack .divTableHead {
  border: 1px solid #000000;
  padding: 5px 4px;
}
.divTable.minimalistBlack .divTableBody .divTableCell {
  font-size: 14px;
}
.divTable.minimalistBlack .divTableHeading {
  background: #1DFF2C;
  background: -moz-linear-gradient(top, #55ff61 0%, #33ff41 66%, #1DFF2C 100%);
  background: -webkit-linear-gradient(top, #55ff61 0%, #33ff41 66%, #1DFF2C 100%);
  background: linear-gradient(to bottom, #55ff61 0%, #33ff41 66%, #1DFF2C 100%);
  border-bottom: 3px solid #0F9A39;
}
.divTable.minimalistBlack .divTableHeading .divTableHead {
  font-size: 15px;
  font-weight: bold;
  color: #109902;
  text-align: left;
}
.minimalistBlack .tableFootStyle {
  font-size: 14px;
}
/* DivTable.com */
.divTable{ 
    display: table; 
    table-layout: fixed;
}
.divTableRow { display: table-row; }
.divTableHeading { display: table-header-group;}
.divTableCell, .divTableHead { display: table-cell;}
.divTableHeading { display: table-header-group;}
.divTableFoot { display: table-footer-group;}
.divTableBody { display: table-row-group;}

</style>