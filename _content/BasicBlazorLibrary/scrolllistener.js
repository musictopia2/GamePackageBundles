var timer = null;
export function starty(dotnetRef, element) {
	if (element == undefined || element == null) {
		return;
	}
	element.addEventListener('scroll', function () {
		dotnetRef.invokeMethodAsync('ScrollChanged', element.scrollTop);
	}, false);
}
export function startx(dotnetRef, element) {
	if (element == undefined || element == null) {
		return;
	}
	element.addEventListener('touchmove', function (event) {
		event.preventDefault();
		//figure out what else i can do.
		//good news is scrolling not allowed anymore.
		//bad news is not sure what else i can do.
	}, false);
	element.addEventListener('scroll', function () {
		if (timer !== null) {
			clearTimeout(timer);
		}
		timer = setTimeout(function () {
			console.log(element.scrollLeft);
			dotnetRef.invokeMethodAsync('ScrollChanged', element.scrollLeft);
		}, 150);
	}, false);
}
