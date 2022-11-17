function modernTimes(sentence){
    let words = sentence.split(' ');
    let result = [];
    for (let word of words) {
        if (word.startsWith('#') && word.length > 1) {
            word = word.substring(1);
            let isValid = true;
            for (let char of word) {
                if (!char.match(/[a-zA-Z]/g)) {
                    isValid = false;
                    break;
                }
            }
            if (isValid) {
                result.push(word);
            }
        }
    }
    console.log(result.join(''));
}

modernTimes('Nowadays everyone uses # to tag a #special word in #socialMedia');