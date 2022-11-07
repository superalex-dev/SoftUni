function legendaryFarming(input){
    let keyMaterials = {
        shards: 0,
        fragments: 0,
        motes: 0
    };
    let junk = {};
    let legendary = {
        shards: 'Shadowmourne',
        fragments: 'Valanyr',
        motes: 'Dragonwrath'
    };
    let isObtained = false;
    for (let i = 0; i < input.length; i++) {
        let tokens = input[i].split(' ');
        let quantity = Number(tokens[0]);
        let material = tokens[1].toLowerCase();
        if (material === 'shards' || material === 'fragments' || material === 'motes') {
            keyMaterials[material] += quantity;
            if (keyMaterials[material] >= 250) {
                keyMaterials[material] -= 250;
                console.log(`${legendary[material]} obtained!`);
                isObtained = true;
                break;
            }
        } else {
            if (!junk.hasOwnProperty(material)) {
                junk[material] = quantity;
            } else {
                junk[material] += quantity;
            }
        }
    }
    if (isObtained) {
        let sortedKeyMaterials = Object.entries(keyMaterials).sort((a, b) => b[1] - a[1] || a[0].localeCompare(b[0]));
        for (let [material, quantity] of sortedKeyMaterials) {
            console.log(`${material}: ${quantity}`);
        }
        let sortedJunk = Object.entries(junk).sort((a, b) => a[0].localeCompare(b[0]));
        for (let [material, quantity] of sortedJunk) {
            console.log(`${material}: ${quantity}`);
        }
        for (let [material, quantity] of sortedKeyMaterials) {
            if (material === 'shards' || material === 'fragments' || material === 'motes') {
                console.log(`${material}: ${quantity}`);
            }
        }
        for (let [material, quantity] of sortedJunk) {
            console.log(`${material}: ${quantity}`);
        }
    }
}
legendaryFarming(['3 Motes 5 stones 5 Shards 6 leathers 255 fragments 7 Shards'])