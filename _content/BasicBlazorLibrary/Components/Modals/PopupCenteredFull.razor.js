export function center(element) {
    var w = document.documentElement.clientWidth,
        h = document.documentElement.clientHeight;
    element.style.position = 'absolute';
    element.style.display = '';
    element.style.left = (w - element.offsetWidth) / 2 + 'px';
    element.style.top = (h - element.offsetHeight) / 2 +
        window.pageYOffset + 'px';
}