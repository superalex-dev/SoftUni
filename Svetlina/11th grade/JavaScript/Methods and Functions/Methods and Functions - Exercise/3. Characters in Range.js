function charactersInRange(firstChar, secondChar){
    let first = firstChar.charCodeAt(0);
    let second = secondChar.charCodeAt(0);
    let result = [];
    let start = Math.min(first, second);
    let end = Math.max(first, second);
    for (let i = start + 1; i < end; i++) {
        result.push(String.fromCharCode(i));
    }
    console.log(result.join(" "));
}

charactersInRange('C', '#');