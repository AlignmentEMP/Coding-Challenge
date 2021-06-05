setTimeout(function () {
    document.getElementById("customHeader").className = "destinationFade";
    setTimeout(function () {
        document.getElementById("customImage").className = "destinationFade";
        setTimeout(function () {
            document.getElementById("customMainBody").className = "destinationFade";
            setTimeout(function () {
                document.getElementById("customTable1").className = "destinationFade firstTable";
                setTimeout(function () {
                    document.getElementById("customTable2").className = "destinationFade secondTable";
                    setTimeout(function () {
                        document.getElementById("customCont").className = "destinationFade";
                    }, 200);
                }, 200);
            }, 200);
        }, 200);
    }, 200);
}, 200);

//Prevents the function from being spammed
var copyCooldown = false;

//Since innerHTML can't be selected, we have to create a textarea, copy the value to the .value property, copy, then remove the element
function copyTextFunc(textID) {
    if (!copyCooldown) {
        var tempTextArea = document.createElement("textarea");
        var textToCopy = document.getElementById(textID);

        document.body.appendChild(tempTextArea);
        tempTextArea.value = textToCopy.innerHTML.trim();
        tempTextArea.select();

        document.execCommand("copy");
        tempTextArea.remove();

        var restore = textToCopy.innerHTML;
        textToCopy.innerHTML = textToCopy.innerHTML.concat(" has been copied to the clipboard!");
        copyCooldown = true;
        setTimeout(function () {
            textToCopy.innerHTML = restore;
            copyCooldown = false;
        }, 1000)
    }
}