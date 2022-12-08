function colorizeRows() {
    let tableRow = document.querySelectorAll('table tr');
    for (let i = 1; i < tableRow.length; i += 2) {
        tableRow[i].style.backgroundColor = 'Teal';
    }
    
}