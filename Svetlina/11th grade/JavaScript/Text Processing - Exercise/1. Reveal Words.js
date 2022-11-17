function revealWords(words, sentence) {
    let wordsArr = words.split(', ');
    wordsArr.forEach(word => {
        let star = '*'.repeat(word.length);
        sentence = sentence.replace(star, word);
    });
    console.log(sentence);
}

revealWords('great, learning', 'softuni is ***** place for ******** new programming languages')