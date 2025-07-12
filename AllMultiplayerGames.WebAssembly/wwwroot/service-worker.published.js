// Caution! Be sure you understand the caveats before publishing an application with
// offline support. See https://aka.ms/blazor-offline-considerations
self.importScripts('./service-worker-assets.js');

//start
const version = 9.38;
//end

const cacheNamePrefix = 'offline-cache-';
const cacheName = `${cacheNamePrefix}${self.assetsManifest.version}`;
const offlineAssetsInclude = [/\.dll$/, /\.pdb$/, /\.wasm/, /\.html/, /\.js$/, /\.json$/, /\.css$/, /\.woff$/, /\.png$/, /\.jpe?g$/, /\.gif$/, /\.ico$/, /\.blat$/, /\.dat$/];
const offlineAssetsExclude = [/^service-worker\.js$/];

self.addEventListener('install', event => {
    console.info('Service worker: Install');
    event.waitUntil((async () => {
        const assetsRequests = self.assetsManifest.assets
            .filter(asset => offlineAssetsInclude.some(pattern => pattern.test(asset.url)))
            .filter(asset => !offlineAssetsExclude.some(pattern => pattern.test(asset.url)))
            .map(asset => new Request(asset.url, { integrity: asset.hash }));
        const cache = await caches.open(cacheName);
        await cache.addAll(assetsRequests);
        await self.skipWaiting();
    })());
});

self.addEventListener('activate', event => {
    console.info('Service worker: Activate');
    event.waitUntil((async () => {
        const cacheKeys = await caches.keys();
        await Promise.all(
            cacheKeys
                .filter(key => key.startsWith(cacheNamePrefix) && key !== cacheName)
                .map(key => caches.delete(key))
        );
        await self.clients.claim();
    })());
});

self.addEventListener('fetch', event => {
    if (event.request.method !== 'GET') return;
    // Bypass caching for SignalR hub requests
    if (event.request.url.includes('/hub') || event.request.headers.get('Upgrade') === 'websocket') {
        // Just fetch directly without caching
        event.respondWith(fetch(event.request));
        return;
    }
    event.respondWith((async () => {
        const cache = await caches.open(cacheName);
        const cachedResponse = await cache.match(event.request);

        const networkFetch = fetch(event.request).then(response => {
            if (response && response.status === 200) {
                cache.put(event.request, response.clone());
            }
            return response;
        }).catch(() => cachedResponse); // fallback to cache if network fails

        return cachedResponse || networkFetch;
    })());
});