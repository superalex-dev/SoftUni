function pascalCaseSplitter(text){
    let result = text[0];
    for (let i = 1; i < text.length; i++) {
        if(text[i] === text[i].toUpperCase()){
            result += ", " + text[i];
        } else {
            result += text[i];
        }
    }
    console.log(result);
}

pascalCaseSplitter('SplitMeIfYouCanHaHaYouCantOrYouCan');