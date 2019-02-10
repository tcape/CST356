function initializeStudents() {
    var data = getTestStudents();
    displayStudents(data.students);
}

function getTestStudents() {
    return JSON.parse(testStudents);
}

function displayStudents(students) {

    for(i = 0; i < students.length; i++) {

        console.log('id: ' + students[i].id);
        
        var id = students[i].id;
        var email = students[i].email;
        var tableData = "<tr><td>" + id + "</td><td>" + email +"</td></tr>";

        $("table tbody").append(tableData);
    }
}


var testStudents = '{"students": [{"id": 3738372,"email": "bob@gmail.com"}, {"id": 3938204,"email": "joe@gmail.com"}, {"id": 9876543,"email": "sarah@gmail.com"}, {"id": 1234567,"email": "mary@gmail.com"}, {"id": 9674532,"email": "billy@gmail.com"}]}';
