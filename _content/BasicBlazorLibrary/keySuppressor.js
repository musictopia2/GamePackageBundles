let isAttachedFunctionKeys = false;
let isAttachedArrowKeys = false;

function suppressFunctionKeysHandler(evt) {
    const key = evt.key;
    // F1 to F11, but not F12 (allowed)
    if (/^F\d{1,2}$/.test(key) && key !== "F12") {
        evt.preventDefault();
    }
}

function suppressArrowKeysHandler(evt) {
    if (["ArrowUp", "ArrowDown", "ArrowLeft", "ArrowRight"].includes(evt.key)) {
        evt.preventDefault();
    }
}

export function disableFunctionKeys() {
    if (isAttachedFunctionKeys) return;
    window.addEventListener("keydown", suppressFunctionKeysHandler, true);
    window.addEventListener("keyup", suppressFunctionKeysHandler, true);
    isAttachedFunctionKeys = true;
}

export function enableFunctionKeys() {
    if (!isAttachedFunctionKeys) return;
    window.removeEventListener("keydown", suppressFunctionKeysHandler, true);
    window.removeEventListener("keyup", suppressFunctionKeysHandler, true);
    isAttachedFunctionKeys = false;
}

export function disableArrowKeys() {
    if (isAttachedArrowKeys) return;
    window.addEventListener("keydown", suppressArrowKeysHandler, true);
    window.addEventListener("keyup", suppressArrowKeysHandler, true);
    isAttachedArrowKeys = true;
}

export function enableArrowKeys() {
    if (!isAttachedArrowKeys) return;
    window.removeEventListener("keydown", suppressArrowKeysHandler, true);
    window.removeEventListener("keyup", suppressArrowKeysHandler, true);
    isAttachedArrowKeys = false;
}