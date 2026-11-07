var wasrippedoff = true;

export function start(dotnetRef, element) {
    if (element == undefined || element == null) {
        return;
    }

    if (wasrippedoff == true) {
        document.onhelp = new Function("return false;");
        window.onhelp = new Function("return false;");

        document.onkeydown = function (evt) {
            if (evt == null) {
                evt = event;
            }

            if (testKeyCode(evt, 112)) { // F1
                cancelKeyEvent(evt);
                return false;
            }

            if (testKeyCode(evt, 114)) { // F3
                cancelKeyEvent(evt);
                return false;
            }

            if (testKeyCode(evt, 116)) { // F5
                cancelKeyEvent(evt);
                return false;
            }

            if (testKeyCode(evt, 9)) { // Tab
                cancelKeyEvent(evt);
                return false;
            }
        };

        function cancelKeyEvent(evt) {
            if (window.createPopup) {
                evt.keyCode = 0;
            } else {
                evt.preventDefault();
            }
        }

        function testKeyCode(evt, intKeyCode) {
            if (window.createPopup) {
                return evt.keyCode == intKeyCode;
            }

            return evt.which == intKeyCode;
        }

        wasrippedoff = false;
    }

    const pressedKeys = new Set();

    element.addEventListener("keyup", function (evt) {
        // Ignore releases for keys pressed in another control.
        if (!pressedKeys.delete(evt.keyCode)) {
            return;
        }

        dotnetRef.invokeMethodAsync("KeyUp", evt.keyCode);

        if (evt.keyCode != 116 && evt.keyCode != 123) {
            evt.preventDefault();
        }
    });

    element.addEventListener("keydown", function (evt) {
        pressedKeys.add(evt.keyCode);
        dotnetRef.invokeMethodAsync("KeyDown", evt.keyCode);
    });

    element.addEventListener("blur", function () {
        pressedKeys.clear();
    });
}