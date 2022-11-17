function hardWord(input){
    let text = input[0];
    let pattern = /\w+/g;
    let words = text.match(pattern);
    let result = words.filter(word => word.length > 5);
    console.log(result.join(", "));
}

hardWord(['The following example creates an array of 5 elements filled with 0: let arr = Array(5).fill(0);']);