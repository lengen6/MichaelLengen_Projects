<template>
  <div id="app">

<!--
    <div id="nav">
      <router-link v-bind:to="{ name: 'home' }">Home</router-link>&nbsp;|&nbsp;
      <router-link v-bind:to="{ name: 'logout' }" v-if="$store.state.token != ''">Logout</router-link>
    </div>
-->
    <the-header />
    <home-search />
    <the-footer />

  </div>
</template>

<script>

import TheFooter from './components/TheFooter.vue'
import TheHeader from './components/TheHeader.vue'
import HomeSearch from './components/HomeSearch.vue'

export default {

  name: 'App',
  components: {

    TheHeader,
    HomeSearch,
    TheFooter
  }
}
</script>

<style scoped>

#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>


