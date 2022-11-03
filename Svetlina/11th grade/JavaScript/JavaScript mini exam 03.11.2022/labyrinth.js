function labyrinth(labyrinth, directions) {
    const start = labyrinth.indexOf(2);
  const end = labyrinth.indexOf(3);
  let position = start;
  let i = 0;
  while (position !== end && i < directions.length) {
    switch (directions[i]) {
      case 'N':
        position -= 7;
        break;
      case 'S':
        position += 7;
        break;
      case 'E':
        position += 1;
        break;
      case 'W':
        position -= 1;
        break;
    }
    if (labyrinth[position] === 1) {
      console.log('Dead');
    }
    i++;
  }
  console.log(position === end ? 'Final' : 'Lost');
}
labyrinth([[1,1,1,1,1,1,1,1,1],
        [1,0,0,0,0,0,3],
        [1,0,1,0,1,0,1],
        [0,0,1,0,0,0,1],
        [1,0,1,0,1,0,1],
        [1,0,0,0,0,0,1],
        [1,2,1,0,1,0,1]],
    ["N", "N", "N", "N", "N", "E", "E", "E", "E", "E", "E", "E"]);