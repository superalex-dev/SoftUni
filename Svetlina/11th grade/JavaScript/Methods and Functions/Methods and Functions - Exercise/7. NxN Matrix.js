function NxNMatrix(number){
    let result = '';
    for (let i = 0; i < number; i++) {
        for (let j = 0; j < number; j++) {
            result += number + ' ';
        }
        console.log(result);
        result = '';
    }
}
NxNMatrix(7);