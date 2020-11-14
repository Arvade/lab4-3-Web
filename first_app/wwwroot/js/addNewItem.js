(function () {
    const alertElement = document.getElementById("success-alert");
    const formElement = document.forms[0];
    const addNewItem = async () => {
        const payload = {
            Name: formElement.querySelector("#Name").value,
            Description: formElement.querySelector("#Description").value,
            IsVisible: formElement.querySelector("#IsVisible").checked
        }

        console.log('payload : ', payload);
        const response = await fetch("/Item/api/add", {
            method: "POST",
            headers: {
                "Content-type": "application/json"
            },
            body: JSON.stringify(payload)
        });

        const responseJson = await response.json();
        console.log('Received response: ', responseJson, response);
        if (response.status === 200) {
            alertElement.style.display = "block";
        }
    };
    window.addEventListener("load", () => {
        formElement.addEventListener("submit", event => {
            event.preventDefault();
            addNewItem().then(() => console.log("added successfully"));
        });
    });
})();
