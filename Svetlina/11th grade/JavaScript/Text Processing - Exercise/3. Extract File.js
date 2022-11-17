function extractFile(filePath){
    let file = filePath.split('\\').pop();
    let fileName = file.split('.').shift();
    let fileExtension = file.split('.').pop();
    console.log(`File name: ${fileName}`);
    console.log(`File extension: ${fileExtension}`);
}

extractFile('C:\\Internal\\training-internal\\Template.pptx');
