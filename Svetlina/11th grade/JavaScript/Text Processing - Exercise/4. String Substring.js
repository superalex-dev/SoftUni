function stringSubstring(searchedWord, sentence){
    searchedWord = searchedWord.toLowerCase();
    sentence = sentence.toLowerCase().split(' ');
    if (sentence.includes(searchedWord)) {
        console.log(searchedWord);
    } else {
        console.log(`${searchedWord} not found!`);
    }

}

stringSubstring('javascript',
'JavaScript is the best programming language'
);