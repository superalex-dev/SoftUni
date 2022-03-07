function secondLargest(numbers){
    var max = Math.max.apply(null, numbers);
    numbers.splice(numbers.indexOf(max), 1);
    console.log(Math.max.apply(null, numbers));
}
