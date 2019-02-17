<template>
<div>

    <h3 class="table-header">People Table</h3>

    <table>
        <thead>
            <tr>
                <th>First Name</th>
                <th>Middle Initial</th>
                <th>Last Name</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>Timothy</td>
                <td>M</td>
                <td>Capehart</td>
            </tr>
            <tr>
                <td>Robert</td>
                <td>A</td>
                <td>Smith</td>
            </tr>
            <tr>
                <td>Joe</td>
                <td>S</td>
                <td>Schmoe</td>
            </tr>
            <tr>
                <td>Billy</td>
                <td>R</td>
                <td>Nelson</td>
            </tr>
            <tr>
                <td>Henry</td>
                <td>A</td>
                <td>Tudor</td>
            </tr>
        </tbody>
    </table>

    <div class="footer">
        Copyright Timothy Capehart 2019
    </div>
</div>

</template>

<script>
export default {
  name: 'Person',
  data () {
    return {
     
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
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