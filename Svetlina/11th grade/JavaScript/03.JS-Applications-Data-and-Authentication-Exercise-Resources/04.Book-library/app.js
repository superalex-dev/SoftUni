function attachEvents() {
    const tableBody = document.querySelector("tbody");
    const loadBtn = document.querySelector("#loadBooks");
    const submitCreate = document.querySelector("#submitCreate");
    const submitEdit = document.querySelector("#submitEdit");
    let isEdit = false;
    let editId = "";

    loadBtn.addEventListener("click", loadBooks);
    submitCreate.addEventListener("click", createBook);
    submitEdit.addEventListener("click", editBook);

    async function createBook(e) {
        e.preventDefault();

        const formData = new FormData(document.querySelector("form"));

        const title = formData.get("title");
        const author = formData.get("author");

        if (title === "" || author === "") {
            return alert("All fields are required!");
        }

        const book = {
            title,
            author,
        };

        try {
            await fetch("http://localhost:3030/jsonstore/collections/books", {
                method: "post",
                headers: {"Content-Type": "application/json"},
                body: JSON.stringify(book),
            });
        } catch (error) {
            alert(error);
        }

        loadBooks();
    }

    async function editBook(e) {
        e.preventDefault();

        const formData = new FormData(document.querySelector("form"));

        const title = formData.get("title");
        const author = formData.get("author");

        if (title === "" || author === "") {
            return alert("All fields are required!");
        }

        const book = {
            title,
            author,
        };

        try {
            await fetch(
                `http://localhost:3030/jsonstore/collections/books/${editId}`,
                {
                    method: "PUT",
                    headers: {"Content-Type": "application/json"},
                    body: JSON.stringify(book),
                }
            );
        } catch (error) {
            alert(error);
        }

        loadBooks();
    }

    async function loadBooks() {
        try {
            const response = await fetch(
                "http://localhost:3030/jsonstore/collections/books"
            );
            const data = await response.json();

            tableBody.innerHTML = "";

            Object.values(data).forEach((book) => {
                const tr = document.createElement("tr");
                tr.setAttribute(
                    "data-id",
                    Object.keys(data).find((key) => data[key] === book)
                );

                const tdTitle = document.createElement("td");
                tdTitle.textContent = book.title;

                const tdAuthor = document.createElement("td");
                tdAuthor.textContent = book.author;

                const tdButtons = document.createElement("td");

                const editBtn = document.createElement("button");
                editBtn.textContent = "Edit";

                editBtn.addEventListener("click", () => {
                    isEdit = true;
                    editId = tr.getAttribute("data-id");
                    loadForm();
                });

                const deleteBtn = document.createElement("button");
                deleteBtn.textContent = "Delete";

                deleteBtn.addEventListener("click", async () => {
                    const id = tr.getAttribute("data-id");

                    try {
                        await fetch(
                            `http://localhost:3030/jsonstore/collections/books/${id}`,
                            {
                                method: "delete",
                            }
                        );
                    } catch (error) {
                        alert(error);
                    }

                    loadBooks();
                });

                tdButtons.appendChild(editBtn);
                tdButtons.appendChild(deleteBtn);

                tr.appendChild(tdTitle);
                tr.appendChild(tdAuthor);
                tr.appendChild(tdButtons);

                tableBody.appendChild(tr);
            });
        } catch (error) {
            alert(error);
        }

        isEdit = false;
        editId = "";
        loadForm();
    }
    function loadForm() {
        const form = document.querySelector("form");
        const submitCreate = document.querySelector("#submitCreate");
        const submitEdit = document.querySelector("#submitEdit");

        if (isEdit) {
            submitCreate.style.display = "none";
            submitEdit.style.display = "inline-block";
        } else {
            submitCreate.style.display = "inline-block";
            submitEdit.style.display = "none";
        }
    }
    loadForm();
}

attachEvents();