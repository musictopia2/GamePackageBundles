export function convertRemToPixels(rem) {
    return rem * parseFloat(getComputedStyle(document.documentElement).fontSize);
}
export function getcontainerheight(element) {
    if (element == null) {
        return 0;
    }
    return element.clientHeight;
}
export function getcontainerwidth(element) {
    if (element == null) {
        return 0;
    }
    return element.clientWidth;
}

export function getElementHeight(element) {
    if (element == null) {
        return 0;
    }
    const rect = element.getBoundingClientRect();
    return rect ? rect.height : 0;
}

export function getcontainertop(element) {
    var bodyRect = document.body.getBoundingClientRect();
    var elementRect = element.getBoundingClientRect();
    var offset = elementRect.top - bodyRect.top;
    return offset;
}
export function getcontainerleft(element) {
    var bodyRect = document.body.getBoundingClientRect();
    var elementRect = element.getBoundingClientRect();
    var offset = elementRect.left - bodyRect.left;
    return offset;
}
export function getparentHeight(element) {
    if (element == null) {
        return 0;
    }
    return element.parentElement.clientHeight;
}
export function getparentWidth(element) {
    //return 0;
    if (element == null) {
        return 0;
    }
    return element.parentElement.clientWidth;
}
export function scrollToTopElement(element) {
    if (element && element.firstElementChild) {
        element.scrollTop = 0;
    }
    
}
export function scrollToTopWindow() {
    consol.log("scrollToTopWindow called");
    window.scrollTo(0, 0);
}
export function getbrowserheight() {
    return window.innerHeight;
}
export function getbrowserwidth() {
    return window.innerWidth;
}
export function refreshbrowser() {
    window.location.reload();
}
export function update() {
    window.location.href = window.location.href.replace(/#.*$/, '');
}