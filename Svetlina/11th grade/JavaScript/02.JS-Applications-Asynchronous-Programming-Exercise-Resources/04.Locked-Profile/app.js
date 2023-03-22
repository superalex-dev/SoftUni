async function lockedProfile() {
    try {
      const response = await fetch('http://localhost:3030/jsonstore/advanced/profiles');
      if (!response.ok) {
        throw new Error(`HTTP error! status: ${response.status}`);
      }
      const profiles = await response.json();
      const main = document.querySelector('#main');
  
      for (const [key, profile] of Object.entries(profiles)) {
        const profileDiv = document.createElement('div');
        profileDiv.classList.add('profile');
  
        profileDiv.innerHTML = `
          <img src="./iconProfile2.png" class="userIcon" />
          <label>Lock</label>
          <input type="radio" name="userLock" value="lock" checked>
          <label>Unlock</label>
          <input type="radio" name="userLock" value="unlock"><br>
          <hr>
          <label>Username</label>
          <input type="text" name="userUsername" value="${profile.username}" disabled readonly />
          <div id="userHiddenFields" style="display: none">
            <hr>
            <label>Email:</label>
            <input type="email" name="userEmail" value="${profile.email}" disabled readonly />
            <label>Age:</label>
            <input type="email" name="userAge" value="${profile.age}" disabled readonly />
          </div>
        `;
  
        const button = document.createElement('button');
        button.textContent = 'Show more';
        button.addEventListener('click', () => {
          const hiddenFields = profileDiv.querySelector('#userHiddenFields');
          const unlockInput = profileDiv.querySelector('input[name="userLock"][value="unlock"]');
          if (unlockInput.checked) {
            if (hiddenFields.style.display === 'block') {
              hiddenFields.style.display = 'none';
              button.textContent = 'Show more';
            } else {
              hiddenFields.style.display = 'block';
              button.textContent = 'Hide it';
            }
          }
        });
  
        profileDiv.appendChild(button);
        main.appendChild(profileDiv);
      }
    } catch (error) {
      console.log('Error in fetch request ' + error);
    }
  }
  