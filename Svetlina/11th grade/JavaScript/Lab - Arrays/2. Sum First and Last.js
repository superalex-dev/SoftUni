function sumFirstAndLast(array){
    array = array.map(Number);
    console.log(array.shift() + array.pop());
}

sumFirstAndLast(['5' , '10'])