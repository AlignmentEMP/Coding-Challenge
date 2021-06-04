var copyCooldown = false;

function copyTextFunc(textID) {
    if (!copyCooldown) {
        var tempTextArea = document.createElement("textarea");
        var textToCopy = document.getElementById(textID);

        document.body.appendChild(tempTextArea);
        tempTextArea.value = textToCopy.innerHTML.trim();
        tempTextArea.select();

        document.execCommand("copy");

        var restore = textToCopy.innerHTML;
        textToCopy.innerHTML = textToCopy.innerHTML.concat(" has been copied to the clipboard!");
        copyCooldown = true;
        setTimeout(function () {
            textToCopy.innerHTML = restore;
            copyCooldown = false;
        }, 1000)
    }
}