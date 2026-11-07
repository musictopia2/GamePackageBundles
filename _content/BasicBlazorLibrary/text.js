//export function highlighttext(element, startat) {
//    console.log(element.value);
//    element.setSelectionRange(startat, 100000);
//    element.focus(); //this time, use the javascript focus method.
//}

export function setInitialText(element, value) {
    element.value = value;
    element.setSelectionRange(0, 100000); //i like the idea of selecting all text when setting initial value.
    //i don't think we can focus necessarily.  if needed, will be done later.
}
export function clearText(element) {
    element.value = ""; //can't necessarily focus though.  because maybe its going to another field though.
}

export function setvalueandhighlight(element, value, startat) {
    element.value = value;
    element.setSelectionRange(startat, 100000);
    element.focus();
}
export function setvaluealone(element, value) {
    element.value = value;
}

export function getValue(element) {
    return element.value;
}

export function start(dotnetRef, element) {
    if (element == undefined || element == null) {
        return;
    }
    //if using my hotkeys, then i am either on my own for tabs or needs a function to disable tabs.

    element.addEventListener('keypress', function (evt) {
        evt.preventDefault();
        var value = String.fromCharCode(evt.keyCode);
        if (evt.keyCode == 13) {
            value = "Enter";
        }
        //else if (evt.keyCode == )
        dotnetRef.invokeMethodAsync('KeyPress', value);
    });

}