function race(input){
    let pattern = /[A-Za-z]+/g;
    let names = input.match(pattern);
    let pattern2 = /\d/g;
    let numbers = input.match(pattern2);
    let result = names.filter((name, index) => name.length > 0);
    let result2 = numbers.filter((number, index) => number.length > 0);
    let sum = 0;
    for(let i = 0; i < result2.length; i++){
        sum += Number(result2[i]);
    }
    console.log(`You have ${sum} coins.`);
    console.log(`You have ${result.length} coins.`);
    console.log(result.join(", "));
}

race(["George, Peter, Bill, Tom", "G4e@55or%6g6!68e!!@", "R1@!3a$y4456@", "B5@i@#123ll", "G@e54o$r6ge#", "7P%et^#e5346r", "T$o553m&6", "end of race"])