function loadingBar(number){
    let result = '';
    let percent = number / 10;
    let dots = 10 - percent;
    if (number === 100){
        console.log('100% Complete!');
        console.log('[%%%%%%%%%%]');
    } else {
        console.log(`${number}% [${'%'.repeat(percent)}${'.'.repeat(dots)}]`);
        console.log('Still loading...');
    }
}