function furniture(input){
    let pattern = />>(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d+)!(?<quantity>\d+)/g;
    let total = 0;
    console.log("Bought furniture:");
    while ((valid = pattern.exec(input)) !== null) {
        console.log(valid.groups.name);
        total += Number(valid.groups.price) * Number(valid.groups.quantity);
    }
    console.log(`Total money spend: ${total.toFixed(2)}`);
}

furniture(['>>Sofa<<312.23!3', '>>TV<<300!5', '>Invalid<<!5', 'Purchase']);