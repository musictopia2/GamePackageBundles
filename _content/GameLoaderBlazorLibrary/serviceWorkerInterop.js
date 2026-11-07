export function registerAndListen(dotNetHelper) {
    if ('serviceWorker' in navigator) {
        navigator.serviceWorker.register('/service-worker.js').then(reg => {
            reg.addEventListener('updatefound', () => {
                const newWorker = reg.installing;
                if (!newWorker) return;

                newWorker.addEventListener('statechange', () => {
                    if (newWorker.state === 'installed' && navigator.serviceWorker.controller) {
                        dotNetHelper.invokeMethodAsync('NotifyUpdateAvailable');
                    }
                });
            });

            setInterval(() => {
                reg.update().catch(error => {
                    console.debug('Update check unavailable; keeping the current version.', error);
                });
            }, 60_000);
        });
    }
}