function employees(namesArray){
    let employees = [];
    for (let name of namesArray) {
        employees.push({
            name: name,
            personalNumber: name.length
        });
    }
    console.log();
    for (let employee of employees) {
        console.log(`Name: ${employee.name} -- Personal Number: ${employee.personalNumber}`);
    }
}

employees(['Silas Butler', 'Adnaan Buckley', 'Juan Peterson', 'Brendan Villarreal']);