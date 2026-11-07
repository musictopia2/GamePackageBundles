var slider;
var slides;
let isDragging = false;
let startPos = 0;
let currentTranslate = 0;
let prevTranslate = 0;
let animationID = 0;
let currentIndex = 0;
let maxValue = 0;
let realpreviousTranslate = 0;
let isStarted = true;
export function start() {
    isDragging = false;
    startPos = 0;
    currentTranslate = 0;
    prevTranslate = 0;
    animationID = 0;
    currentIndex = 0;
    maxValue = 0;
    realpreviousTranslate = 0;
    isStarted = true;
    slider = document.querySelector('.simple-slider-container');
    slides = Array.from(document.querySelectorAll('.simple-slide'));
    slides.forEach((slide, index) => {
        //touch events
        slide.addEventListener('touchstart', touchStart(index));
        slide.addEventListener('touchend', touchEnd);
        slide.addEventListener('touchmove', touchMove);
        //mouse events
        slide.addEventListener('mousedown', touchStart(index));
        slide.addEventListener('mouseup', touchEnd);
        slide.addEventListener('mouseleave', touchEnd);
        slide.addEventListener('mousemove', touchMove);
    });
    window.oncontextmenu = function (e) {
        e.preventDefault();
        e.stopPropagation(); //this is iffy for my purposes though.
        return false;
    }
}
function touchStart(index) {
    return function (event) {
        currentIndex = index;
        startPos = getPositionX(event);
        if (currentIndex == slides.length - 1) {
            maxValue = currentTranslate; //hopefully this simple.
        }
        isDragging = true;
        realpreviousTranslate = 0;
        isStarted = true;
        animationID = requestAnimationFrame(animation);
        slider.style.cursor = 'grabbing';
    }
}
function touchEnd() {
    isDragging = false;
    isStarted = false;
    cancelAnimationFrame(animationID);
    slider.style.cursor = 'grab';
    const finPrevious = realpreviousTranslate != 0 ? realpreviousTranslate : prevTranslate;
    const movedBy = currentTranslate - finPrevious;
    if (movedBy < -100 && currentIndex < slides.length - 1) {
        currentIndex += 1;
    }
    if (movedBy > 100 && currentIndex > 0) {
        currentIndex -= 1;
    }
    realpreviousTranslate = 0;
    setPositionByIndex();
}
function touchMove(event) {
    if (isDragging) {
        const currentPosition = getPositionX(event);
        const temp = prevTranslate + currentPosition - startPos;
        if (temp < currentTranslate && currentTranslate > 0 && isStarted) {
            isStarted = false;
            realpreviousTranslate = currentTranslate;
        }
        if (temp > currentTranslate && currentTranslate < maxValue && isStarted) {
            isStarted = false;
            realpreviousTranslate = currentTranslate;
        }
        currentTranslate = temp;
    }
}
function getPositionX(event) {
    return event.type.includes('mouse') ? event.pageX :
        event.touches[0].clientX;
}
function animation() {
    setSliderPosition();
    if (isDragging) requestAnimationFrame(animation);
}
function setSliderPosition() {
    var temps = canSetSlider();
    if (temps) {
        slider.style.transform = `translateX(${currentTranslate}px)`
    }
}
function canSetSlider() {
    if (currentTranslate > 0) {
        return false;
    }
    if (maxValue == 0) {
        return true;
    }
    if (currentTranslate < maxValue) {
        return false;
    }
    return true;
}

function setPositionByIndex() {
    currentTranslate = currentIndex * -window.innerWidth;
    prevTranslate = currentTranslate;
    setSliderPosition();
}