function winner(deckSteve, deckJosh) {
    let cards = ["2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K", "A"];
    let scoreSteve = 0;
    let scoreJosh = 0;
    let i = 0;
    while (i < deckSteve.length) {
        if (cards.indexOf(deckSteve[i]) > cards.indexOf(deckJosh[i])) {
            scoreSteve++;
        } else if (cards.indexOf(deckSteve[i]) < cards.indexOf(deckJosh[i])) {
            scoreJosh++;
        }
        i++;
    }
    if (scoreSteve > scoreJosh) {
        console.log("Steve wins " + scoreSteve + " to " + scoreJosh);
    }
    else if (scoreSteve < scoreJosh) {
        console.log("Josh wins " + scoreJosh + " to " + scoreSteve);
    }

}
winner(["A", "7", "8"], ["K", "5", "9"]);