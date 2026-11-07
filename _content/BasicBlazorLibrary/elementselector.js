export function start(dotnetRef) {
    document.addEventListener("click", function () {
        var y = document.activeElement.tagName;

        if (y == "INPUT") {
            var x = document.activeElement.id;
            dotnetRef.invokeMethodAsync('JsMainClicked', x);
        }
        else {
            dotnetRef.invokeMethodAsync('JsOtherClicked');
        }
    });
}