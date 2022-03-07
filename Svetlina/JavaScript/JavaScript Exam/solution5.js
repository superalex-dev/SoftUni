function capToFront(a)
{
    let UpperCase='';
    const LowerCase = a.replace(/[A-Z]/g, function(match){
        UpperCase += match;
        return '';
    });
    return UpperCase + LowerCase;
}