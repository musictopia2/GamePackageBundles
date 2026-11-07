//! Licensed to the .NET Foundation under one or more agreements.
//! The .NET Foundation licenses this file to you under the MIT license.

var e=!1;const t=async()=>WebAssembly.validate(new Uint8Array([0,97,115,109,1,0,0,0,1,4,1,96,0,0,3,2,1,0,10,8,1,6,0,6,64,25,11,11])),o=async()=>WebAssembly.validate(new Uint8Array([0,97,115,109,1,0,0,0,1,5,1,96,0,1,123,3,2,1,0,10,15,1,13,0,65,1,253,15,65,2,253,15,253,128,2,11])),n=async()=>WebAssembly.validate(new Uint8Array([0,97,115,109,1,0,0,0,1,5,1,96,0,1,123,3,2,1,0,10,10,1,8,0,65,0,253,15,253,98,11])),r=Symbol.for("wasm promise_control");function i(e,t){let o=null;const n=new Promise((function(n,r){o={isDone:!1,promise:null,resolve:t=>{o.isDone||(o.isDone=!0,n(t),e&&e())},reject:e=>{o.isDone||(o.isDone=!0,r(e),t&&t())}}}));o.promise=n;const i=n;return i[r]=o,{promise:i,promise_control:o}}function s(e){return e[r]}function a(e){e&&function(e){return void 0!==e[r]}(e)||Be(!1,"Promise is not controllable")}const l="__mono_message__",c=["debug","log","trace","warn","info","error"],d="MONO_WASM: ";let u,f,m,g,p,h;function w(e){g=e}function b(e){if(Pe.diagnosticTracing){const t="function"==typeof e?e():e;console.debug(d+t)}}function y(e,...t){console.info(d+e,...t)}function v(e,...t){console.info(e,...t)}function E(e,...t){console.warn(d+e,...t)}function _(e,...t){if(t&&t.length>0&&t[0]&&"object"==typeof t[0]){if(t[0].silent)return;if(t[0].toString)return void console.error(d+e,t[0].toString())}console.error(d+e,...t)}function x(e,t,o){return function(...n){try{let r=n[0];if(void 0===r)r="undefined";else if(null===r)r="null";else if("function"==typeof r)r=r.toString();else if("string"!=typeof r)try{r=JSON.stringify(r)}catch(e){r=r.toString()}t(o?JSON.stringify({method:e,payload:r,arguments:n.slice(1)}):[e+r,...n.slice(1)])}catch(e){m.error(`proxyConsole failed: ${e}`)}}}function j(e,t,o){f=t,g=e,m={...t};const n=`${o}/console`.replace("https://","wss://").replace("http://","ws://");u=new WebSocket(n),u.addEventListener("error",A),u.addEventListener("close",S),function(){for(const e of c)f[e]=x(`console.${e}`,T,!0)}()}function R(e){let t=30;const o=()=>{u?0==u.bufferedAmount||0==t?(e&&v(e),function(){for(const e of c)f[e]=x(`console.${e}`,m.log,!1)}(),u.removeEventListener("error",A),u.removeEventListener("close",S),u.close(1e3,e),u=void 0):(t--,globalThis.setTimeout(o,100)):e&&m&&m.log(e)};o()}function T(e){u&&u.readyState===WebSocket.OPEN?u.send(e):m.log(e)}function A(e){m.error(`[${g}] proxy console websocket error: ${e}`,e)}function S(e){m.debug(`[${g}] proxy console websocket closed: ${e}`,e)}function D(){Pe.preferredIcuAsset=O(Pe.config);let e="invariant"==Pe.config.globalizationMode;if(!e)if(Pe.preferredIcuAsset)Pe.diagnosticTracing&&b("ICU data archive(s) available, disabling invariant mode");else{if("custom"===Pe.config.globalizationMode||"all"===Pe.config.globalizationMode||"sharded"===Pe.config.globalizationMode){const e="invariant globalization mode is inactive and no ICU data archives are available";throw _(`ERROR: ${e}`),new Error(e)}Pe.diagnosticTracing&&b("ICU data archive(s) not available, using invariant globalization mode"),e=!0,Pe.preferredIcuAsset=null}const t="DOTNET_SYSTEM_GLOBALIZATION_INVARIANT",o=Pe.config.environmentVariables;if(void 0===o[t]&&e&&(o[t]="1"),void 0===o.TZ)try{const e=Intl.DateTimeFormat().resolvedOptions().timeZone||null;e&&(o.TZ=e)}catch(e){y("failed to detect timezone, will fallback to UTC")}}function O(e){var t;if((null===(t=e.resources)||void 0===t?void 0:t.icu)&&"invariant"!=e.globalizationMode){const t=e.applicationCulture||(ke?globalThis.navigator&&globalThis.navigator.languages&&globalThis.navigator.languages[0]:Intl.DateTimeFormat().resolvedOptions().locale),o=e.resources.icu;let n=null;if("custom"===e.globalizationMode){if(o.length>=1)return o[0].name}else t&&"all"!==e.globalizationMode?"sharded"===e.globalizationMode&&(n=function(e){const t=e.split("-")[0];return"en"===t||["fr","fr-FR","it","it-IT","de","de-DE","es","es-ES"].includes(e)?"icudt_EFIGS.dat":["zh","ko","ja"].includes(t)?"icudt_CJK.dat":"icudt_no_CJK.dat"}(t)):n="icudt.dat";if(n)for(let e=0;e<o.length;e++){const t=o[e];if(t.virtualPath===n)return t.name}}return e.globalizationMode="invariant",null}(new Date).valueOf();const C=class{constructor(e){this.url=e}toString(){return this.url}};async function k(e,t){try{const o="function"==typeof globalThis.fetch;if(Se){const n=e.startsWith("file://");if(!n&&o)return globalThis.fetch(e,t||{credentials:"same-origin"});p||(h=Ne.require("url"),p=Ne.require("fs")),n&&(e=h.fileURLToPath(e));const r=await p.promises.readFile(e);return{ok:!0,headers:{length:0,get:()=>null},url:e,arrayBuffer:()=>r,json:()=>JSON.parse(r),text:()=>{throw new Error("NotImplementedException")}}}if(o)return globalThis.fetch(e,t||{credentials:"same-origin"});if("function"==typeof read)return{ok:!0,url:e,headers:{length:0,get:()=>null},arrayBuffer:()=>new Uint8Array(read(e,"binary")),json:()=>JSON.parse(read(e,"utf8")),text:()=>read(e,"utf8")}}catch(t){return{ok:!1,url:e,status:500,headers:{length:0,get:()=>null},statusText:"ERR28: "+t,arrayBuffer:()=>{throw t},json:()=>{throw t},text:()=>{throw t}}}throw new Error("No fetch implementation available")}function I(e){return"string"!=typeof e&&Be(!1,"url must be a string"),!M(e)&&0!==e.indexOf("./")&&0!==e.indexOf("../")&&globalThis.URL&&globalThis.document&&globalThis.document.baseURI&&(e=new URL(e,globalThis.document.baseURI).toString()),e}const U=/^[a-zA-Z][a-zA-Z\d+\-.]*?:\/\//,P=/[a-zA-Z]:[\\/]/;function M(e){return Se||Ie?e.startsWith("/")||e.startsWith("\\")||-1!==e.indexOf("///")||P.test(e):U.test(e)}let L,N=0;const $=[],z=[],W=new Map,F={"js-module-threads":!0,"js-module-runtime":!0,"js-module-dotnet":!0,"js-module-native":!0,"js-module-diagnostics":!0},B={...F,"js-module-library-initializer":!0},V={...F,dotnetwasm:!0,heap:!0,manifest:!0},q={...B,manifest:!0},H={...B,dotnetwasm:!0},J={dotnetwasm:!0,symbols:!0},Z={...B,dotnetwasm:!0,symbols:!0},Q={symbols:!0};function G(e){return!("icu"==e.behavior&&e.name!=Pe.preferredIcuAsset)}function K(e,t,o){null!=t||(t=[]),Be(1==t.length,`Expect to have one ${o} asset in resources`);const n=t[0];return n.behavior=o,X(n),e.push(n),n}function X(e){V[e.behavior]&&W.set(e.behavior,e)}function Y(e){Be(V[e],`Unknown single asset behavior ${e}`);const t=W.get(e);if(t&&!t.resolvedUrl)if(t.resolvedUrl=Pe.locateFile(t.name),F[t.behavior]){const e=ge(t);e?("string"!=typeof e&&Be(!1,"loadBootResource response for 'dotnetjs' type should be a URL string"),t.resolvedUrl=e):t.resolvedUrl=ce(t.resolvedUrl,t.behavior)}else if("dotnetwasm"!==t.behavior)throw new Error(`Unknown single asset behavior ${e}`);return t}function ee(e){const t=Y(e);return Be(t,`Single asset for ${e} not found`),t}let te=!1;async function oe(){if(!te){te=!0,Pe.diagnosticTracing&&b("mono_download_assets");try{const e=[],t=[],o=(e,t)=>{!Z[e.behavior]&&G(e)&&Pe.expected_instantiated_assets_count++,!H[e.behavior]&&G(e)&&(Pe.expected_downloaded_assets_count++,t.push(se(e)))};for(const t of $)o(t,e);for(const e of z)o(e,t);Pe.allDownloadsQueued.promise_control.resolve(),Promise.all([...e,...t]).then((()=>{Pe.allDownloadsFinished.promise_control.resolve()})).catch((e=>{throw Pe.err("Error in mono_download_assets: "+e),Xe(1,e),e})),await Pe.runtimeModuleLoaded.promise;const n=async e=>{const t=await e;if(t.buffer){if(!Z[t.behavior]){t.buffer&&"object"==typeof t.buffer||Be(!1,"asset buffer must be array-like or buffer-like or promise of these"),"string"!=typeof t.resolvedUrl&&Be(!1,"resolvedUrl must be string");const e=t.resolvedUrl,o=await t.buffer,n=new Uint8Array(o);pe(t),await Ue.beforeOnRuntimeInitialized.promise,Ue.instantiate_asset(t,e,n)}}else J[t.behavior]?("symbols"===t.behavior&&(await Ue.instantiate_symbols_asset(t),pe(t)),J[t.behavior]&&++Pe.actual_downloaded_assets_count):(t.isOptional||Be(!1,"Expected asset to have the downloaded buffer"),!H[t.behavior]&&G(t)&&Pe.expected_downloaded_assets_count--,!Z[t.behavior]&&G(t)&&Pe.expected_instantiated_assets_count--)},r=[],i=[];for(const t of e)r.push(n(t));for(const e of t)i.push(n(e));Promise.all(r).then((()=>{Ce||Ue.coreAssetsInMemory.promise_control.resolve()})).catch((e=>{throw Pe.err("Error in mono_download_assets: "+e),Xe(1,e),e})),Promise.all(i).then((async()=>{Ce||(await Ue.coreAssetsInMemory.promise,Ue.allAssetsInMemory.promise_control.resolve())})).catch((e=>{throw Pe.err("Error in mono_download_assets: "+e),Xe(1,e),e}))}catch(e){throw Pe.err("Error in mono_download_assets: "+e),e}}}let ne=!1;function re(){if(ne)return;ne=!0;const e=Pe.config,t=[];if(e.assets)for(const t of e.assets)"object"!=typeof t&&Be(!1,`asset must be object, it was ${typeof t} : ${t}`),"string"!=typeof t.behavior&&Be(!1,"asset behavior must be known string"),"string"!=typeof t.name&&Be(!1,"asset name must be string"),t.resolvedUrl&&"string"!=typeof t.resolvedUrl&&Be(!1,"asset resolvedUrl could be string"),t.hash&&"string"!=typeof t.hash&&Be(!1,"asset resolvedUrl could be string"),t.pendingDownload&&"object"!=typeof t.pendingDownload&&Be(!1,"asset pendingDownload could be object"),t.isCore?$.push(t):z.push(t),X(t);else if(e.resources){const o=e.resources;o.wasmNative||Be(!1,"resources.wasmNative must be defined"),o.jsModuleNative||Be(!1,"resources.jsModuleNative must be defined"),o.jsModuleRuntime||Be(!1,"resources.jsModuleRuntime must be defined"),K(z,o.wasmNative,"dotnetwasm"),K(t,o.jsModuleNative,"js-module-native"),K(t,o.jsModuleRuntime,"js-module-runtime"),o.jsModuleDiagnostics&&K(t,o.jsModuleDiagnostics,"js-module-diagnostics");const n=(e,t,o)=>{const n=e;n.behavior=t,o?(n.isCore=!0,$.push(n)):z.push(n)};if(o.coreAssembly)for(let e=0;e<o.coreAssembly.length;e++)n(o.coreAssembly[e],"assembly",!0);if(o.assembly)for(let e=0;e<o.assembly.length;e++)n(o.assembly[e],"assembly",!o.coreAssembly);if(0!=e.debugLevel&&Pe.isDebuggingSupported()){if(o.corePdb)for(let e=0;e<o.corePdb.length;e++)n(o.corePdb[e],"pdb",!0);if(o.pdb)for(let e=0;e<o.pdb.length;e++)n(o.pdb[e],"pdb",!o.corePdb)}if(e.loadAllSatelliteResources&&o.satelliteResources)for(const e in o.satelliteResources)for(let t=0;t<o.satelliteResources[e].length;t++){const r=o.satelliteResources[e][t];r.culture=e,n(r,"resource",!o.coreAssembly)}if(o.coreVfs)for(let e=0;e<o.coreVfs.length;e++)n(o.coreVfs[e],"vfs",!0);if(o.vfs)for(let e=0;e<o.vfs.length;e++)n(o.vfs[e],"vfs",!o.coreVfs);const r=O(e);if(r&&o.icu)for(let e=0;e<o.icu.length;e++){const t=o.icu[e];t.name===r&&n(t,"icu",!1)}if(o.wasmSymbols)for(let e=0;e<o.wasmSymbols.length;e++)n(o.wasmSymbols[e],"symbols",!1)}if(e.appsettings)for(let t=0;t<e.appsettings.length;t++){const o=e.appsettings[t],n=he(o);"appsettings.json"!==n&&n!==`appsettings.${e.applicationEnvironment}.json`||z.push({name:o,behavior:"vfs",cache:"no-cache",useCredentials:!0})}e.assets=[...$,...z,...t]}async function ie(e){const t=await se(e);return await t.pendingDownloadInternal.response,t.buffer}async function se(e){try{return await ae(e)}catch(t){if(!Pe.enableDownloadRetry)throw t;if(Ie||Se)throw t;if(e.pendingDownload&&e.pendingDownloadInternal==e.pendingDownload)throw t;if(e.resolvedUrl&&-1!=e.resolvedUrl.indexOf("file://"))throw t;if(t&&404==t.status)throw t;e.pendingDownloadInternal=void 0,await Pe.allDownloadsQueued.promise;try{return Pe.diagnosticTracing&&b(`Retrying download '${e.name}'`),await ae(e)}catch(t){return e.pendingDownloadInternal=void 0,await new Promise((e=>globalThis.setTimeout(e,100))),Pe.diagnosticTracing&&b(`Retrying download (2) '${e.name}' after delay`),await ae(e)}}}async function ae(e){for(;L;)await L.promise;try{++N,N==Pe.maxParallelDownloads&&(Pe.diagnosticTracing&&b("Throttling further parallel downloads"),L=i());const t=await async function(e){if(e.pendingDownload&&(e.pendingDownloadInternal=e.pendingDownload),e.pendingDownloadInternal&&e.pendingDownloadInternal.response)return e.pendingDownloadInternal.response;if(e.buffer){const t=await e.buffer;return e.resolvedUrl||(e.resolvedUrl="undefined://"+e.name),e.pendingDownloadInternal={url:e.resolvedUrl,name:e.name,response:Promise.resolve({ok:!0,arrayBuffer:()=>t,json:()=>JSON.parse(new TextDecoder("utf-8").decode(t)),text:()=>{throw new Error("NotImplementedException")},headers:{get:()=>{}}})},e.pendingDownloadInternal.response}const t=e.loadRemote&&Pe.config.remoteSources?Pe.config.remoteSources:[""];let o;for(let n of t){n=n.trim(),"./"===n&&(n="");const t=le(e,n);e.name===t?Pe.diagnosticTracing&&b(`Attempting to download '${t}'`):Pe.diagnosticTracing&&b(`Attempting to download '${t}' for ${e.name}`);try{e.resolvedUrl=t;const n=fe(e);if(e.pendingDownloadInternal=n,o=await n.response,!o||!o.ok)continue;return o}catch(e){o||(o={ok:!1,url:t,status:0,statusText:""+e});continue}}const n=e.isOptional||e.name.match(/\.pdb$/)&&Pe.config.ignorePdbLoadErrors;if(o||Be(!1,`Response undefined ${e.name}`),!n){const t=new Error(`download '${o.url}' for ${e.name} failed ${o.status} ${o.statusText}`);throw t.status=o.status,t}y(`optional download '${o.url}' for ${e.name} failed ${o.status} ${o.statusText}`)}(e);return t?(J[e.behavior]||(e.buffer=await t.arrayBuffer(),++Pe.actual_downloaded_assets_count),e):e}finally{if(--N,L&&N==Pe.maxParallelDownloads-1){Pe.diagnosticTracing&&b("Resuming more parallel downloads");const e=L;L=void 0,e.promise_control.resolve()}}}function le(e,t){let o;return null==t&&Be(!1,`sourcePrefix must be provided for ${e.name}`),e.resolvedUrl?o=e.resolvedUrl:(o=""===t?"assembly"===e.behavior||"pdb"===e.behavior?e.name:"resource"===e.behavior&&e.culture&&""!==e.culture?`${e.culture}/${e.name}`:e.name:t+e.name,o=ce(Pe.locateFile(o),e.behavior)),o&&"string"==typeof o||Be(!1,"attemptUrl need to be path or url string"),o}function ce(e,t){return Pe.modulesUniqueQuery&&q[t]&&(e+=Pe.modulesUniqueQuery),e}let de=0;const ue=new Set;function fe(e){try{e.resolvedUrl||Be(!1,"Request's resolvedUrl must be set");const t=function(e){let t=e.resolvedUrl;if(Pe.loadBootResource){const o=ge(e);if(o instanceof Promise)return o;"string"==typeof o&&(t=o)}const o={};return e.cache?o.cache=e.cache:Pe.config.disableNoCacheFetch||(o.cache="no-cache"),e.useCredentials?o.credentials="include":!Pe.config.disableIntegrityCheck&&e.hash&&(o.integrity=e.hash),Pe.fetch_like(t,o)}(e),o={name:e.name,url:e.resolvedUrl,response:t};return ue.add(e.name),o.response.then((()=>{"assembly"==e.behavior&&Pe.loadedAssemblies.push(e.name),de++,Pe.onDownloadResourceProgress&&Pe.onDownloadResourceProgress(de,ue.size)})),o}catch(t){const o={ok:!1,url:e.resolvedUrl,status:500,statusText:"ERR29: "+t,arrayBuffer:()=>{throw t},json:()=>{throw t}};return{name:e.name,url:e.resolvedUrl,response:Promise.resolve(o)}}}const me={resource:"assembly",assembly:"assembly",pdb:"pdb",icu:"globalization",vfs:"configuration",manifest:"manifest",dotnetwasm:"dotnetwasm","js-module-dotnet":"dotnetjs","js-module-native":"dotnetjs","js-module-runtime":"dotnetjs","js-module-threads":"dotnetjs"};function ge(e){var t;if(Pe.loadBootResource){const o=null!==(t=e.hash)&&void 0!==t?t:"",n=e.resolvedUrl,r=me[e.behavior];if(r){const t=Pe.loadBootResource(r,e.name,n,o,e.behavior);return"string"==typeof t?I(t):t}}}function pe(e){e.pendingDownloadInternal=null,e.pendingDownload=null,e.buffer=null,e.moduleExports=null}function he(e){let t=e.lastIndexOf("/");return t>=0&&t++,e.substring(t)}async function we(e){e&&await Promise.all((null!=e?e:[]).map((e=>async function(e){try{const t=e.name;if(!e.moduleExports){const o=ce(Pe.locateFile(t),"js-module-library-initializer");Pe.diagnosticTracing&&b(`Attempting to import '${o}' for ${e}`),e.moduleExports=await import(/*! webpackIgnore: true */o)}Pe.libraryInitializers.push({scriptName:t,exports:e.moduleExports})}catch(t){E(`Failed to import library initializer '${e}': ${t}`)}}(e))))}async function be(e,t){if(!Pe.libraryInitializers)return;const o=[];for(let n=0;n<Pe.libraryInitializers.length;n++){const r=Pe.libraryInitializers[n];r.exports[e]&&o.push(ye(r.scriptName,e,(()=>r.exports[e](...t))))}await Promise.all(o)}async function ye(e,t,o){try{await o()}catch(o){throw E(`Failed to invoke '${t}' on library initializer '${e}': ${o}`),Xe(1,o),o}}function ve(e,t){if(e===t)return e;const o={...t};return void 0!==o.assets&&o.assets!==e.assets&&(o.assets=[...e.assets||[],...o.assets||[]]),void 0!==o.resources&&(o.resources=_e(e.resources||{assembly:[],jsModuleNative:[],jsModuleRuntime:[],wasmNative:[]},o.resources)),void 0!==o.environmentVariables&&(o.environmentVariables={...e.environmentVariables||{},...o.environmentVariables||{}}),void 0!==o.runtimeOptions&&o.runtimeOptions!==e.runtimeOptions&&(o.runtimeOptions=[...e.runtimeOptions||[],...o.runtimeOptions||[]]),Object.assign(e,o)}function Ee(e,t){if(e===t)return e;const o={...t};return o.config&&(e.config||(e.config={}),o.config=ve(e.config,o.config)),Object.assign(e,o)}function _e(e,t){if(e===t)return e;const o={...t};return void 0!==o.coreAssembly&&(o.coreAssembly=[...e.coreAssembly||[],...o.coreAssembly||[]]),void 0!==o.assembly&&(o.assembly=[...e.assembly||[],...o.assembly||[]]),void 0!==o.lazyAssembly&&(o.lazyAssembly=[...e.lazyAssembly||[],...o.lazyAssembly||[]]),void 0!==o.corePdb&&(o.corePdb=[...e.corePdb||[],...o.corePdb||[]]),void 0!==o.pdb&&(o.pdb=[...e.pdb||[],...o.pdb||[]]),void 0!==o.jsModuleWorker&&(o.jsModuleWorker=[...e.jsModuleWorker||[],...o.jsModuleWorker||[]]),void 0!==o.jsModuleNative&&(o.jsModuleNative=[...e.jsModuleNative||[],...o.jsModuleNative||[]]),void 0!==o.jsModuleDiagnostics&&(o.jsModuleDiagnostics=[...e.jsModuleDiagnostics||[],...o.jsModuleDiagnostics||[]]),void 0!==o.jsModuleRuntime&&(o.jsModuleRuntime=[...e.jsModuleRuntime||[],...o.jsModuleRuntime||[]]),void 0!==o.wasmSymbols&&(o.wasmSymbols=[...e.wasmSymbols||[],...o.wasmSymbols||[]]),void 0!==o.wasmNative&&(o.wasmNative=[...e.wasmNative||[],...o.wasmNative||[]]),void 0!==o.icu&&(o.icu=[...e.icu||[],...o.icu||[]]),void 0!==o.satelliteResources&&(o.satelliteResources=function(e,t){if(e===t)return e;for(const o in t)e[o]=[...e[o]||[],...t[o]||[]];return e}(e.satelliteResources||{},o.satelliteResources||{})),void 0!==o.modulesAfterConfigLoaded&&(o.modulesAfterConfigLoaded=[...e.modulesAfterConfigLoaded||[],...o.modulesAfterConfigLoaded||[]]),void 0!==o.modulesAfterRuntimeReady&&(o.modulesAfterRuntimeReady=[...e.modulesAfterRuntimeReady||[],...o.modulesAfterRuntimeReady||[]]),void 0!==o.extensions&&(o.extensions={...e.extensions||{},...o.extensions||{}}),void 0!==o.vfs&&(o.vfs=[...e.vfs||[],...o.vfs||[]]),Object.assign(e,o)}function xe(){const e=Pe.config;if(e.environmentVariables=e.environmentVariables||{},e.runtimeOptions=e.runtimeOptions||[],e.resources=e.resources||{assembly:[],jsModuleNative:[],jsModuleWorker:[],jsModuleRuntime:[],wasmNative:[],vfs:[],satelliteResources:{}},e.assets){Pe.diagnosticTracing&&b("config.assets is deprecated, use config.resources instead");for(const t of e.assets){const o={};switch(t.behavior){case"assembly":o.assembly=[t];break;case"pdb":o.pdb=[t];break;case"resource":o.satelliteResources={},o.satelliteResources[t.culture]=[t];break;case"icu":o.icu=[t];break;case"symbols":o.wasmSymbols=[t];break;case"vfs":o.vfs=[t];break;case"dotnetwasm":o.wasmNative=[t];break;case"js-module-threads":o.jsModuleWorker=[t];break;case"js-module-runtime":o.jsModuleRuntime=[t];break;case"js-module-native":o.jsModuleNative=[t];break;case"js-module-diagnostics":o.jsModuleDiagnostics=[t];break;case"js-module-dotnet":break;default:throw new Error(`Unexpected behavior ${t.behavior} of asset ${t.name}`)}_e(e.resources,o)}}e.debugLevel,e.applicationEnvironment||(e.applicationEnvironment="Production"),e.applicationCulture&&(e.environmentVariables.LANG=`${e.applicationCulture}.UTF-8`),Ue.diagnosticTracing=Pe.diagnosticTracing=!!e.diagnosticTracing,Ue.waitForDebugger=e.waitForDebugger,Pe.maxParallelDownloads=e.maxParallelDownloads||Pe.maxParallelDownloads,Pe.enableDownloadRetry=void 0!==e.enableDownloadRetry?e.enableDownloadRetry:Pe.enableDownloadRetry}let je=!1;async function Re(e){var t;if(je)return void await Pe.afterConfigLoaded.promise;let o;try{if(e.configSrc||Pe.config&&0!==Object.keys(Pe.config).length&&(Pe.config.assets||Pe.config.resources)||(e.configSrc="dotnet.boot.js"),o=e.configSrc,je=!0,o&&(Pe.diagnosticTracing&&b("mono_wasm_load_config"),await async function(e){const t=e.configSrc,o=Pe.locateFile(t);let n=null;void 0!==Pe.loadBootResource&&(n=Pe.loadBootResource("manifest",t,o,"","manifest"));let r,i=null;if(n)if("string"==typeof n)n.includes(".json")?(i=await s(I(n)),r=await Ae(i)):r=(await import(I(n))).config;else{const e=await n;"function"==typeof e.json?(i=e,r=await Ae(i)):r=e.config}else o.includes(".json")?(i=await s(ce(o,"manifest")),r=await Ae(i)):r=(await import(ce(o,"manifest"))).config;function s(e){return Pe.fetch_like(e,{method:"GET",credentials:"include",cache:"no-cache"})}Pe.config.applicationEnvironment&&(r.applicationEnvironment=Pe.config.applicationEnvironment),ve(Pe.config,r)}(e)),xe(),await we(null===(t=Pe.config.resources)||void 0===t?void 0:t.modulesAfterConfigLoaded),await be("onRuntimeConfigLoaded",[Pe.config]),e.onConfigLoaded)try{await e.onConfigLoaded(Pe.config,Le),xe()}catch(e){throw _("onConfigLoaded() failed",e),e}xe(),Pe.afterConfigLoaded.promise_control.resolve(Pe.config)}catch(t){const n=`Failed to load config file ${o} ${t} ${null==t?void 0:t.stack}`;throw Pe.config=e.config=Object.assign(Pe.config,{message:n,error:t,isError:!0}),Xe(1,new Error(n)),t}}function Te(){return!!globalThis.navigator&&(Pe.isChromium||Pe.isFirefox)}async function Ae(e){const t=Pe.config,o=await e.json();t.applicationEnvironment||o.applicationEnvironment||(o.applicationEnvironment=e.headers.get("Blazor-Environment")||e.headers.get("DotNet-Environment")||void 0),o.environmentVariables||(o.environmentVariables={});const n=e.headers.get("DOTNET-MODIFIABLE-ASSEMBLIES");n&&(o.environmentVariables.DOTNET_MODIFIABLE_ASSEMBLIES=n);const r=e.headers.get("ASPNETCORE-BROWSER-TOOLS");return r&&(o.environmentVariables.__ASPNETCORE_BROWSER_TOOLS=r),o}"function"!=typeof importScripts||globalThis.onmessage||(globalThis.dotnetSidecar=!0);const Se="object"==typeof process&&"object"==typeof process.versions&&"string"==typeof process.versions.node,De="function"==typeof importScripts,Oe=De&&"undefined"!=typeof dotnetSidecar,Ce=De&&!Oe,ke="object"==typeof window||De&&!Se,Ie=!ke&&!Se;let Ue={},Pe={},Me={},Le={},Ne={},$e=!1;const ze={},We={config:ze},Fe={mono:{},binding:{},internal:Ne,module:We,loaderHelpers:Pe,runtimeHelpers:Ue,diagnosticHelpers:Me,api:Le};function Be(e,t){if(e)return;const o="Assert failed: "+("function"==typeof t?t():t),n=new Error(o);_(o,n),Ue.nativeAbort(n)}function Ve(){return void 0!==Pe.exitCode}function qe(){return Ue.runtimeReady&&!Ve()}function He(){Ve()&&Be(!1,`.NET runtime already exited with ${Pe.exitCode} ${Pe.exitReason}. You can use runtime.runMain() which doesn't exit the runtime.`),Ue.runtimeReady||Be(!1,".NET runtime didn't start yet. Please call dotnet.create() first.")}function Je(){ke&&(globalThis.addEventListener("unhandledrejection",et),globalThis.addEventListener("error",tt))}let Ze,Qe;function Ge(e){Qe&&Qe(e),Xe(e,Pe.exitReason)}function Ke(e){Ze&&Ze(e||Pe.exitReason),Xe(1,e||Pe.exitReason)}function Xe(t,o){var n,r;const i=o&&"object"==typeof o;t=i&&"number"==typeof o.status?o.status:void 0===t?-1:t;const s=i&&"string"==typeof o.message?o.message:""+o;(o=i?o:Ue.ExitStatus?function(e,t){const o=new Ue.ExitStatus(e);return o.message=t,o.toString=()=>t,o}(t,s):new Error("Exit with code "+t+" "+s)).status=t,o.message||(o.message=s);const a=""+(o.stack||(new Error).stack);try{Object.defineProperty(o,"stack",{get:()=>a})}catch(e){}const l=!!o.silent;if(o.silent=!0,Ve())Pe.diagnosticTracing&&b("mono_exit called after exit");else{try{We.onAbort==Ke&&(We.onAbort=Ze),We.onExit==Ge&&(We.onExit=Qe),ke&&(globalThis.removeEventListener("unhandledrejection",et),globalThis.removeEventListener("error",tt)),Ue.runtimeReady?(Ue.jiterpreter_dump_stats&&Ue.jiterpreter_dump_stats(!1),0===t&&(null===(n=Pe.config)||void 0===n?void 0:n.interopCleanupOnExit)&&Ue.forceDisposeProxies(!0,!0),e&&0!==t&&(null===(r=Pe.config)||void 0===r||r.dumpThreadsOnNonZeroExit)):(Pe.diagnosticTracing&&b(`abort_startup, reason: ${o}`),function(e){Pe.allDownloadsQueued.promise_control.reject(e),Pe.allDownloadsFinished.promise_control.reject(e),Pe.afterConfigLoaded.promise_control.reject(e),Pe.wasmCompilePromise.promise_control.reject(e),Pe.runtimeModuleLoaded.promise_control.reject(e),Ue.dotnetReady&&(Ue.dotnetReady.promise_control.reject(e),Ue.afterInstantiateWasm.promise_control.reject(e),Ue.beforePreInit.promise_control.reject(e),Ue.afterPreInit.promise_control.reject(e),Ue.afterPreRun.promise_control.reject(e),Ue.beforeOnRuntimeInitialized.promise_control.reject(e),Ue.afterOnRuntimeInitialized.promise_control.reject(e),Ue.afterPostRun.promise_control.reject(e))}(o))}catch(e){E("mono_exit A failed",e)}try{l||(function(e,t){if(0!==e&&t){const e=Ue.ExitStatus&&t instanceof Ue.ExitStatus?b:_;"string"==typeof t?e(t):(void 0===t.stack&&(t.stack=(new Error).stack+""),t.message?e(Ue.stringify_as_error_with_stack?Ue.stringify_as_error_with_stack(t.message+"\n"+t.stack):t.message+"\n"+t.stack):e(JSON.stringify(t)))}!Ce&&Pe.config&&(Pe.config.logExitCode?Pe.config.forwardConsoleLogsToWS?R("WASM EXIT "+e):v("WASM EXIT "+e):Pe.config.forwardConsoleLogsToWS&&R())}(t,o),function(e){if(ke&&!Ce&&Pe.config&&Pe.config.appendElementOnExit&&document){const t=document.createElement("label");t.id="tests_done",0!==e&&(t.style.background="red"),t.innerHTML=""+e,document.body.appendChild(t)}}(t))}catch(e){E("mono_exit B failed",e)}Pe.exitCode=t,Pe.exitReason||(Pe.exitReason=o),!Ce&&Ue.runtimeReady&&We.runtimeKeepalivePop()}if(Pe.config&&Pe.config.asyncFlushOnExit&&0===t)throw(async()=>{try{await async function(){try{const e=await import(/*! webpackIgnore: true */"process"),t=e=>new Promise(((t,o)=>{e.on("error",o),e.end("","utf8",t)})),o=t(e.stderr),n=t(e.stdout);let r;const i=new Promise((e=>{r=setTimeout((()=>e("timeout")),1e3)}));await Promise.race([Promise.all([n,o]),i]),clearTimeout(r)}catch(e){_(`flushing std* streams failed: ${e}`)}}()}finally{Ye(t,o)}})(),o;Ye(t,o)}function Ye(e,t){if(Ue.runtimeReady&&Ue.nativeExit)try{Ue.nativeExit(e)}catch(e){!Ue.ExitStatus||e instanceof Ue.ExitStatus||E("set_exit_code_and_quit_now failed: "+e.toString())}if(0!==e||!ke)throw Se&&Ne.process?Ne.process.exit(e):Ue.quit&&Ue.quit(e,t),t}function et(e){ot(e,e.reason,"rejection")}function tt(e){ot(e,e.error,"error")}function ot(e,t,o){e.preventDefault();try{t||(t=new Error("Unhandled "+o)),void 0===t.stack&&(t.stack=(new Error).stack),t.stack=t.stack+"",t.silent||(_("Unhandled error:",t),Xe(1,t))}catch(e){}}!function(e){if($e)throw new Error("Loader module already loaded");$e=!0,Ue=e.runtimeHelpers,Pe=e.loaderHelpers,Me=e.diagnosticHelpers,Le=e.api,Ne=e.internal,Object.assign(Le,{INTERNAL:Ne,invokeLibraryInitializers:be}),Object.assign(e.module,{config:ve(ze,{environmentVariables:{}})});const r={mono_wasm_bindings_is_ready:!1,config:e.module.config,diagnosticTracing:!1,nativeAbort:e=>{throw e||new Error("abort")},nativeExit:e=>{throw new Error("exit:"+e)}},l={gitHash:"0427b9abbead3fa64c6655eb4290c537397131fa",config:e.module.config,diagnosticTracing:!1,maxParallelDownloads:16,enableDownloadRetry:!0,_loaded_files:[],loadedFiles:[],loadedAssemblies:[],libraryInitializers:[],workerNextNumber:1,actual_downloaded_assets_count:0,actual_instantiated_assets_count:0,expected_downloaded_assets_count:0,expected_instantiated_assets_count:0,afterConfigLoaded:i(),allDownloadsQueued:i(),allDownloadsFinished:i(),wasmCompilePromise:i(),runtimeModuleLoaded:i(),loadingWorkers:i(),is_exited:Ve,is_runtime_running:qe,assert_runtime_running:He,mono_exit:Xe,createPromiseController:i,getPromiseController:s,assertIsControllablePromise:a,mono_download_assets:oe,resolve_single_asset_path:ee,setup_proxy_console:j,set_thread_prefix:w,installUnhandledErrorHandler:Je,retrieve_asset_download:ie,invokeLibraryInitializers:be,isDebuggingSupported:Te,exceptions:t,simd:n,relaxedSimd:o};Object.assign(Ue,r),Object.assign(Pe,l)}(Fe);let nt,rt,it,st=!1,at=!1;async function lt(e){if(!at){if(at=!0,ke&&Pe.config.forwardConsoleLogsToWS&&void 0!==globalThis.WebSocket&&j("main",globalThis.console,globalThis.location.origin),We||Be(!1,"Null moduleConfig"),Pe.config||Be(!1,"Null moduleConfig.config"),"function"==typeof e){const t=e(Fe.api);if(t.ready)throw new Error("Module.ready couldn't be redefined.");Object.assign(We,t),Ee(We,t)}else{if("object"!=typeof e)throw new Error("Can't use moduleFactory callback of createDotnetRuntime function.");Ee(We,e)}await async function(e){if(Se){const e=await import(/*! webpackIgnore: true */"process"),t=14;if(e.versions.node.split(".")[0]<t)throw new Error(`NodeJS at '${e.execPath}' has too low version '${e.versions.node}', please use at least ${t}. See also https://aka.ms/dotnet-wasm-features`)}const t=/*! webpackIgnore: true */import.meta.url,o=t.indexOf("?");var n;if(o>0&&(Pe.modulesUniqueQuery=t.substring(o)),Pe.scriptUrl=t.replace(/\\/g,"/").replace(/[?#].*/,""),Pe.scriptDirectory=(n=Pe.scriptUrl).slice(0,n.lastIndexOf("/"))+"/",Pe.locateFile=e=>"URL"in globalThis&&globalThis.URL!==C?new URL(e,Pe.scriptDirectory).toString():M(e)?e:Pe.scriptDirectory+e,Pe.fetch_like=k,Pe.out=console.log,Pe.err=console.error,Pe.onDownloadResourceProgress=e.onDownloadResourceProgress,ke&&globalThis.navigator){const e=globalThis.navigator,t=e.userAgentData&&e.userAgentData.brands;t&&t.length>0?Pe.isChromium=t.some((e=>"Google Chrome"===e.brand||"Microsoft Edge"===e.brand||"Chromium"===e.brand)):e.userAgent&&(Pe.isChromium=e.userAgent.includes("Chrome"),Pe.isFirefox=e.userAgent.includes("Firefox"))}Ne.require=Se?await import(/*! webpackIgnore: true */"module").then((e=>e.createRequire(/*! webpackIgnore: true */import.meta.url))):Promise.resolve((()=>{throw new Error("require not supported")})),void 0===globalThis.URL&&(globalThis.URL=C)}(We)}}async function ct(e){return await lt(e),Ze=We.onAbort,Qe=We.onExit,We.onAbort=Ke,We.onExit=Ge,We.ENVIRONMENT_IS_PTHREAD?async function(){(function(){const e=new MessageChannel,t=e.port1,o=e.port2;t.addEventListener("message",(e=>{var n,r;n=JSON.parse(e.data.config),r=JSON.parse(e.data.monoThreadInfo),st?Pe.diagnosticTracing&&b("mono config already received"):(ve(Pe.config,n),Ue.monoThreadInfo=r,xe(),Pe.diagnosticTracing&&b("mono config received"),st=!0,Pe.afterConfigLoaded.promise_control.resolve(Pe.config),ke&&n.forwardConsoleLogsToWS&&void 0!==globalThis.WebSocket&&Pe.setup_proxy_console("worker-idle",console,globalThis.location.origin)),t.close(),o.close()}),{once:!0}),t.start(),self.postMessage({[l]:{monoCmd:"preload",port:o}},[o])})(),await Pe.afterConfigLoaded.promise,function(){const e=Pe.config;e.assets||Be(!1,"config.assets must be defined");for(const t of e.assets)X(t),Q[t.behavior]&&z.push(t)}(),setTimeout((async()=>{try{await oe()}catch(e){Xe(1,e)}}),0);const e=dt(),t=await Promise.all(e);return await ut(t),We}():async function(){var e;await Re(We),re();const t=dt();(async function(){try{const e=ee("dotnetwasm");await se(e),e&&e.pendingDownloadInternal&&e.pendingDownloadInternal.response||Be(!1,"Can't load dotnet.native.wasm");const t=await e.pendingDownloadInternal.response,o=t.headers&&t.headers.get?t.headers.get("Content-Type"):void 0;let n;if("function"==typeof WebAssembly.compileStreaming&&"application/wasm"===o)n=await WebAssembly.compileStreaming(t);else{ke&&"application/wasm"!==o&&E('WebAssembly resource does not have the expected content type "application/wasm", so falling back to slower ArrayBuffer instantiation.');const e=await t.arrayBuffer();Pe.diagnosticTracing&&b("instantiate_wasm_module buffered"),n=Ie?await Promise.resolve(new WebAssembly.Module(e)):await WebAssembly.compile(e)}e.pendingDownloadInternal=null,e.pendingDownload=null,e.buffer=null,e.moduleExports=null,Pe.wasmCompilePromise.promise_control.resolve(n)}catch(e){Pe.wasmCompilePromise.promise_control.reject(e)}})(),setTimeout((async()=>{try{D(),await oe()}catch(e){Xe(1,e)}}),0);const o=await Promise.all(t);return await ut(o),await Ue.dotnetReady.promise,await we(null===(e=Pe.config.resources)||void 0===e?void 0:e.modulesAfterRuntimeReady),await be("onRuntimeReady",[Fe.api]),Le}()}function dt(){const e=ee("js-module-runtime"),t=ee("js-module-native");if(nt&&rt)return[nt,rt,it];"object"==typeof e.moduleExports?nt=e.moduleExports:(Pe.diagnosticTracing&&b(`Attempting to import '${e.resolvedUrl}' for ${e.name}`),nt=import(/*! webpackIgnore: true */e.resolvedUrl)),"object"==typeof t.moduleExports?rt=t.moduleExports:(Pe.diagnosticTracing&&b(`Attempting to import '${t.resolvedUrl}' for ${t.name}`),rt=import(/*! webpackIgnore: true */t.resolvedUrl));const o=Y("js-module-diagnostics");return o&&("object"==typeof o.moduleExports?it=o.moduleExports:(Pe.diagnosticTracing&&b(`Attempting to import '${o.resolvedUrl}' for ${o.name}`),it=import(/*! webpackIgnore: true */o.resolvedUrl))),[nt,rt,it]}async function ut(e){const{initializeExports:t,initializeReplacements:o,configureRuntimeStartup:n,configureEmscriptenStartup:r,configureWorkerStartup:i,setRuntimeGlobals:s,passEmscriptenInternals:a}=e[0],{default:l}=e[1],c=e[2];s(Fe),t(Fe),c&&c.setRuntimeGlobals(Fe),await n(We),Pe.runtimeModuleLoaded.promise_control.resolve(),l((e=>(Object.assign(We,{ready:e.ready,__dotnet_runtime:{initializeReplacements:o,configureEmscriptenStartup:r,configureWorkerStartup:i,passEmscriptenInternals:a}}),We))).catch((e=>{if(e.message&&e.message.toLowerCase().includes("out of memory"))throw new Error(".NET runtime has failed to start, because too much memory was requested. Please decrease the memory by adjusting EmccMaximumHeapSize. See also https://aka.ms/dotnet-wasm-features");throw e}))}const ft=new class{withModuleConfig(e){try{return Ee(We,e),this}catch(e){throw Xe(1,e),e}}withOnConfigLoaded(e){try{return Ee(We,{onConfigLoaded:e}),this}catch(e){throw Xe(1,e),e}}withConsoleForwarding(){try{return ve(ze,{forwardConsoleLogsToWS:!0}),this}catch(e){throw Xe(1,e),e}}withExitOnUnhandledError(){try{return ve(ze,{exitOnUnhandledError:!0}),Je(),this}catch(e){throw Xe(1,e),e}}withAsyncFlushOnExit(){try{return ve(ze,{asyncFlushOnExit:!0}),this}catch(e){throw Xe(1,e),e}}withExitCodeLogging(){try{return ve(ze,{logExitCode:!0}),this}catch(e){throw Xe(1,e),e}}withElementOnExit(){try{return ve(ze,{appendElementOnExit:!0}),this}catch(e){throw Xe(1,e),e}}withInteropCleanupOnExit(){try{return ve(ze,{interopCleanupOnExit:!0}),this}catch(e){throw Xe(1,e),e}}withDumpThreadsOnNonZeroExit(){try{return ve(ze,{dumpThreadsOnNonZeroExit:!0}),this}catch(e){throw Xe(1,e),e}}withWaitingForDebugger(e){try{return ve(ze,{waitForDebugger:e}),this}catch(e){throw Xe(1,e),e}}withInterpreterPgo(e,t){try{return ve(ze,{interpreterPgo:e,interpreterPgoSaveDelay:t}),ze.runtimeOptions?ze.runtimeOptions.push("--interp-pgo-recording"):ze.runtimeOptions=["--interp-pgo-recording"],this}catch(e){throw Xe(1,e),e}}withConfig(e){try{return ve(ze,e),this}catch(e){throw Xe(1,e),e}}withConfigSrc(e){try{return e&&"string"==typeof e||Be(!1,"must be file path or URL"),Ee(We,{configSrc:e}),this}catch(e){throw Xe(1,e),e}}withVirtualWorkingDirectory(e){try{return e&&"string"==typeof e||Be(!1,"must be directory path"),ve(ze,{virtualWorkingDirectory:e}),this}catch(e){throw Xe(1,e),e}}withEnvironmentVariable(e,t){try{const o={};return o[e]=t,ve(ze,{environmentVariables:o}),this}catch(e){throw Xe(1,e),e}}withEnvironmentVariables(e){try{return e&&"object"==typeof e||Be(!1,"must be dictionary object"),ve(ze,{environmentVariables:e}),this}catch(e){throw Xe(1,e),e}}withDiagnosticTracing(e){try{return"boolean"!=typeof e&&Be(!1,"must be boolean"),ve(ze,{diagnosticTracing:e}),this}catch(e){throw Xe(1,e),e}}withDebugging(e){try{return null!=e&&"number"==typeof e||Be(!1,"must be number"),ve(ze,{debugLevel:e}),this}catch(e){throw Xe(1,e),e}}withApplicationArguments(...e){try{return e&&Array.isArray(e)||Be(!1,"must be array of strings"),ve(ze,{applicationArguments:e}),this}catch(e){throw Xe(1,e),e}}withRuntimeOptions(e){try{return e&&Array.isArray(e)||Be(!1,"must be array of strings"),ze.runtimeOptions?ze.runtimeOptions.push(...e):ze.runtimeOptions=e,this}catch(e){throw Xe(1,e),e}}withMainAssembly(e){try{return ve(ze,{mainAssemblyName:e}),this}catch(e){throw Xe(1,e),e}}withApplicationArgumentsFromQuery(){try{if(!globalThis.window)throw new Error("Missing window to the query parameters from");if(void 0===globalThis.URLSearchParams)throw new Error("URLSearchParams is supported");const e=new URLSearchParams(globalThis.window.location.search).getAll("arg");return this.withApplicationArguments(...e)}catch(e){throw Xe(1,e),e}}withApplicationEnvironment(e){try{return ve(ze,{applicationEnvironment:e}),this}catch(e){throw Xe(1,e),e}}withApplicationCulture(e){try{return ve(ze,{applicationCulture:e}),this}catch(e){throw Xe(1,e),e}}withResourceLoader(e){try{return Pe.loadBootResource=e,this}catch(e){throw Xe(1,e),e}}async download(){try{await async function(){lt(We),await Re(We),re(),D(),oe(),await Pe.allDownloadsFinished.promise}()}catch(e){throw Xe(1,e),e}}async create(){try{return this.instance||(this.instance=await async function(){return await ct(We),Fe.api}()),this.instance}catch(e){throw Xe(1,e),e}}async run(){try{return We.config||Be(!1,"Null moduleConfig.config"),this.instance||await this.create(),this.instance.runMainAndExit()}catch(e){throw Xe(1,e),e}}},mt=Xe,gt=ct;Ie||"function"==typeof globalThis.URL||Be(!1,"This browser/engine doesn't support URL API. Please use a modern version. See also https://aka.ms/dotnet-wasm-features"),"function"!=typeof globalThis.BigInt64Array&&Be(!1,"This browser/engine doesn't support BigInt64Array API. Please use a modern version. See also https://aka.ms/dotnet-wasm-features"),ft.withConfig(/*json-start*/{
  "mainAssemblyName": "AllMultiplayerGames.WebAssembly",
  "resources": {
    "hash": "sha256-vnZaZWH/M2JuXnHm+e1eephcdkGa5YebB/el1vj110E=",
    "jsModuleNative": [
      {
        "name": "dotnet.native.bjoj0wmylw.js"
      }
    ],
    "jsModuleRuntime": [
      {
        "name": "dotnet.runtime.5nc8i5dl74.js"
      }
    ],
    "wasmNative": [
      {
        "name": "dotnet.native.a6k1euv12n.wasm",
        "hash": "sha256-YlIWUrqwAiQuAJNBOX+Zm9wpWL+sF3J449iFq7JHouQ=",
        "cache": "force-cache"
      }
    ],
    "icu": [
      {
        "virtualPath": "icudt_CJK.dat",
        "name": "icudt_CJK.tjcz0u77k5.dat",
        "hash": "sha256-SZLtQnRc0JkwqHab0VUVP7T3uBPSeYzxzDnpxPpUnHk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "icudt_EFIGS.dat",
        "name": "icudt_EFIGS.tptq2av103.dat",
        "hash": "sha256-8fItetYY8kQ0ww6oxwTLiT3oXlBwHKumbeP2pRF4yTc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "icudt_no_CJK.dat",
        "name": "icudt_no_CJK.lfu7j35m59.dat",
        "hash": "sha256-L7sV7NEYP37/Qr2FPCePo5cJqRgTXRwGHuwF5Q+0Nfs=",
        "cache": "force-cache"
      }
    ],
    "coreAssembly": [
      {
        "virtualPath": "System.Runtime.InteropServices.JavaScript.wasm",
        "name": "System.Runtime.InteropServices.JavaScript.k73pmujdju.wasm",
        "hash": "sha256-gFrXjGU6ruBC38gGk0oGopANBsn10uK8B23jFC8+zhk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Private.CoreLib.wasm",
        "name": "System.Private.CoreLib.g49kyik5yr.wasm",
        "hash": "sha256-MNX3oiiSFEAPvAjN6ReDEK5ETOr46NAF2LrwWmM8Yoc=",
        "cache": "force-cache"
      }
    ],
    "assembly": [
      {
        "virtualPath": "Microsoft.AspNetCore.Components.wasm",
        "name": "Microsoft.AspNetCore.Components.bqljtk5zh2.wasm",
        "hash": "sha256-wxHRLMEgJ34CDN4/19WcunwsjUGct0lc/PM90y+YK3E=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Components.Forms.wasm",
        "name": "Microsoft.AspNetCore.Components.Forms.n5alg9r3xi.wasm",
        "hash": "sha256-q2pzeXvemWoWDFURuEhnWPgfNRCf50HYFFNWnW4IS2Y=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Components.Web.wasm",
        "name": "Microsoft.AspNetCore.Components.Web.40551yx0vh.wasm",
        "hash": "sha256-bN6Em6GR2AD9iZZ9dxVnq32AFFMrIgq/GdRU5tjW3wo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Components.WebAssembly.wasm",
        "name": "Microsoft.AspNetCore.Components.WebAssembly.5a2l6ghbxp.wasm",
        "hash": "sha256-zdSELzgyTEM8wLjbvGFlbcCMUiAdn/Mc5W7Ixr0LeUI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Connections.Abstractions.wasm",
        "name": "Microsoft.AspNetCore.Connections.Abstractions.7l5x3szdlv.wasm",
        "hash": "sha256-dSJotvb7S3uAJLDFWs4/m0yL//dKASEoWY5BD3MOqFs=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Http.Connections.Client.wasm",
        "name": "Microsoft.AspNetCore.Http.Connections.Client.80ctlz3ynl.wasm",
        "hash": "sha256-+MxfKONa8k6YWUpjzsIX/wj3D3pSKRiz9KF3WaxxPcs=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Http.Connections.Common.wasm",
        "name": "Microsoft.AspNetCore.Http.Connections.Common.kib86jnanp.wasm",
        "hash": "sha256-tDFSdFfZc3ajC9uDpJQ7UaYs47M9/dWV4ShOY+I10ZM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.AspNetCore.SignalR.Client.wasm",
        "name": "Microsoft.AspNetCore.SignalR.Client.s8fi8hwnxr.wasm",
        "hash": "sha256-VDaqzwLFLkHJlVZVywgJM+khXHtBR3c3Og6kmR+HB+8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.AspNetCore.SignalR.Client.Core.wasm",
        "name": "Microsoft.AspNetCore.SignalR.Client.Core.y3uk3lnbj6.wasm",
        "hash": "sha256-kqNiJPhKLGS3JHIteL46C8/0noE9/CL10ac8UD3I2CE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.AspNetCore.SignalR.Common.wasm",
        "name": "Microsoft.AspNetCore.SignalR.Common.pm3ej190oz.wasm",
        "hash": "sha256-4TA3Pme+7IVoVEyfRhn+0ijVNJIRcssIz68yrd9hK04=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.AspNetCore.SignalR.Protocols.Json.wasm",
        "name": "Microsoft.AspNetCore.SignalR.Protocols.Json.8gh7r53ho1.wasm",
        "hash": "sha256-6Aym7ep9IkbjNNQeIZnmNEwLiO1JkvtKCrpFdYT+m1E=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Configuration.wasm",
        "name": "Microsoft.Extensions.Configuration.67atbzll4d.wasm",
        "hash": "sha256-4r9CqKF1IyUl3p7USueib+MFNA5LEBh05vD2mkJHB80=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Configuration.Abstractions.wasm",
        "name": "Microsoft.Extensions.Configuration.Abstractions.pvus31ewzj.wasm",
        "hash": "sha256-qw1aiON+wIm3G8A00tmpEOB7ksUnF4jGjD6Gnk9OowY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Configuration.Binder.wasm",
        "name": "Microsoft.Extensions.Configuration.Binder.hk25mhhkf0.wasm",
        "hash": "sha256-v5nH8eJyBXyoXne7rJh04b+7V3EWxTEv0GomWnjB1Kk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Configuration.FileExtensions.wasm",
        "name": "Microsoft.Extensions.Configuration.FileExtensions.72l201d5ay.wasm",
        "hash": "sha256-4XQ2Pw01pqix8J2CcVz431val86+57MX1Nqt7e4Bexg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Configuration.Json.wasm",
        "name": "Microsoft.Extensions.Configuration.Json.dmmcgk01r0.wasm",
        "hash": "sha256-hR3hJyllFhcAJODYJ4O/15D7zPKt4rm31ndgrYDdAXM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.DependencyInjection.wasm",
        "name": "Microsoft.Extensions.DependencyInjection.e1lpn0jjqr.wasm",
        "hash": "sha256-wp0yIfG2n1owJV2Nrdi0BHGVxC1am2W9AcSceiPLbuA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.DependencyInjection.Abstractions.wasm",
        "name": "Microsoft.Extensions.DependencyInjection.Abstractions.x232c49m6c.wasm",
        "hash": "sha256-51f5kNwEaMi4IsWO3ypY5cJmXrok5Knfxm0//i49SdA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Features.wasm",
        "name": "Microsoft.Extensions.Features.ur60apf60e.wasm",
        "hash": "sha256-SuDpfV6VLZdFK+EdYgsUI3G/DzsX9Sa+rQ4ugzSa23Q=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.FileProviders.Abstractions.wasm",
        "name": "Microsoft.Extensions.FileProviders.Abstractions.5ablnqdnww.wasm",
        "hash": "sha256-XdtMqsa9aokRY+Pn8LVwrsjueCDiCFs7xM+aghxGhoE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.FileProviders.Physical.wasm",
        "name": "Microsoft.Extensions.FileProviders.Physical.6m5nykbtm3.wasm",
        "hash": "sha256-Lp7R9mqqRt81cNNOVtmZPk5w6LpHgPCEm4IWoPMnCzc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.FileSystemGlobbing.wasm",
        "name": "Microsoft.Extensions.FileSystemGlobbing.eas9rj956p.wasm",
        "hash": "sha256-ihGCTgP4O1qUEob7Ecjx/1IvsWkXxnWUuSpGIJenRtU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Logging.wasm",
        "name": "Microsoft.Extensions.Logging.g1uu37kx58.wasm",
        "hash": "sha256-lNI1VXR4amRQ7S+Nkzv6Ylsp9wG1kIHetEx/AsU9WvE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Logging.Abstractions.wasm",
        "name": "Microsoft.Extensions.Logging.Abstractions.xwo7t2c5ho.wasm",
        "hash": "sha256-HwGhMkS3DwXJk8ynZS8p0UqXqPOiUl9m426Y+5wmNtY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Options.wasm",
        "name": "Microsoft.Extensions.Options.ouqxsmik00.wasm",
        "hash": "sha256-MNrbxhQ7wkE7eNxga78hv8dEZC6M98ZOTsgOy5A6UJM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Primitives.wasm",
        "name": "Microsoft.Extensions.Primitives.l9qstc6tys.wasm",
        "hash": "sha256-+QCl6Qq5v/snDiffivb9YLI1ncgFeTXn98XDThbvu9I=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Validation.wasm",
        "name": "Microsoft.Extensions.Validation.t7hdqum7ip.wasm",
        "hash": "sha256-aUqItU9TychE/hjlgJr2DlYztEYPeTV5rTimfsh0FoE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.JSInterop.wasm",
        "name": "Microsoft.JSInterop.0523xs2ej1.wasm",
        "hash": "sha256-bIHZr/r3k4ORlS0vawlQLe6xT3DKr3SBm6bwZ0jaIGI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.JSInterop.WebAssembly.wasm",
        "name": "Microsoft.JSInterop.WebAssembly.5ql0ra5mpq.wasm",
        "hash": "sha256-A1+r9KkQJ1Kkm98VWekGd8z84GzOPdY9wh/SHfyyQg4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "A21DiceGame.wasm",
        "name": "A21DiceGame.gxqjutpg8z.wasm",
        "hash": "sha256-7O6LzgUesAXhQEv9Ro9o16JPr7a0me8fVtK38lX2u/Y=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "A8RoundRummy.wasm",
        "name": "A8RoundRummy.sesc5pbbpi.wasm",
        "hash": "sha256-LEw5YKdtpcTmApnlL7NzznB0wEeqbxoadU7cKHqMfHo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Aggravation.wasm",
        "name": "Aggravation.kfkl13qwae.wasm",
        "hash": "sha256-UHgl0YKGzwWXVEztquf5KO+gwgArcoeE5D1Wckj/wWw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Backgammon.wasm",
        "name": "Backgammon.x9vo98qz0f.wasm",
        "hash": "sha256-qyKMU93IdgaNw564NvnlZ9B7gjeWADshjuM8oZQ6UWg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "BasicBlazorLibrary.wasm",
        "name": "BasicBlazorLibrary.3d87ixninj.wasm",
        "hash": "sha256-6XPw6okBAxT7ES45Yk+s9sojNxY4zUOmLLqv4HxRcuE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "BasicGameFrameworkLibrary.wasm",
        "name": "BasicGameFrameworkLibrary.s9hqrkdbvf.wasm",
        "hash": "sha256-EMvY+GVqjETJXkeZhzbZaYvtreAA6fO97D2vyjTkr6Y=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Battleship.wasm",
        "name": "Battleship.lfhoxgrlvg.wasm",
        "hash": "sha256-v6AVVNDoLj++IW2adj9oPBm+USqeJyHf3EXaR9MTI10=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "BattleshipLite.wasm",
        "name": "BattleshipLite.caa0joq5rz.wasm",
        "hash": "sha256-FGccrtC8lLs2VSIWYknPqfs0btCRT+0NrY7rUywZh1Q=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Bingo.wasm",
        "name": "Bingo.lronn2wtaq.wasm",
        "hash": "sha256-IdzkE3c50GdCCj5/GCy9YESQ20+DMpcDCcxE2A65Xm8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "BladesOfSteel.wasm",
        "name": "BladesOfSteel.5uj2dlsfav.wasm",
        "hash": "sha256-7fH/GVJNB398mvhpOOK78o7DFKYes1qrH62ABZ0jEh4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "BowlingDiceGame.wasm",
        "name": "BowlingDiceGame.4xpruus541.wasm",
        "hash": "sha256-+NHI+qhU2m8WIrFvQqL+TS7BxMOqZl9QjoG+4JTuGfQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "CaliforniaJack.wasm",
        "name": "CaliforniaJack.52snmks2yl.wasm",
        "hash": "sha256-MyweFdOM9xz3O8pVvJn8sZ++mcUHxy52kOXOrUoRXww=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Candyland.wasm",
        "name": "Candyland.wviqdlhgd5.wasm",
        "hash": "sha256-5GwbcWKE6DrUxshA8iU7Qz3X4z9Adeey090WMDvU1hg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Checkers.wasm",
        "name": "Checkers.ar1wfk60iv.wasm",
        "hash": "sha256-GpALeG+8pTPDM/7ceoRLw9hyqJ1Cgqx8YCWj9xD/rWc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Chess.wasm",
        "name": "Chess.zb8hkxx4q6.wasm",
        "hash": "sha256-bwwYridm0cEv6O9nywFJ1/w7hBaacgp0JqIwGSoz4Ko=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Chinazo.wasm",
        "name": "Chinazo.hocxg3mss3.wasm",
        "hash": "sha256-j+WbnAFDpVCqCn+Jiyd/aQCoXYKW7iRCxwZNhBnwDfs=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "ChineseCheckers.wasm",
        "name": "ChineseCheckers.lxwve6jwuk.wasm",
        "hash": "sha256-h3E+VOW+6Ta2HT9hPtE6FhXAzxWZQjWPFQSoqPiAIuk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "ClueBoardGame.wasm",
        "name": "ClueBoardGame.nmoul14itn.wasm",
        "hash": "sha256-L3FguigDsU1tN4+ehTlOGa0skrHDnrBN8j7TjYCOJLk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "ClueCardGame.wasm",
        "name": "ClueCardGame.f0gom2faer.wasm",
        "hash": "sha256-D/UU1CQIX+xLsSJaMbX9ZkNGhhKx0BBrp7fCtFmKNpg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "CommonBasicLibraries.wasm",
        "name": "CommonBasicLibraries.d1jgetlaz8.wasm",
        "hash": "sha256-nwkrf3OPtOb4KlDoH8MOj5vCxmJHaMuqcr+ySrYHhTU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Concentration.wasm",
        "name": "Concentration.n5pd99vwg2.wasm",
        "hash": "sha256-mx2DgvFSq6QMo2hoU0/5iemk/nledVp4ed5u2Io+Ito=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "ConnectFour.wasm",
        "name": "ConnectFour.s7otm9pz46.wasm",
        "hash": "sha256-2AlgS1sGdNNUBh59mrnXuzU2qtdqeqmMjpy4lScId+c=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "ConnectTheDots.wasm",
        "name": "ConnectTheDots.rdzkxswrav.wasm",
        "hash": "sha256-4Z4At8teaQzO7ZZlJuIW9RQPBfcCNt1c1qauCfWGsnY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Countdown.wasm",
        "name": "Countdown.jtr2m9lecu.wasm",
        "hash": "sha256-V2Odtm+yyHoFVwK5DL8npb8LhFNkNQzKxU/nLtOVUBs=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "CousinRummy.wasm",
        "name": "CousinRummy.veguecwgw1.wasm",
        "hash": "sha256-adMpdZ4sGdryxOjdnedh+WBtot5bA2OZVPzMBb7laa8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "CoveredUp.wasm",
        "name": "CoveredUp.tcj0cld1ib.wasm",
        "hash": "sha256-A46cDLl5hWPnlkIsnG2nvpohFxAp4T/KJp2djnp6L7g=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "CrazyEights.wasm",
        "name": "CrazyEights.dpfxrydejq.wasm",
        "hash": "sha256-weDr05aYN1Yb3ZkfIVXU+tEAYff1c9r7aMNTvdUGb2A=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Cribbage.wasm",
        "name": "Cribbage.n784cd1fxt.wasm",
        "hash": "sha256-bU2lYgQouMvxSyb7owONu0M8JHzCYcI72hmk70Pqyes=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "DeadDie96.wasm",
        "name": "DeadDie96.vfqsxb4qoe.wasm",
        "hash": "sha256-2wE2l8RSnEcN8lzHtVW0DltrgKU7I6uzRpZH5gA0cfY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "DealCardGame.wasm",
        "name": "DealCardGame.3xmh2jnx1f.wasm",
        "hash": "sha256-uVNoW/leUz+TM/ckiusHsAv3VjiCnioWx9ml10ovjk4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "DiceDominos.wasm",
        "name": "DiceDominos.y3jmjfyegu.wasm",
        "hash": "sha256-wsaZ22m6SK6sR3fLmVc+9ix3IO6qId1Iafj1s9Q6ycM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "DominosRegular.wasm",
        "name": "DominosRegular.rg43vnbxui.wasm",
        "hash": "sha256-pZus3zRL9FLJZFOqkeMlv8lOKY8rqw1FcXPy3nZH1QI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "DummyRummy.wasm",
        "name": "DummyRummy.lhgyv3ydmn.wasm",
        "hash": "sha256-B61xH/FN852iXA8YYnR6DnPYHDPClocHJ2uVoaxG42M=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "DutchBlitz.wasm",
        "name": "DutchBlitz.ro0oq0d0jk.wasm",
        "hash": "sha256-e0NS4uQ6g/10MKWTwkfBTZkgvoEnm3iSzlVJmMJSc7A=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "FillOrBust.wasm",
        "name": "FillOrBust.5athtx84ef.wasm",
        "hash": "sha256-g3AhrZMt5ViOvCAFEc1kh3kPPYK2rhSdnf0ej9dyQck=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "FiveCrowns.wasm",
        "name": "FiveCrowns.6cno7y8588.wasm",
        "hash": "sha256-2oT5Q+n097q9m5UlZLEdFH7Ar4JjS2I7BOgZhv1zmwc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Flinch.wasm",
        "name": "Flinch.pmoktwpel8.wasm",
        "hash": "sha256-T3nArHusF+bcHUG2obdgxeX6NQFjJA/wgBX0f+p1GBc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Fluxx.wasm",
        "name": "Fluxx.k2cyc708rn.wasm",
        "hash": "sha256-nHn/Y/VwXfEwEvhcTys58ekw0Xxitm5uzRHySlJRvuY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "FourSuitRummy.wasm",
        "name": "FourSuitRummy.muqgvci86q.wasm",
        "hash": "sha256-EsU69M0qcuObYrKs6tSM4w08kEP1jE9+RIy1hlCdFyo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "GalaxyCardGame.wasm",
        "name": "GalaxyCardGame.inmpadtf8i.wasm",
        "hash": "sha256-7mwX4LlRovRVXRm424mD1W+iOtddgQ9wJH2sE3Wc198=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "GameLoaderBlazorLibrary.wasm",
        "name": "GameLoaderBlazorLibrary.v8gdjk6bzq.wasm",
        "hash": "sha256-gYn4skWAzom+KMvaCH7qKr+v6R72RzuNNkhG0Wsl0ag=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "GamePackageContractsLibrary.wasm",
        "name": "GamePackageContractsLibrary.k667j5ryrl.wasm",
        "hash": "sha256-DHIrjNVE0OwYxuU3/baVFZS75z63dK7GEpkyhXrR4JQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "GamePackageSignalRClasses.wasm",
        "name": "GamePackageSignalRClasses.eklsbmifrq.wasm",
        "hash": "sha256-0sBPJ1F4pd+BtMqK1I3pQNrj7Eilo1Y6q8iKtRsF3Z0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "GermanWhist.wasm",
        "name": "GermanWhist.byd80mrjyt.wasm",
        "hash": "sha256-XX+U25YK3ZWOF/eRGNqt7oMdF0QYlz7PzznJrDbO2pM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "GoFish.wasm",
        "name": "GoFish.cmmxtkq1kv.wasm",
        "hash": "sha256-PCJGE3gwuZ/s4iK802yI8RYW7RYB3QlwYjVgV5Ax/uY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "GolfCardGame.wasm",
        "name": "GolfCardGame.tpxwzs8x9m.wasm",
        "hash": "sha256-sSUiR/sGcCoQW4jpjzErG1CxIXx9AfxLfn3DXoArheE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Hearts.wasm",
        "name": "Hearts.hjuu2yocks.wasm",
        "hash": "sha256-438UTQKW+k7oNsgCG7KcfpzvhajIBLB9/3LeMiYETZk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "HitTheDeck.wasm",
        "name": "HitTheDeck.hmwsk7la7r.wasm",
        "hash": "sha256-14tS7bfGUtqLRBTQpR3iFbhCYi+jWWy8CM3phYSSyvs=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "HorseshoeCardGame.wasm",
        "name": "HorseshoeCardGame.67q4qxboex.wasm",
        "hash": "sha256-XnQlo+rBWbjHbuGzO3Oi44tY87lhKa8kPj2ZcMFNBa8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "HuseHearts.wasm",
        "name": "HuseHearts.h7g4dqmo7e.wasm",
        "hash": "sha256-DWBV8VnIfRZV8f3UfBFYOIh+I275yDsNJ1SayeuskiY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "ItalianDominos.wasm",
        "name": "ItalianDominos.g3mo26m9rb.wasm",
        "hash": "sha256-JMA4ZJY6nmjZfIdDdCi/UR/CR2hamCP39EznFc7cIME=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Kismet.wasm",
        "name": "Kismet.mz1garxx6r.wasm",
        "hash": "sha256-7qtL/VXW/vqqRGo00YF9X0Yw72Xb2OQf6fbkhdb3DVo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "LifeBoardGame.wasm",
        "name": "LifeBoardGame.ado241r3lq.wasm",
        "hash": "sha256-3n8R3mpMtQkTTMCJOmvkJj1kXtF6v/6UeVRHKSjwfiw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "LifeCardGame.wasm",
        "name": "LifeCardGame.bd7dv46yfz.wasm",
        "hash": "sha256-carnqJO67xbc+ea6AKDnbbgUL5dxAowQ3+LbuKeYX04=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "LottoDominos.wasm",
        "name": "LottoDominos.kr95kxqfgm.wasm",
        "hash": "sha256-UCeXOm3WvCz60ARDBJxk2ag2ycvXYBQojHzP9UPseaY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Mancala.wasm",
        "name": "Mancala.mjf7w47ymw.wasm",
        "hash": "sha256-curHdchmur57myH88bbePXu6mo6e2Szd8vozqymqQUY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "MessengingHelpers.wasm",
        "name": "MessengingHelpers.nrqdh2110r.wasm",
        "hash": "sha256-Pe6j7d+tfiW+USHQSQvGO4O66p/QjBE6V3BRQNVW6UQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "MilkRun.wasm",
        "name": "MilkRun.vhsu8jzbn5.wasm",
        "hash": "sha256-ww9UwAsWAJxMopsaAOHEdU8eJktNnjTRluh5IhKY77g=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Millebournes.wasm",
        "name": "Millebournes.ugwp8kumyh.wasm",
        "hash": "sha256-Yle407dkkmTv38hof1WrWNP/CijBn5RumyuOy6zgFfY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "MonasteryCardGame.wasm",
        "name": "MonasteryCardGame.2p67ewk1mn.wasm",
        "hash": "sha256-WhRCIc74nMaPVt9OnIfsb2R5E0qcj7DyBHAHM9rjSMg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "MonopolyCardGame.wasm",
        "name": "MonopolyCardGame.v3eeazfhx9.wasm",
        "hash": "sha256-FdvHEZGnnnfaHw7jSbxBUboq48G2BFygvB0qz/VUHP4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "MonopolyDicedGame.wasm",
        "name": "MonopolyDicedGame.cmiksv80uf.wasm",
        "hash": "sha256-vGy3cImxnCjxBL07pDh6Kxm/DGf1TLwwoNqTfGTTIMY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "MultiplayerGamesBlazorLoaderLibrary.wasm",
        "name": "MultiplayerGamesBlazorLoaderLibrary.p1x7kp0qph.wasm",
        "hash": "sha256-Dbtfo1S4bKcUEcUpz/RQgTxcx1JJiWyofl7EFDzNupo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "OldMaid.wasm",
        "name": "OldMaid.qenlhsysdz.wasm",
        "hash": "sha256-wioVOnV7Fsh6rXQ5qucaaugAOZ28dFEZxT+Vm22lFlw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Opetong.wasm",
        "name": "Opetong.omuac1x17q.wasm",
        "hash": "sha256-cMab+ZmpgLqOIEctZQ5gMaHkAddHdpWNyqaVI1ULZbg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "PassOutDiceGame.wasm",
        "name": "PassOutDiceGame.nvegknjwun.wasm",
        "hash": "sha256-rdD+iIzN96C99cpxVHO/HACkW6bzUlWz5pHh/MRu6pg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Payday.wasm",
        "name": "Payday.l8cavbcuo5.wasm",
        "hash": "sha256-dSdTPupma2RxwUW4u03TWcq9nyJn6XaidrTAtQ8X0Hk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Phase10.wasm",
        "name": "Phase10.168ui76sl4.wasm",
        "hash": "sha256-2bI7+ZtqH8N6sXc5TORpgCTiCIKsVmkaMraviqrk85s=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "PickelCardGame.wasm",
        "name": "PickelCardGame.k2cf15b1xq.wasm",
        "hash": "sha256-3K8mcxD328spXY2aVBcYrVeEf77WUxAvMP4jxLRHbFY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Pinochle2Player.wasm",
        "name": "Pinochle2Player.2q67thps4b.wasm",
        "hash": "sha256-ys6Ij97RMQV7EKBWTO6mFlw9s7W6C2iqb4XxO+gUGDg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Racko.wasm",
        "name": "Racko.p410ir2auq.wasm",
        "hash": "sha256-uUM/Xjgs4nU3zqs7h5eJTN1sulUIiBmN3zOzsFMDiRE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "RageCardGame.wasm",
        "name": "RageCardGame.b51mzpbc4e.wasm",
        "hash": "sha256-sZl4yCWE6sHZc7WbVG0dbIAC2448OkI76V5JPPTiIr8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Risk.wasm",
        "name": "Risk.yr5bp9l3s6.wasm",
        "hash": "sha256-/n4ztyZm1jJvDklFE/ei8jpW2z7LIyL1wVKq7QDv5G4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "RollEm.wasm",
        "name": "RollEm.qhxeblk24l.wasm",
        "hash": "sha256-DsBVyLcDHismHUn1KJm+JdtBcD+5Wr3NNz+sFwvMFD4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Rook.wasm",
        "name": "Rook.re5zwjf72w.wasm",
        "hash": "sha256-IwIPW+qe88U/Kh9x3TigC9eKiHR4NNTrIQwE0zhenkg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "RoundsCardGame.wasm",
        "name": "RoundsCardGame.u4dilz7h6c.wasm",
        "hash": "sha256-/mNNllxleyJmYuVXHj32E0/SS+F+klKASOinrcyDJ5I=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Rummy500.wasm",
        "name": "Rummy500.13ehg4z5yk.wasm",
        "hash": "sha256-c452K9l5yTqeKkdvs7rM7pVab2/JCtPn4GZqnUV7KFA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "RummyDice.wasm",
        "name": "RummyDice.ulmz5kcd2a.wasm",
        "hash": "sha256-MlKWezAvrykZ3adoE4lzmkNSPTNsuy0vGro77L6cLmw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Savannah.wasm",
        "name": "Savannah.2kwoz6rffb.wasm",
        "hash": "sha256-0gUKfpQE6OcCpI8/0IAkA6hYPf1RvzPPb+O6/XCWz9o=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "SequenceDice.wasm",
        "name": "SequenceDice.kbztqjhly2.wasm",
        "hash": "sha256-EC5vSI2wD41kIddX8DZZMSvu7knDzy4uV2QaYDQJ9L0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "ShipCaptainCrew.wasm",
        "name": "ShipCaptainCrew.og38i3vdvz.wasm",
        "hash": "sha256-iDHquXYRMmQLIWSo7jXiaVSJ3UlJFSSUtxvp+1vyMco=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "SinisterSix.wasm",
        "name": "SinisterSix.knpw800bl3.wasm",
        "hash": "sha256-4BGiOgdttXENRYk+cjhj/vIaWYk49vItH2u9jumDsMo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "SixtySix2Player.wasm",
        "name": "SixtySix2Player.bn5gmdmhrz.wasm",
        "hash": "sha256-l0o+Nj9HqFkpr/D7pDLs12tVaGeBNlD6pnzuQP1g8CM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Skipbo.wasm",
        "name": "Skipbo.h3y5czhr99.wasm",
        "hash": "sha256-I/zVmCLC5yesW7Ji8xvOx49jkxPrWzf17UkL4k3sw+E=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "SkuckCardGame.wasm",
        "name": "SkuckCardGame.xo8pmtl9ro.wasm",
        "hash": "sha256-vw1OOey2a/zTEXiziYuZHaIFXRZe74AEnPGduSZTvCs=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "SnagCardGame.wasm",
        "name": "SnagCardGame.fzwrzf92pz.wasm",
        "hash": "sha256-u46dXKCSQR1OFrB+49yBo7k+Cz0O26pPa+MoyhY/0sU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "SnakesAndLadders.wasm",
        "name": "SnakesAndLadders.uiyfxytl0p.wasm",
        "hash": "sha256-egopI7WPOLnmRL9bFvQE1Z1jr7X2D96tGAaOgGRtIOQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Sorry.wasm",
        "name": "Sorry.g1bd01f9du.wasm",
        "hash": "sha256-3LJkDR4IrbGdljTJ4wNZA6f+d6sdBBe3ZBkGi663nL8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "SorryCardGame.wasm",
        "name": "SorryCardGame.3ny20h0nt7.wasm",
        "hash": "sha256-37/X2QKd1sNoeGE7ZAkUcvCqjBuPJyun+Hjzc769Zeg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "SorryDicedGame.wasm",
        "name": "SorryDicedGame.86b01ugf8z.wasm",
        "hash": "sha256-cC4cXVTVuk/604Kq/4l8ys9MMQM7v6x8z4WZsLLNdlk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Spades2Player.wasm",
        "name": "Spades2Player.yyjep75jmk.wasm",
        "hash": "sha256-Zl5a+d7PZXnUkAnk1iecC06gFBgW+XiBtu/pQmTh/R0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Spades4Player.wasm",
        "name": "Spades4Player.6p0bf39x0s.wasm",
        "hash": "sha256-tvxpeSpxbavWH8I1HtvdtQeY7QnLkm1T5y2Y9dX7M7c=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "SvgHelper.Blazor.wasm",
        "name": "SvgHelper.Blazor.r0xesi95tq.wasm",
        "hash": "sha256-VW00Dv35mCa3sXkuWiL6QqWf/l5lHVOEHSzfAr91RKI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "TeeItUp.wasm",
        "name": "TeeItUp.dun96pl6xq.wasm",
        "hash": "sha256-9XqlJvKwByhzW4xfrGe6x0lDB5BwnFgPiBwK8PGaKcA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "ThinkTwice.wasm",
        "name": "ThinkTwice.f3o7ro6oog.wasm",
        "hash": "sha256-Rc9+CLpVM7aJVRX/cd0o+I32vIwx4UlNzs0s37ySuDI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "ThreeLetterFun.wasm",
        "name": "ThreeLetterFun.ncowwj09vc.wasm",
        "hash": "sha256-uTBbyOiBXD6gkk92QLnKFbk93KTrSca44KQ3kpRjm20=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "TicTacToe.wasm",
        "name": "TicTacToe.u9cml739ya.wasm",
        "hash": "sha256-XvdzUwMEEe2GICmpGuBLgzLvehONmtGyWGiIeO3D7o0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "TileRummy.wasm",
        "name": "TileRummy.2b1dwrvu5r.wasm",
        "hash": "sha256-ItyDmmhP/7bWQO1JBVN9koV1oghOFXwvLRbHtN1Ml3c=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Trouble.wasm",
        "name": "Trouble.w4hna646kh.wasm",
        "hash": "sha256-gJhqwh427UJbNayUTuMizasN0DneML1IB7sXM7r0NYE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Uno.wasm",
        "name": "Uno.p5ejb73czm.wasm",
        "hash": "sha256-k5raKPp9OdS6mBqA3/6SfkYzZvA8JFW3QNo+TQ3INQ8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Xactika.wasm",
        "name": "Xactika.xc7yvokc79.wasm",
        "hash": "sha256-P4e6VkvCaJDoPbS+yQgRN0C4u0q5caWz7FlQykRfN5s=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "YaBlewIt.wasm",
        "name": "YaBlewIt.3hwgixg9id.wasm",
        "hash": "sha256-mUHAoDSt/vPCw5Tmx+SoQKT6lv0OlWwqUqUPcbEXKuo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "YachtRace.wasm",
        "name": "YachtRace.itmptcyna2.wasm",
        "hash": "sha256-OvMcFply7NWepLH+KH8P5ZLTXZiqTSKduCmc2L7OF2U=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Yahtzee.wasm",
        "name": "Yahtzee.cjqudufyx8.wasm",
        "hash": "sha256-2LaphEq+B/h7LWqgpsOxRv+YMdoj93W6UFngBkIe5TU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "YahtzeeHandsDown.wasm",
        "name": "YahtzeeHandsDown.k3zq4852tg.wasm",
        "hash": "sha256-MKgzp/z0u8s+RBpri8Zg+0f9jx2fejXxSviXfzsSWp0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Collections.Concurrent.wasm",
        "name": "System.Collections.Concurrent.vim85evm47.wasm",
        "hash": "sha256-+U4Y4S+o9vuPeHyoXsOfS60dnC5xFalmdFs0JrkAKJM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Collections.Immutable.wasm",
        "name": "System.Collections.Immutable.07ikwr962t.wasm",
        "hash": "sha256-HBXVW/SNIYZGAvvt47c32BbZYst7hPD9/vT03aXqcbo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Collections.NonGeneric.wasm",
        "name": "System.Collections.NonGeneric.0vo7b0koib.wasm",
        "hash": "sha256-nKQwOMhkGuZ8gVcFD1ubxu7/Sn6/0q9FS5YEqvo+BPw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Collections.Specialized.wasm",
        "name": "System.Collections.Specialized.c4nh1km8te.wasm",
        "hash": "sha256-tJ/SD0aQEca4iqlEZANoVRFANziO6EZYLU7l4V/qMEQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Collections.wasm",
        "name": "System.Collections.9jjfurskwc.wasm",
        "hash": "sha256-WwUyP5u2CzWN+VPI3h3l9/tp4y9IH2eJlO0d40Xt4qU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ComponentModel.Annotations.wasm",
        "name": "System.ComponentModel.Annotations.xjl5j72e6z.wasm",
        "hash": "sha256-XQutH/hvaz0yU4OU/Dw2RKggJ8wbiMuLFgPCSjb9xdc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ComponentModel.Primitives.wasm",
        "name": "System.ComponentModel.Primitives.g5s5q81w9q.wasm",
        "hash": "sha256-PFh0xmKJXKGFv7oheJxNO394P73toxlos5Dxv7cO2A8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ComponentModel.TypeConverter.wasm",
        "name": "System.ComponentModel.TypeConverter.usj3bk0r9u.wasm",
        "hash": "sha256-Av4M7daQ87Tm4Rj131k+PKjt8tv0/aWs/xoTxpmXAWE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ComponentModel.wasm",
        "name": "System.ComponentModel.csjo7z4dry.wasm",
        "hash": "sha256-1DK+7RVVxjyacfg+DeNoPPQTLvx1/Pns3EGltfpnprk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Console.wasm",
        "name": "System.Console.nxb308bmju.wasm",
        "hash": "sha256-K6+xirhgBTByD/t2o/Epnjdr47WXI2v2K3t2+1PPbD0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Data.Common.wasm",
        "name": "System.Data.Common.uc4f5xpvrw.wasm",
        "hash": "sha256-zlyHludDGqUpZFyCsmoQFcdhKclHAt3z6nO4H1l9Vqc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.DiagnosticSource.wasm",
        "name": "System.Diagnostics.DiagnosticSource.iv1flrayfg.wasm",
        "hash": "sha256-wqcBTHBjBXrRQvyXOQlB+lPbXgJwQDFok/g26EKJkkM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.Process.wasm",
        "name": "System.Diagnostics.Process.tgp491odwk.wasm",
        "hash": "sha256-7WZn7POf4JgoauoDKLVFlbwernOpQ/gCtByL3gvBfb4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Drawing.Primitives.wasm",
        "name": "System.Drawing.Primitives.ocp1icohcw.wasm",
        "hash": "sha256-mPiFnGXPmkMJirSPel/4vBIvxFeeyEST5C62WcvlKhE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Drawing.wasm",
        "name": "System.Drawing.nxsyxvwmnf.wasm",
        "hash": "sha256-++O+QvOuCpZBpRbCSQFHwgssCr1L7lmgFSIb2t0fSkc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.Compression.ZipFile.wasm",
        "name": "System.IO.Compression.ZipFile.gi9y77v4hc.wasm",
        "hash": "sha256-WMisLGaiqTnsf2GkS4/pn96ynAowSmjEaX+QozFZAz4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.Compression.wasm",
        "name": "System.IO.Compression.uugkpfmfs2.wasm",
        "hash": "sha256-qvgr8bCm7+eMSW6U/sc1DgxMztMgyS5KgHwtN0hCbu0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.FileSystem.DriveInfo.wasm",
        "name": "System.IO.FileSystem.DriveInfo.js6kxkcai8.wasm",
        "hash": "sha256-nc85SJRJ9euiLhKueOeDhlkga4Z0QJsSHVzSmxVwWzU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.FileSystem.Watcher.wasm",
        "name": "System.IO.FileSystem.Watcher.182rtdll4w.wasm",
        "hash": "sha256-/5q/gvmJiV/sAngqspCrX1K+0CCIJJWnuXvEtZk9xGg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.Pipelines.wasm",
        "name": "System.IO.Pipelines.7bjlegm3i4.wasm",
        "hash": "sha256-/XznLMKD/lvZ3q7SUcsE4NwA9NIAE4kmGrBooLC3cnQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Linq.Expressions.wasm",
        "name": "System.Linq.Expressions.1c5kyiy4lx.wasm",
        "hash": "sha256-/50oTxlwM/Om4hIySHTGdt8S1vYG3LUfdG6xsTenD6o=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Linq.Queryable.wasm",
        "name": "System.Linq.Queryable.0td2vhssfa.wasm",
        "hash": "sha256-nCrDQrUjnhjgUtxkaPraN4ZEonZUfx+BZjGmrNjfG1o=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Linq.wasm",
        "name": "System.Linq.jwbundqfee.wasm",
        "hash": "sha256-w8KQ6YsMAMkpXdSMaVmnoxcdp9eNeKF06e8fM5On9Pw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Memory.wasm",
        "name": "System.Memory.l4vubfyxxo.wasm",
        "hash": "sha256-FeAmoOt8JhQEzZG2CupvMvKrcLiNp774ONLG1Ir5ziM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Http.wasm",
        "name": "System.Net.Http.x1yvurqyoy.wasm",
        "hash": "sha256-2/dsJJHjTIH1AuRjPMYp9VgWL0AOrAFcuFJ3BEPM4Tc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Mail.wasm",
        "name": "System.Net.Mail.27xfmzzglb.wasm",
        "hash": "sha256-zse3/pCDna1MQpIpPw+05lHdtzEbM+e07NS4T41Sjx4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.NameResolution.wasm",
        "name": "System.Net.NameResolution.5362jilb8k.wasm",
        "hash": "sha256-URap0PuCQjVFGW6DVbXfajn64fYnXsZ4jkSC9c47Zik=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Ping.wasm",
        "name": "System.Net.Ping.tmfp7052uz.wasm",
        "hash": "sha256-ZVKn7B4Jd+hJN5NWL4MAcoZf2owJmSQ2X3yQQdXHaFA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Primitives.wasm",
        "name": "System.Net.Primitives.kcrm4ku8cj.wasm",
        "hash": "sha256-DJiWyzs2vz/2rcToQUifnwyiKvcaX/GssbE7gNCLzDo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Requests.wasm",
        "name": "System.Net.Requests.hufxwby9q5.wasm",
        "hash": "sha256-eVrfkRkEjzggg35KsjF3Sj3J0boNRP1LbilTO6xkCl8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Security.wasm",
        "name": "System.Net.Security.1oloco6xtd.wasm",
        "hash": "sha256-sQ+mAHRMGTZQUZWQvwIUGdtCQxhwLn4lTAXxIJo+OgY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.ServerSentEvents.wasm",
        "name": "System.Net.ServerSentEvents.5rko0u99kq.wasm",
        "hash": "sha256-EYe04Un/0TkVImEp/whgrlgREB8dW7vE/A779ifWb/M=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Sockets.wasm",
        "name": "System.Net.Sockets.d8gxepfq47.wasm",
        "hash": "sha256-bRJdJ70bWi5HTN4IyuYtSZgEdn8jfgwyhqL+6pvvZRM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.WebSockets.Client.wasm",
        "name": "System.Net.WebSockets.Client.2pz8ccddxq.wasm",
        "hash": "sha256-Sk3gjA519wuLc3v0K8T0Gb/OqTIBnECDRzVvI+84BR0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.WebSockets.wasm",
        "name": "System.Net.WebSockets.2ftm6o92z7.wasm",
        "hash": "sha256-bnRsVs2tXbQguVpjWjhgetPuChTBAEdIjYslBe8yQj8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ObjectModel.wasm",
        "name": "System.ObjectModel.qouzia703t.wasm",
        "hash": "sha256-GrARg06ICREksO5DxtnTqgmE7cPyv+rB2g1D2ev+fTA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Private.Uri.wasm",
        "name": "System.Private.Uri.l3ovoewh2z.wasm",
        "hash": "sha256-wdskFHDDecZqY/j+qY7WE9k1kBUEkg9cbUtS/F6VT+g=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Private.Xml.Linq.wasm",
        "name": "System.Private.Xml.Linq.5zrit3gasm.wasm",
        "hash": "sha256-IQeYNN235nBWDDTJGnZpbdgG6TAI67VLwu9NBvt0fv0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Private.Xml.wasm",
        "name": "System.Private.Xml.cdcczvp0ny.wasm",
        "hash": "sha256-YMckZXphAu+BTx7Her5zQB8C4PyD8YYGBWGEuN6DYFE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.InteropServices.wasm",
        "name": "System.Runtime.InteropServices.24m15tt7lr.wasm",
        "hash": "sha256-Mm8PRt+ZQeAALS9DXJL7mxSqJAuWzhige2A6I9Kq0Ts=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.wasm",
        "name": "System.Runtime.92cts68g00.wasm",
        "hash": "sha256-rymRgD76emHZHc5FfkCH0qChdJJg4QDBv6wVicLN/+c=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.Cryptography.wasm",
        "name": "System.Security.Cryptography.8g8i6dhjbs.wasm",
        "hash": "sha256-SOVKn9gBWTU8JRkPldP2MHhox5ZwrHT0oY2IawL1xzg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Text.Encodings.Web.wasm",
        "name": "System.Text.Encodings.Web.lviejamqyd.wasm",
        "hash": "sha256-723gZT2N7hL3iu09Tg1YmPaeiJWqqsDA3ghMs8CvkZ0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Text.Json.wasm",
        "name": "System.Text.Json.600jbbj3wk.wasm",
        "hash": "sha256-xm1FCgpgrPZNM9DSZdEDnDh6VNk3FjOsGh+y/bVWkcQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Text.RegularExpressions.wasm",
        "name": "System.Text.RegularExpressions.ktbrul26vi.wasm",
        "hash": "sha256-aJnBFDvEI2bBHkEgDrt8V12kjrmMPWGJZYkO1M0lQh0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.Channels.wasm",
        "name": "System.Threading.Channels.oz68m0de6j.wasm",
        "hash": "sha256-ZPs23ibx7jElVrcH0UCdDi8bR2YMg/mD8hKu9RCtuFA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.wasm",
        "name": "System.Threading.tyjykhjlav.wasm",
        "hash": "sha256-lYH9IXM9Whhp9VOm9H7wRgU4FOST75fh7q2RJApzRLg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Xml.Linq.wasm",
        "name": "System.Xml.Linq.h1uux8jz0h.wasm",
        "hash": "sha256-lcR9aQbNWsZio37Z/qtSMPYIx7GKzkXTik1dInQJosE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Xml.ReaderWriter.wasm",
        "name": "System.Xml.ReaderWriter.l82bcc5czs.wasm",
        "hash": "sha256-FWy0eCB4SflClJZcZryBjPy9p60aFMATXFR5Ij4ohhU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Xml.XDocument.wasm",
        "name": "System.Xml.XDocument.h15x086z27.wasm",
        "hash": "sha256-OyiIhBcRJB3lMdxY6zA0J7p54gSxgjpdwkkebvxco84=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.wasm",
        "name": "System.a3z5tpzyvn.wasm",
        "hash": "sha256-Gs5bAip0Y07Y7rdk4CYnpzrBeGplAudFAELUELfBy80=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "AllMultiplayerGames.WebAssembly.wasm",
        "name": "AllMultiplayerGames.WebAssembly.4qm2w9wza5.wasm",
        "hash": "sha256-jIOonX+f4W5KUQjfjF11Zd/hflQcLO9cfrnnDdMhvz4=",
        "cache": "force-cache"
      }
    ]
  },
  "debugLevel": 0,
  "linkerEnabled": true,
  "globalizationMode": "sharded",
  "extensions": {
    "blazor": {}
  },
  "runtimeConfig": {
    "runtimeOptions": {
      "configProperties": {
        "Microsoft.AspNetCore.Components.Routing.RegexConstraintSupport": false,
        "Microsoft.Extensions.DependencyInjection.VerifyOpenGenericServiceTrimmability": true,
        "System.ComponentModel.DefaultValueAttribute.IsSupported": false,
        "System.ComponentModel.Design.IDesignerHost.IsSupported": false,
        "System.ComponentModel.TypeConverter.EnableUnsafeBinaryFormatterInDesigntimeLicenseContextSerialization": false,
        "System.ComponentModel.TypeDescriptor.IsComObjectDescriptorSupported": false,
        "System.Data.DataSet.XmlSerializationIsSupported": false,
        "System.Diagnostics.Debugger.IsSupported": false,
        "System.Diagnostics.Metrics.Meter.IsSupported": false,
        "System.Diagnostics.Tracing.EventSource.IsSupported": false,
        "System.GC.Server": true,
        "System.Globalization.Invariant": false,
        "System.TimeZoneInfo.Invariant": false,
        "System.Linq.Enumerable.IsSizeOptimized": true,
        "System.Net.Http.EnableActivityPropagation": false,
        "System.Net.Http.WasmEnableStreamingResponse": true,
        "System.Net.SocketsHttpHandler.Http3Support": false,
        "System.Reflection.Metadata.MetadataUpdater.IsSupported": false,
        "System.Resources.ResourceManager.AllowCustomResourceTypes": false,
        "System.Resources.UseSystemResourceKeys": true,
        "System.Runtime.CompilerServices.RuntimeFeature.IsDynamicCodeSupported": true,
        "System.Runtime.InteropServices.BuiltInComInterop.IsSupported": false,
        "System.Runtime.InteropServices.EnableConsumingManagedCodeFromNativeHosting": false,
        "System.Runtime.InteropServices.EnableCppCLIHostActivation": false,
        "System.Runtime.InteropServices.Marshalling.EnableGeneratedComInterfaceComImportInterop": false,
        "System.Runtime.Serialization.EnableUnsafeBinaryFormatterSerialization": false,
        "System.StartupHookProvider.IsSupported": false,
        "System.Text.Encoding.EnableUnsafeUTF7Encoding": false,
        "System.Text.Json.JsonSerializer.IsReflectionEnabledByDefault": true,
        "System.Threading.Thread.EnableAutoreleasePool": false,
        "Microsoft.AspNetCore.Components.Endpoints.NavigationManager.DisableThrowNavigationException": false
      }
    }
  }
}/*json-end*/);export{gt as default,ft as dotnet,mt as exit};
