function totalVolume(...boxes) {
    console.log(boxes.map(box => box.reduce((total, currentValue) => total * currentValue)).reduce((total, current) => total + current));
}