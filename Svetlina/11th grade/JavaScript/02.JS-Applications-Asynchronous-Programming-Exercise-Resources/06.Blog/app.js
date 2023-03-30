function attachEvents() {
    const buttonPosts = document.getElementById('btnLoadPosts');
    const buttonComments = document.getElementById('btnViewPost');
    const select = document.getElementById('posts');
    const postTitle = document.getElementById('post-title');
    const postBody = document.getElementById('post-body');
    const postComments = document.getElementById('post-comments');

    buttonPosts.addEventListener('click', loadPosts);
    buttonComments.addEventListener('click', displayPost);

    async function loadPosts() {
        try {
            const response = await fetch('http://localhost:3030/jsonstore/blog/posts');
            const data = await response.json();

            Object.values(data).forEach((post) => {
                const option = document.createElement('option');
                option.value = post.id;
                option.textContent = post.title;
                select.appendChild(option);
            });
        } catch (error) {
            console.log(error);
        }
    }

    async function displayPost() {
        const postId = select.value;

        try {
            const commentsResponse = await fetch('http://localhost:3030/jsonstore/blog/comments');
            const commentsData = await commentsResponse.json();
            const comments = Object.values(commentsData).filter((comment) => comment.postId == postId);

            postComments.innerHTML = '';

            comments.forEach((comment) => {
                const li = document.createElement('li');
                li.textContent = comment.text;
                postComments.appendChild(li);
            });

            const postResponse = await fetch(`http://localhost:3030/jsonstore/blog/posts/${postId}`);
            const postData = await postResponse.json();

            postTitle.textContent = postData.title;
            postBody.textContent = postData.body;
        } catch (error) {
            console.log(error);
        }
    }
}

attachEvents();
