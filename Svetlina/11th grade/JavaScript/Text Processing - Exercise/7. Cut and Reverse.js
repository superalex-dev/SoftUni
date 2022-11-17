function cutAndReverse(input){
    let firstHalf = input.substring(0, input.length / 2);
    let secondHalf = input.substring(input.length / 2);
    let reversedFirstHalf = firstHalf.split("").reverse().join("");
    let reversedSecondHalf = secondHalf.split("").reverse().join("");
    console.log(reversedFirstHalf);
    console.log(reversedSecondHalf);
}

cutAndReverse('tluciffiDsIsihTgnizamAoSsIsihT');