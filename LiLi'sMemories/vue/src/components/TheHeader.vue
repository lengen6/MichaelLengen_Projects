<template>
  <div>
      <img src="../assets/java-green.png">
      <nav>
           <router-link v-bind:to="{name: 'home'}">Home</router-link>
         <a href="#">About</a>
         <router-link v-bind:to="{name: 'search'}">Search Homes</router-link>
         <a href="#">Add Home</a>
      </nav>
  </div>
</template>

<script>
export default {
    name: 'the-header',
    data() {
        return {
          
        }
    }

}
</script>

<style scoped>
 img {
     width: 20%;
     height: auto;
     display: block;
     margin-left: auto;
     margin-right: auto;
 }


nav {
    display: flex;
    justify-content: center;
}

nav a {
    padding: 15px 25px;
    background-color: #15b467;
    color:black;
}

nav a:hover {
    background-color: rgb(8, 104, 8);
    color: white;
}

</style>