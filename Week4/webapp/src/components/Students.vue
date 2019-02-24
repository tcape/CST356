<template>
<div>
    <h3 class="table-header">Student Table</h3>

    <table>
        <thead>
            <tr>
                <th>Student ID</th>
                <th>Email Address</th>
            </tr>
        </thead>
        <tbody>
             <tr v-for="student in students">
                    <td>{{ student.id }}</td>
                    <td>{{ student.email }}</td>
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
        name: 'Student',
        mounted(){
            this.students = getStudents();
        },
        data(){
            return{
                students: []
            }
        }
    }
    function getStudents(){
        return JSON.parse(testStudents).students;
    }

    var testStudents = '{"students": [{"id": 3738372,"email": "bob@gmail.com"}, {"id": 3938204,"email": "joe@gmail.com"}, {"id": 9876543,"email": "sarah@gmail.com"}, {"id": 1234567,"email": "mary@gmail.com"}, {"id": 9674532,"email": "billy@gmail.com"}]}';

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