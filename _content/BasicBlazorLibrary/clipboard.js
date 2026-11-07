export function clipboardCopy(text) {
    navigator.clipboard.writeText(text).catch(function (error) {
        alert(error);
    });
}