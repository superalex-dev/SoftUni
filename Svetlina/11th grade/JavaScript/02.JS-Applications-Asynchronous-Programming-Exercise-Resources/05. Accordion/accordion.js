async function solution() {
    const main = document.getElementById('main');
  
    try {
      const articleTitlesResponse = await fetch('http://localhost:3030/jsonstore/advanced/articles/list');
      const articleTitles = await articleTitlesResponse.json();
  
      for (const { _id, title } of articleTitles) {
        const articleContentResponse = await fetch(`http://localhost:3030/jsonstore/advanced/articles/details/${_id}`);
        const articleContent = await articleContentResponse.json();
  
        const div = document.createElement('div');
        div.classList.add('accordion');
  
        div.innerHTML = `
          <div class="head">
            <span>${title}</span>
            <button class="button" id="${_id}">More</button>
          </div>
          <div class="extra">
            <p>${articleContent.content}</p>
          </div>`;
  
        const button = div.querySelector('button');
        button.addEventListener('click', async (e) => {
          const extra = e.target.parentNode.parentNode.querySelector('.extra');
          if (e.target.textContent === 'More') {
            e.target.textContent = 'Less';
            extra.style.display = 'block';
          } else {
            e.target.textContent = 'More';
            extra.style.display = 'none';
          }
        });
  
        main.appendChild(div);
      }
    } catch (err) {
      console.log('Error in fetch request', err);
    }
  }
  
  solution();
  