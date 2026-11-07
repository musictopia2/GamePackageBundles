export function highlighttext(element, startat) {
    console.log(element.value);
    element.setSelectionRange(startat, 100000);
    element.focus(); //this time, use the javascript focus method.
}