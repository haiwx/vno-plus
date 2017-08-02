'use strict';

(function () {
  'use strict';

    var cacheVersion = '-toolbox-v1';
    var dynamicVendorCacheName = 'dynamic-vendor' + cacheVersion;
    var staticVendorCacheName = 'static-vendor' + cacheVersion;
    var staticAssetsCacheName = 'static-assets' + cacheVersion;
    var contentCacheName = 'content' + cacheVersion;
    var maxEntries = 50;

    self.importScripts('assets/js/sw-toolbox.js');

    self.toolbox.options.debug = false;

    // Cache own static assets
    self.toolbox.router.get('/assets/(.*)', self.toolbox.cacheFirst, {
        cache: {
          name: staticAssetsCacheName,
          maxEntries: maxEntries
        }
    });

    // Do not cache changyan
    self.toolbox.router.get('/(.*)', self.toolbox.networkOnly, {
        origin: /sohu\.com/
    });
    self.toolbox.router.get('/(.*)', self.toolbox.networkOnly, {
        origin: /itc\.cn/
    });


    self.toolbox.router.get('/content/(.*)', self.toolbox.fastest, {
        cache: {
          name: contentCacheName,
          maxEntries: maxEntries
        }
    });

    self.toolbox.router.get('/*', function (request, values, options) {
        if (!request.url.match(/(\/ghost\/|\/page\/)/) && request.headers.get('accept').includes('text/html')) {
            return self.toolbox.fastest(request, values, options);
        } else {
            return self.toolbox.networkOnly(request, values, options);
        }
        }, {
        cache: {
            name: contentCacheName,
            maxEntries: maxEntries
        }
    });

    // immediately activate this serviceworker
    self.addEventListener('install', function (event) {
        return event.waitUntil(self.skipWaiting());
    });

    self.addEventListener('activate', function (event) {
        return event.waitUntil(self.clients.claim());
    }); 

})();
