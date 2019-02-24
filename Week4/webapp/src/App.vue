<template>
  <div id="app">
  
   <div class="menu-bar">
        <span v-on:click='goToHome'><img class="header-img" src="./assets/logo.png"></span>
        <span v-on:click='goToHome'>Logoff</span>
        <span v-on:click='goToPerson'>Person</span>
        <span v-on:click='goToStudents'>Student</span>
    </div>

    <router-view/>
  </div>
</template>

<script>
export default {
  name: 'App',
  methods: {
    goToHome: function() {
      this.$router.push({ path: 'home'})
    },
    goToPerson: function() {
      this.$router.push({ path: 'person'})
    },
    goToStudents: function() {
      this.$router.push({ path: 'students'})
    }
  }
  
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}

.section-heading {
    background-color: yellow;
}

#first-section {
    color: rgb(47, 0, 255);
    font-size: 20pt;
}

.index-header {
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;

}

.header-text {
    color: rgb(76, 76, 124);
}

.menu-item {
    margin-right: 10px;
    padding: 5px;
}

.menu-bar {
    background-color: lightgray;
    height: 60px;
    margin-top: 10px;
    vertical-align: middle;
    padding-top: 20px;
    width: 100%;
}

.menu-bar a {
    text-decoration: none;
    padding-bottom: 10px;
}

.header-img {
    height: 45px;
}

.footer {
    background-color: lightgray;
    height: 20px;
    margin-top: 10px;
    vertical-align: middle;
    padding-top: 10px;
    width: 100%;
    text-align: left;
    font-size: small;
}

.section span {
    color: green;
}

.section {
    font-size: 15pt;
}

table {
    border-collapse: collapse;
}

table, th, td {
    border: 1px solid black;
    padding: 10px;
}

.table-header {
    color: red;
}

.form-entry {
    margin-top: 20px;
}
</style>
