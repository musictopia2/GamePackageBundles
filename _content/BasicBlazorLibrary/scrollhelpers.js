export function scrollDownOnePage(container, buffer = 100) {
    if (!container) return;

    const clientHeight = container.clientHeight;
    const scrollAmount = clientHeight - buffer;
    const maxScrollTop = container.scrollHeight - clientHeight;
    const newScrollTop = Math.min(container.scrollTop + scrollAmount, maxScrollTop);
    container.scrollTop = newScrollTop;
}
export function scrollUpOnePage(container, buffer = 100) {
    if (!container) return;

    const clientHeight = container.clientHeight;
    const scrollAmount = clientHeight - buffer;
    const newScrollTop = Math.max(container.scrollTop - scrollAmount, 0);
    container.scrollTop = newScrollTop;
}
export function scrollToTop(container, smooth = false) {
    if (!container) return;

    if (smooth) {
        container.scrollTo({ top: 0, behavior: 'smooth' });
    } else {
        container.scrollTop = 0;
    }
}