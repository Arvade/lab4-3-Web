(function () {
    const alertElement = document.getElementById("success-alert");
    const formElement = document.forms[0];

    const itemsElement= document.getElementById("items-source");

    const getItems = async () => {
        const response = await fetch("/Item/api/get-all", {
            method: "GET",
            headers: {
                "Content-type": "application/json"
            }
        });

        const responseJson = await response.json();
        console.log("Received response : ", responseJson);
    }
})();
