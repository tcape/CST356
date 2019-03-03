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
             <tr v-for="student in students":key="student.id">
                    <td>{{ student.studentId }}</td>
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
    import Vue from 'vue';
    export default {
        name: 'Students',
        
        data () {
            return {
                students: []
            }
        },
        methods: {
            getStudents: function() {
                let studentsApi = process.env.STUDENTS_API;
                Vue.axios.get(studentsApi).then(
                    (response) => {
                        console.log(response)
                        this.students = response.data;
                    },
                    (error) => {
                        console.log(error)
                    }
                );  
            }
        },
        mounted() {
            this.getStudents();
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