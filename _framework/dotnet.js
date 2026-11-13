//! Licensed to the .NET Foundation under one or more agreements.
//! The .NET Foundation licenses this file to you under the MIT license.

const e=()=>(async()=>{try{return new WebAssembly.Module(Uint8Array.from(atob("AGFzbQEAAAABBAFgAAADAgEAChABDgACaR9AAQMAAAsACxoL"),e=>e.codePointAt(0))),!0}catch(e){return!1}})(),o=async()=>WebAssembly.validate(new Uint8Array([0,97,115,109,1,0,0,0,1,5,1,96,0,1,123,3,2,1,0,10,15,1,13,0,65,1,253,15,65,2,253,15,253,128,2,11])),t=async()=>WebAssembly.validate(new Uint8Array([0,97,115,109,1,0,0,0,1,5,1,96,0,1,123,3,2,1,0,10,10,1,8,0,65,0,253,15,253,98,11])),n=Symbol.for("wasm promise_control");function r(e,o){let t=null;const r=new Promise(function(n,r){t={isDone:!1,promise:null,resolve:o=>{t.isDone||(t.isDone=!0,n(o),e&&e())},reject:e=>{t.isDone||(t.isDone=!0,r(e),o&&o())}}});t.promise=r;const s=r;return s[n]=t,{promise:s,promise_control:t}}function s(e){return e[n]}function i(e){e&&function(e){return void 0!==e[n]}(e)||We(!1,"Promise is not controllable")}const a="__mono_message__",l=["debug","log","trace","warn","info","error"],c="MONO_WASM: ";let d,u,f,m,g,p;function h(e){m=e}function b(e){if(ke.diagnosticTracing){const o="function"==typeof e?e():e;console.debug(c+o)}}function w(e,...o){console.info(c+e,...o)}function y(e,...o){console.info(e,...o)}function v(e,...o){console.warn(c+e,...o)}function _(e,...o){if(o&&o.length>0&&o[0]&&"object"==typeof o[0]){if(o[0].silent)return;if(o[0].toString)return void console.error(c+e,o[0].toString())}console.error(c+e,...o)}function A(e,o,t){return function(...n){try{let r=n[0];if(void 0===r)r="undefined";else if(null===r)r="null";else if("function"==typeof r)r=r.toString();else if("string"!=typeof r)try{r=JSON.stringify(r)}catch(e){r=r.toString()}o(t?JSON.stringify({method:e,payload:r,arguments:n.slice(1)}):[e+r,...n.slice(1)])}catch(e){f.error(`proxyConsole failed: ${e}`)}}}function x(e,o,t){u=o,m=e,f={...o};const n=`${t}/console`.replace("https://","wss://").replace("http://","ws://");d=new WebSocket(n),d.addEventListener("error",E),d.addEventListener("close",j),function(){for(const e of l)u[e]=A(`console.${e}`,R,!0)}()}function T(e){let o=30;const t=()=>{d?0==d.bufferedAmount||0==o?(e&&y(e),function(){for(const e of l)u[e]=A(`console.${e}`,f.log,!1)}(),d.removeEventListener("error",E),d.removeEventListener("close",j),d.close(1e3,e),d=void 0):(o--,globalThis.setTimeout(t,100)):e&&f&&f.log(e)};t()}function R(e){d&&d.readyState===WebSocket.OPEN?d.send(e):f.log(e)}function E(e){f.error(`[${m}] proxy console websocket error: ${e}`,e)}function j(e){f.debug(`[${m}] proxy console websocket closed: ${e}`,e)}function D(){ke.preferredIcuAsset=C(ke.config);let e="invariant"==ke.config.globalizationMode;if(!e)if(ke.preferredIcuAsset)ke.diagnosticTracing&&b("ICU data archive(s) available, disabling invariant mode");else{if("custom"===ke.config.globalizationMode||"all"===ke.config.globalizationMode||"sharded"===ke.config.globalizationMode){const e="invariant globalization mode is inactive and no ICU data archives are available";throw _(`ERROR: ${e}`),new Error(e)}ke.diagnosticTracing&&b("ICU data archive(s) not available, using invariant globalization mode"),e=!0,ke.preferredIcuAsset=null}const o="DOTNET_SYSTEM_GLOBALIZATION_INVARIANT",t=ke.config.environmentVariables;if(void 0===t[o]&&e&&(t[o]="1"),void 0===t.TZ)try{const e=Intl.DateTimeFormat().resolvedOptions().timeZone||null;e&&(t.TZ=e)}catch(e){w("failed to detect timezone, will fallback to UTC")}}function C(e){var o;if((null===(o=e.resources)||void 0===o?void 0:o.icu)&&"invariant"!=e.globalizationMode){const o=e.applicationCulture||(Me?globalThis.navigator&&globalThis.navigator.languages&&globalThis.navigator.languages[0]:Intl.DateTimeFormat().resolvedOptions().locale);e.applicationCulture||(e.applicationCulture=o);const t=e.resources.icu;let n=null;if("custom"===e.globalizationMode){if(t.length>=1)return t[0].name}else o&&"all"!==e.globalizationMode?"sharded"===e.globalizationMode&&(n=function(e){const o=e.split("-")[0];return"en"===o||["fr","fr-FR","it","it-IT","de","de-DE","es","es-ES"].includes(e)?"icudt_EFIGS.dat":["zh","ko","ja"].includes(o)?"icudt_CJK.dat":"icudt_no_CJK.dat"}(o)):n="icudt.dat";if(n)for(let e=0;e<t.length;e++){const o=t[e];if(o.virtualPath===n)return o.name}}return e.globalizationMode="invariant",null}(new Date).valueOf();const M=class{constructor(e){this.url=e}toString(){return this.url}};async function S(e){if(Se&&"function"!=typeof globalThis.atob){const e="ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";globalThis.atob=o=>{const t=String(o).replace(/=+$/,"");let n="";for(let o=0,r=0,s=0;s<t.length;s++){const i=e.indexOf(t.charAt(s));-1!==i&&(r=o%4?64*r+i:i,o++%4&&(n+=String.fromCharCode(255&r>>(-2*o&6))))}return n}}if(Ee){const e=await import(/*! webpackIgnore: true */"process"),o=14;if(e.versions.node.split(".")[0]<o)throw new Error(`NodeJS at '${e.execPath}' has too low version '${e.versions.node}', please use at least ${o}.`)}const o=/*! webpackIgnore: true */import.meta.url,t=o.indexOf("?");var n;if(t>0&&(ke.modulesUniqueQuery=o.substring(t)),ke.scriptUrl=o.replace(/\\/g,"/").replace(/[?#].*/,""),ke.scriptDirectory=(n=ke.scriptUrl).slice(0,n.lastIndexOf("/"))+"/",ke.locateFile=e=>"URL"in globalThis&&globalThis.URL!==M?new URL(e,ke.scriptDirectory).toString():I(e)?e:ke.scriptDirectory+e,ke.fetch_like=U,ke.out=console.log,ke.err=console.error,ke.onDownloadResourceProgress=e.onDownloadResourceProgress,Me&&globalThis.navigator){const e=globalThis.navigator,o=e.userAgentData&&e.userAgentData.brands;o&&o.length>0?ke.isChromium=o.some(e=>"Google Chrome"===e.brand||"Microsoft Edge"===e.brand||"Chromium"===e.brand):e.userAgent&&(ke.isChromium=e.userAgent.includes("Chrome"),ke.isFirefox=e.userAgent.includes("Firefox"))}void 0===globalThis.URL&&(globalThis.URL=M)}async function U(e,o){try{const t="function"==typeof globalThis.fetch;if(Ee){const n=e.startsWith("file://");if(!n&&t)return globalThis.fetch(e,o||{credentials:"same-origin"});g||(p=await import(/*! webpackIgnore: true */"url"),g=await import(/*! webpackIgnore: true */"fs")),n&&(e=p.fileURLToPath(e));const r=await g.promises.readFile(e);return{ok:!0,headers:{length:0,get:()=>null},url:e,arrayBuffer:()=>r,json:()=>JSON.parse(r),text:()=>{throw new Error("NotImplementedException")}}}if(t)return globalThis.fetch(e,o||{credentials:"same-origin"});if("function"==typeof read)return{ok:!0,url:e,headers:{length:0,get:()=>null},arrayBuffer:()=>new Uint8Array(read(e,"binary")),json:()=>JSON.parse(read(e,"utf8")),text:()=>read(e,"utf8")}}catch(o){return{ok:!1,url:e,status:500,headers:{length:0,get:()=>null},statusText:"ERR28: "+o,arrayBuffer:()=>{throw o},json:()=>{throw o},text:()=>{throw o}}}throw new Error("No fetch implementation available")}const P=/^[a-zA-Z][a-zA-Z\d+\-.]*?:\/\//,k=/[a-zA-Z]:[\\/]/;function I(e){return Ee||Se?e.startsWith("/")||e.startsWith("\\")||-1!==e.indexOf("///")||k.test(e):P.test(e)}let O,$=0;const L=[],N=[],z=new Map,F={"js-module-runtime":!0,"js-module-dotnet":!0,"js-module-native":!0,"js-module-diagnostics":!0},W={...F,"js-module-library-initializer":!0},V={...F,dotnetwasm:!0,heap:!0,manifest:!0},B={...W,manifest:!0},J={...W,dotnetwasm:!0},H={dotnetwasm:!0,symbols:!0},Q={...W,dotnetwasm:!0,symbols:!0},q={symbols:!0};function G(e){return!("icu"==e.behavior&&e.name!=ke.preferredIcuAsset)}function Z(e,o,t){null!=o||(o=[]),We(1==o.length,`Expect to have one ${t} asset in resources`);const n=o[0];return n.behavior=t,K(n),e.push(n),n}function K(e){V[e.behavior]&&z.set(e.behavior,e)}function X(e){We(V[e],`Unknown single asset behavior ${e}`);const o=z.get(e);if(o&&!o.resolvedUrl)if(o.resolvedUrl=ke.locateFile(o.name),F[o.behavior]){const e=me(o);e?("string"!=typeof e&&We(!1,"loadBootResource response for 'dotnetjs' type should be a URL string"),o.resolvedUrl=e):o.resolvedUrl=le(o.resolvedUrl,o.behavior)}else if("dotnetwasm"!==o.behavior)throw new Error(`Unknown single asset behavior ${e}`);return o}function Y(e){const o=X(e);return We(o,`Single asset for ${e} not found`),o}let ee=!1;async function oe(){if(!ee){ee=!0,ke.diagnosticTracing&&b("mono_download_assets");try{const e=[],o=[],t=(e,o)=>{!Q[e.behavior]&&G(e)&&ke.expected_instantiated_assets_count++,!J[e.behavior]&&G(e)&&(ke.expected_downloaded_assets_count++,o.push(se(e)))};for(const o of L)t(o,e);for(const e of N)t(e,o);ke.allDownloadsQueued.promise_control.resolve(),Promise.all([...e,...o]).then(()=>{ke.allDownloadsFinished.promise_control.resolve()}).catch(e=>{throw ke.err("Error in mono_download_assets: "+e),Xe(1,e),e}),await ke.runtimeModuleLoaded.promise;const n=async e=>{const o=await e;if(H[o.behavior])return"symbols"===o.behavior&&(await Pe.instantiate_symbols_asset(o),ge(o)),void++ke.actual_downloaded_assets_count;if(o.buffer){if(!Q[o.behavior]){o.buffer&&"object"==typeof o.buffer||We(!1,"asset buffer must be array-like or buffer-like or promise of these"),"string"!=typeof o.resolvedUrl&&We(!1,"resolvedUrl must be string");const e=o.resolvedUrl,t=await o.buffer,n=new Uint8Array(t);ge(o),await Pe.beforeOnRuntimeInitialized.promise,await Pe.afterInstantiateWasm.promise,Pe.instantiate_asset(o,e,n)}}else o.isOptional||We(!1,"Expected asset to have the downloaded buffer"),!J[o.behavior]&&G(o)&&ke.expected_downloaded_assets_count--,!Q[o.behavior]&&G(o)&&ke.expected_instantiated_assets_count--},r=[],s=[];for(const o of e)r.push(n(o));for(const e of o)s.push(n(e));Promise.all(r).then(()=>{Ce||Pe.coreAssetsInMemory.promise_control.resolve()}).catch(e=>{throw ke.err("Error in mono_download_assets: "+e),Xe(1,e),e}),Promise.all(s).then(async()=>{Ce||(await Pe.coreAssetsInMemory.promise,Pe.allAssetsInMemory.promise_control.resolve())}).catch(e=>{throw ke.err("Error in mono_download_assets: "+e),Xe(1,e),e})}catch(e){throw ke.err("Error in mono_download_assets: "+e),e}}}let te=!1;function ne(){if(te)return;te=!0;const e=ke.config,o=[];if(e.assets)for(const o of e.assets)"object"!=typeof o&&We(!1,`asset must be object, it was ${typeof o} : ${o}`),"string"!=typeof o.behavior&&We(!1,"asset behavior must be known string"),"string"!=typeof o.name&&We(!1,"asset name must be string"),o.resolvedUrl&&"string"!=typeof o.resolvedUrl&&We(!1,"asset resolvedUrl could be string"),o.hash&&"string"!=typeof o.hash&&We(!1,"asset resolvedUrl could be string"),o.pendingDownload&&"object"!=typeof o.pendingDownload&&We(!1,"asset pendingDownload could be object"),o.isCore?L.push(o):N.push(o),K(o);else if(e.resources){const t=e.resources;t.wasmNative||We(!1,"resources.wasmNative must be defined"),t.jsModuleNative||We(!1,"resources.jsModuleNative must be defined"),t.jsModuleRuntime||We(!1,"resources.jsModuleRuntime must be defined"),Z(N,t.wasmNative,"dotnetwasm"),Z(o,t.jsModuleNative,"js-module-native"),Z(o,t.jsModuleRuntime,"js-module-runtime"),t.jsModuleDiagnostics&&Z(o,t.jsModuleDiagnostics,"js-module-diagnostics");const n=(e,o,t)=>{const n=e;n.behavior=o,t?(n.isCore=!0,L.push(n)):N.push(n)};if(t.coreAssembly)for(let e=0;e<t.coreAssembly.length;e++)n(t.coreAssembly[e],"assembly",!0);if(t.assembly)for(let e=0;e<t.assembly.length;e++)n(t.assembly[e],"assembly",!t.coreAssembly);if(0!=e.debugLevel&&ke.isDebuggingSupported()){if(t.corePdb)for(let e=0;e<t.corePdb.length;e++)n(t.corePdb[e],"pdb",!0);if(t.pdb)for(let e=0;e<t.pdb.length;e++)n(t.pdb[e],"pdb",!t.corePdb)}if(e.loadAllSatelliteResources&&t.satelliteResources)for(const e in t.satelliteResources)for(let o=0;o<t.satelliteResources[e].length;o++){const r=t.satelliteResources[e][o];r.culture=e,n(r,"resource",!t.coreAssembly)}if(t.coreVfs)for(let e=0;e<t.coreVfs.length;e++)n(t.coreVfs[e],"vfs",!0);if(t.vfs)for(let e=0;e<t.vfs.length;e++)n(t.vfs[e],"vfs",!t.coreVfs);const r=C(e);if(r&&t.icu)for(let e=0;e<t.icu.length;e++){const o=t.icu[e];o.name===r&&n(o,"icu",!1)}if(t.wasmSymbols)for(let e=0;e<t.wasmSymbols.length;e++)n(t.wasmSymbols[e],"symbols",!1)}if(e.appsettings)for(let o=0;o<e.appsettings.length;o++){const t=e.appsettings[o],n=pe(t);"appsettings.json"!==n&&n!==`appsettings.${e.applicationEnvironment}.json`||N.push({name:t,behavior:"vfs",cache:"no-cache",useCredentials:!0})}e.assets=[...L,...N,...o]}async function re(e){const o=await se(e);return await o.pendingDownloadInternal.response,o.buffer}async function se(e){try{return await ie(e)}catch(o){if(!ke.enableDownloadRetry)throw o;if(Se||Ee)throw o;if(e.pendingDownload&&e.pendingDownloadInternal==e.pendingDownload)throw o;if(e.resolvedUrl&&-1!=e.resolvedUrl.indexOf("file://"))throw o;if(o&&404==o.status)throw o;e.pendingDownloadInternal=void 0,await ke.allDownloadsQueued.promise;try{return ke.diagnosticTracing&&b(`Retrying download '${e.name}'`),await ie(e)}catch(o){return e.pendingDownloadInternal=void 0,await new Promise(e=>globalThis.setTimeout(e,100)),ke.diagnosticTracing&&b(`Retrying download (2) '${e.name}' after delay`),await ie(e)}}}async function ie(e){for(;O;)await O.promise;try{++$,$==ke.maxParallelDownloads&&(ke.diagnosticTracing&&b("Throttling further parallel downloads"),O=r());const o=await async function(e){if(e.pendingDownload&&(e.pendingDownloadInternal=e.pendingDownload),e.pendingDownloadInternal&&e.pendingDownloadInternal.response)return e.pendingDownloadInternal.response;if(e.buffer){const o=await e.buffer;return e.resolvedUrl||(e.resolvedUrl="undefined://"+e.name),e.pendingDownloadInternal={url:e.resolvedUrl,name:e.name,response:Promise.resolve({ok:!0,arrayBuffer:()=>o,json:()=>JSON.parse(new TextDecoder("utf-8").decode(o)),text:()=>new TextDecoder("utf-8").decode(o),headers:{get:()=>{}}})},e.pendingDownloadInternal.response}const o=e.loadRemote&&ke.config.remoteSources?ke.config.remoteSources:[""];let t;for(let n of o){n=n.trim(),"./"===n&&(n="");const o=ae(e,n);e.name===o?ke.diagnosticTracing&&b(`Attempting to download '${o}'`):ke.diagnosticTracing&&b(`Attempting to download '${o}' for ${e.name}`);try{e.resolvedUrl=o;const n=ue(e);if(e.pendingDownloadInternal=n,t=await n.response,!t||!t.ok)continue;return t}catch(e){t||(t={ok:!1,url:o,status:0,statusText:""+e});continue}}const n=e.isOptional||e.name.match(/\.pdb$/)&&ke.config.ignorePdbLoadErrors;if(t||We(!1,`Response undefined ${e.name}`),!n){const o=new Error(`download '${t.url}' for ${e.name} failed ${t.status} ${t.statusText}`);throw o.status=t.status,o}w(`optional download '${t.url}' for ${e.name} failed ${t.status} ${t.statusText}`)}(e);return o?(H[e.behavior]||(e.buffer=await o.arrayBuffer(),++ke.actual_downloaded_assets_count),e):e}finally{if(--$,O&&$==ke.maxParallelDownloads-1){ke.diagnosticTracing&&b("Resuming more parallel downloads");const e=O;O=void 0,e.promise_control.resolve()}}}function ae(e,o){let t;return null==o&&We(!1,`sourcePrefix must be provided for ${e.name}`),e.resolvedUrl?t=e.resolvedUrl:(t=""===o?"assembly"===e.behavior||"pdb"===e.behavior?e.name:"resource"===e.behavior&&e.culture&&""!==e.culture?`${e.culture}/${e.name}`:e.name:o+e.name,t=le(ke.locateFile(t),e.behavior)),t&&"string"==typeof t||We(!1,"attemptUrl need to be path or url string"),t}function le(e,o){return ke.modulesUniqueQuery&&B[o]&&(e+=ke.modulesUniqueQuery),e}let ce=0;const de=new Set;function ue(e){try{e.resolvedUrl||We(!1,"Request's resolvedUrl must be set");const o=function(e){let o=e.resolvedUrl;if(ke.loadBootResource){const t=me(e);if(t instanceof Promise)return t;"string"==typeof t&&(o=t)}const t={};return e.cache?t.cache=e.cache:ke.config.disableNoCacheFetch||(t.cache="no-cache"),e.useCredentials?t.credentials="include":!ke.config.disableIntegrityCheck&&e.hash&&(t.integrity=e.hash),ke.fetch_like(o,t)}(e),t={name:e.name,url:e.resolvedUrl,response:o};return de.add(e.name),t.response.then(()=>{"assembly"==e.behavior&&ke.loadedAssemblies.push(e.name),ce++,ke.onDownloadResourceProgress&&ke.onDownloadResourceProgress(ce,de.size)}),t}catch(o){const t={ok:!1,url:e.resolvedUrl,status:500,statusText:"ERR29: "+o,arrayBuffer:()=>{throw o},json:()=>{throw o}};return{name:e.name,url:e.resolvedUrl,response:Promise.resolve(t)}}}const fe={resource:"assembly",assembly:"assembly",pdb:"pdb",icu:"globalization",vfs:"configuration",manifest:"manifest",dotnetwasm:"dotnetwasm","js-module-dotnet":"dotnetjs","js-module-native":"dotnetjs","js-module-runtime":"dotnetjs"};function me(e){var o;if(ke.loadBootResource){const t=null!==(o=e.hash)&&void 0!==o?o:"",n=e.resolvedUrl,r=fe[e.behavior];if(r){const o=ke.loadBootResource(r,e.name,n,t,e.behavior);return"string"==typeof o?function(e){return"string"!=typeof e&&We(!1,"url must be a string"),!I(e)&&0!==e.indexOf("./")&&0!==e.indexOf("../")&&globalThis.URL&&globalThis.document&&globalThis.document.baseURI&&(e=new URL(e,globalThis.document.baseURI).toString()),e}(o):o}}}function ge(e){e.pendingDownloadInternal=null,e.pendingDownload=null,e.buffer=null,e.moduleExports=null}function pe(e){let o=e.lastIndexOf("/");return o>=0&&o++,e.substring(o)}async function he(e){e&&await Promise.all((null!=e?e:[]).map(e=>async function(e){try{const o=e.name;if(!e.moduleExports){const t=le(ke.locateFile(o),"js-module-library-initializer");ke.diagnosticTracing&&b(`Attempting to import '${t}' for ${e}`),e.moduleExports=await import(/*! webpackIgnore: true */t)}ke.libraryInitializers.push({scriptName:o,exports:e.moduleExports})}catch(o){v(`Failed to import library initializer '${e}': ${o}`)}}(e)))}async function be(e,o){if(!ke.libraryInitializers)return;const t=[];for(let n=0;n<ke.libraryInitializers.length;n++){const r=ke.libraryInitializers[n];r.exports[e]&&t.push(we(r.scriptName,e,()=>r.exports[e](...o)))}await Promise.all(t)}async function we(e,o,t){try{await t()}catch(t){throw v(`Failed to invoke '${o}' on library initializer '${e}': ${t}`),Xe(1,t),t}}function ye(e,o){if(e===o)return e;const t={...o};return void 0!==t.assets&&t.assets!==e.assets&&(t.assets=[...e.assets||[],...t.assets||[]]),void 0!==t.resources&&(t.resources=_e(e.resources||{assembly:[],jsModuleNative:[],jsModuleRuntime:[],wasmNative:[]},t.resources)),void 0!==t.environmentVariables&&(t.environmentVariables={...e.environmentVariables||{},...t.environmentVariables||{}}),void 0!==t.runtimeOptions&&t.runtimeOptions!==e.runtimeOptions&&(t.runtimeOptions=[...e.runtimeOptions||[],...t.runtimeOptions||[]]),Object.assign(e,t)}function ve(e,o){if(e===o)return e;const t={...o};return t.config&&(e.config||(e.config={}),t.config=ye(e.config,t.config)),Object.assign(e,t)}function _e(e,o){if(e===o)return e;const t={...o};return void 0!==t.coreAssembly&&(t.coreAssembly=[...e.coreAssembly||[],...t.coreAssembly||[]]),void 0!==t.assembly&&(t.assembly=[...e.assembly||[],...t.assembly||[]]),void 0!==t.lazyAssembly&&(t.lazyAssembly=[...e.lazyAssembly||[],...t.lazyAssembly||[]]),void 0!==t.corePdb&&(t.corePdb=[...e.corePdb||[],...t.corePdb||[]]),void 0!==t.pdb&&(t.pdb=[...e.pdb||[],...t.pdb||[]]),void 0!==t.jsModuleNative&&(t.jsModuleNative=[...e.jsModuleNative||[],...t.jsModuleNative||[]]),void 0!==t.jsModuleDiagnostics&&(t.jsModuleDiagnostics=[...e.jsModuleDiagnostics||[],...t.jsModuleDiagnostics||[]]),void 0!==t.jsModuleRuntime&&(t.jsModuleRuntime=[...e.jsModuleRuntime||[],...t.jsModuleRuntime||[]]),void 0!==t.wasmSymbols&&(t.wasmSymbols=[...e.wasmSymbols||[],...t.wasmSymbols||[]]),void 0!==t.wasmNative&&(t.wasmNative=[...e.wasmNative||[],...t.wasmNative||[]]),void 0!==t.icu&&(t.icu=[...e.icu||[],...t.icu||[]]),void 0!==t.satelliteResources&&(t.satelliteResources=function(e,o){if(e===o)return e;for(const t in o)e[t]=[...e[t]||[],...o[t]||[]];return e}(e.satelliteResources||{},t.satelliteResources||{})),void 0!==t.modulesAfterConfigLoaded&&(t.modulesAfterConfigLoaded=[...e.modulesAfterConfigLoaded||[],...t.modulesAfterConfigLoaded||[]]),void 0!==t.modulesAfterRuntimeReady&&(t.modulesAfterRuntimeReady=[...e.modulesAfterRuntimeReady||[],...t.modulesAfterRuntimeReady||[]]),void 0!==t.extensions&&(t.extensions={...e.extensions||{},...t.extensions||{}}),void 0!==t.vfs&&(t.vfs=[...e.vfs||[],...t.vfs||[]]),Object.assign(e,t)}function Ae(){const e=ke.config;if(e.environmentVariables=e.environmentVariables||{},e.runtimeOptions=e.runtimeOptions||[],e.resources=e.resources||{assembly:[],jsModuleNative:[],jsModuleRuntime:[],wasmNative:[],vfs:[],satelliteResources:{}},e.assets){ke.diagnosticTracing&&b("config.assets is deprecated, use config.resources instead");for(const o of e.assets){const t={};switch(o.behavior){case"assembly":t.assembly=[o];break;case"pdb":t.pdb=[o];break;case"resource":t.satelliteResources={},t.satelliteResources[o.culture]=[o];break;case"icu":t.icu=[o];break;case"symbols":t.wasmSymbols=[o];break;case"vfs":t.vfs=[o];break;case"dotnetwasm":t.wasmNative=[o];break;case"js-module-runtime":t.jsModuleRuntime=[o];break;case"js-module-native":t.jsModuleNative=[o];break;case"js-module-diagnostics":t.jsModuleDiagnostics=[o];break;case"js-module-dotnet":break;default:throw new Error(`Unexpected behavior ${o.behavior} of asset ${o.name}`)}_e(e.resources,t)}}e.debugLevel,void 0===e.virtualWorkingDirectory&&(e.virtualWorkingDirectory=Ue),e.applicationEnvironment||(e.applicationEnvironment="Production"),e.applicationCulture&&(e.environmentVariables.LANG=`${e.applicationCulture}.UTF-8`),Pe.diagnosticTracing=ke.diagnosticTracing=!!e.diagnosticTracing,Pe.waitForDebugger=e.waitForDebugger,ke.maxParallelDownloads=e.maxParallelDownloads||ke.maxParallelDownloads,ke.enableDownloadRetry=void 0!==e.enableDownloadRetry?e.enableDownloadRetry:ke.enableDownloadRetry}let xe=!1;async function Te(e){var o;if(xe)await ke.afterConfigLoaded.promise;else try{if(xe=!0,Ae(),await he(null===(o=ke.config.resources)||void 0===o?void 0:o.modulesAfterConfigLoaded),await be("onRuntimeConfigLoaded",[ke.config]),e.onConfigLoaded)try{await e.onConfigLoaded(ke.config,Oe),Ae()}catch(e){throw _("onConfigLoaded() failed",e),e}Ae(),ke.afterConfigLoaded.promise_control.resolve(ke.config)}catch(o){const t=`Failed to initialize config ${o} ${null==o?void 0:o.stack}`;throw ke.config=e.config=Object.assign(ke.config,{message:t,error:o,isError:!0}),Xe(1,new Error(t)),o}}function Re(){return!!globalThis.navigator&&(ke.isChromium||ke.isFirefox)}"function"==typeof importScripts&&(globalThis.dotnetSidecar=!0);const Ee="object"==typeof process&&"object"==typeof process.versions&&"string"==typeof process.versions.node,je="function"==typeof importScripts,De=je&&"undefined"!=typeof dotnetSidecar,Ce=je&&!De,Me="object"==typeof window||je&&!Ee,Se=!Me&&!Ee,Ue="/";let Pe={},ke={},Ie={},Oe={},$e={},Le=!1;const Ne={},ze={config:Ne},Fe={mono:{},binding:{},internal:$e,module:ze,loaderHelpers:ke,runtimeHelpers:Pe,diagnosticHelpers:Ie,api:Oe};function We(e,o){if(e)return;const t="Assert failed: "+("function"==typeof o?o():o),n=new Error(t);_(t,n),Pe.nativeAbort(n)}function Ve(){return void 0!==ke.exitCode}function Be(){return Pe.runtimeReady&&!Ve()}function Je(){Ve()&&We(!1,`.NET runtime already exited with ${ke.exitCode} ${ke.exitReason}. You can use dotnet.runMain() which doesn't exit the runtime.`),Pe.runtimeReady||We(!1,".NET runtime didn't start yet. Please call dotnet.create() first.")}function He(){Me&&(globalThis.addEventListener("unhandledrejection",eo),globalThis.addEventListener("error",oo))}let Qe,qe;function Ge(){Qe=ze.onAbort,qe=ze.onExit,ze.onAbort=Ke,ze.onExit=Ze}function Ze(e){qe&&qe(e),Xe(e,ke.exitReason)}function Ke(e){Qe&&Qe(e||ke.exitReason),Xe(1,e||ke.exitReason)}function Xe(e,o){var t;const n=o&&"object"==typeof o;e=n&&"number"==typeof o.status?o.status:void 0===e?-1:e;const r=n&&"string"==typeof o.message?o.message:""+o;(o=n?o:Pe.ExitStatus?function(e,o){const t=new Pe.ExitStatus(e);return t.message=o,t.toString=()=>o,t}(e,r):new Error("Exit with code "+e+" "+r)).status=e,o.message||(o.message=r);const s=""+(o.stack||(new Error).stack);try{Object.defineProperty(o,"stack",{get:()=>s})}catch(e){}const i=!!o.silent;if(o.silent=!0,Ve())ke.diagnosticTracing&&b("mono_exit called after exit");else{try{ze.onAbort==Ke&&(ze.onAbort=Qe),ze.onExit==Ze&&(ze.onExit=qe),Me&&(globalThis.removeEventListener("unhandledrejection",eo),globalThis.removeEventListener("error",oo)),Pe.runtimeReady?(Pe.jiterpreter_dump_stats&&Pe.jiterpreter_dump_stats(!1),0===e&&(null===(t=ke.config)||void 0===t?void 0:t.interopCleanupOnExit)&&Pe.forceDisposeProxies(!0,!0)):(ke.diagnosticTracing&&b(`abort_startup, reason: ${o}`),function(e){ke.allDownloadsQueued.promise_control.reject(e),ke.allDownloadsFinished.promise_control.reject(e),ke.afterConfigLoaded.promise_control.reject(e),ke.wasmCompilePromise.promise_control.reject(e),ke.runtimeModuleLoaded.promise_control.reject(e),Pe.dotnetReady&&(Pe.dotnetReady.promise_control.reject(e),Pe.afterInstantiateWasm.promise_control.reject(e),Pe.afterPreRun.promise_control.reject(e),Pe.beforeOnRuntimeInitialized.promise_control.reject(e),Pe.afterOnRuntimeInitialized.promise_control.reject(e),Pe.afterPostRun.promise_control.reject(e))}(o))}catch(e){v("mono_exit A failed",e)}try{i||(function(e,o){if(0!==e&&o){const e=Pe.ExitStatus&&o instanceof Pe.ExitStatus?b:_;"string"==typeof o?e(o):(void 0===o.stack&&(o.stack=(new Error).stack+""),o.message?e(Pe.stringify_as_error_with_stack?Pe.stringify_as_error_with_stack(o.message+"\n"+o.stack):o.message+"\n"+o.stack):e(JSON.stringify(o)))}!Ce&&ke.config&&(ke.config.logExitCode?ke.config.forwardConsole?T("WASM EXIT "+e):y("WASM EXIT "+e):ke.config.forwardConsole&&T())}(e,o),function(e){if(Me&&!Ce&&ke.config&&ke.config.appendElementOnExit&&document){const o=document.createElement("label");o.id="tests_done",0!==e&&(o.style.background="red"),o.innerHTML=""+e,document.body.appendChild(o)}}(e))}catch(e){v("mono_exit B failed",e)}ke.exitCode=e,ke.exitReason||(ke.exitReason=o),!Ce&&Pe.runtimeReady&&ze.runtimeKeepalivePop()}if(ke.config&&ke.config.asyncFlushOnExit&&0===e)throw(async()=>{try{await async function(){if(Ee)try{const e=await import(/*! webpackIgnore: true */"process"),o=e=>new Promise((o,t)=>{e.on("error",t),e.end("","utf8",o)}),t=o(e.stderr),n=o(e.stdout);let r;const s=new Promise(e=>{r=setTimeout(()=>e("timeout"),1e3)});await Promise.race([Promise.all([n,t]),s]),clearTimeout(r)}catch(e){_(`flushing std* streams failed: ${e}`)}}()}finally{Ye(e,o)}})(),o;Ye(e,o)}function Ye(e,o){if(Pe.runtimeReady&&Pe.nativeExit)try{Pe.nativeExit(e)}catch(e){!Pe.ExitStatus||e instanceof Pe.ExitStatus||v("set_exit_code_and_quit_now failed: "+e.toString())}if(0!==e||!Me)throw Ee?process.exit(e):Pe.quit&&Pe.quit(e,o),o}function eo(e){to(e,e.reason,"rejection")}function oo(e){to(e,e.error,"error")}function to(e,o,t){e.preventDefault();try{o||(o=new Error("Unhandled "+t)),void 0===o.stack&&(o.stack=(new Error).stack),o.stack=o.stack+"",o.silent||(_("Unhandled error:",o),Xe(1,o))}catch(e){}}!function(n){if(Le)throw new Error("Loader module already loaded");Le=!0,Pe=n.runtimeHelpers,ke=n.loaderHelpers,Ie=n.diagnosticHelpers,Oe=n.api,$e=n.internal,Object.assign(Oe,{INTERNAL:$e,invokeLibraryInitializers:be}),Object.assign(n.module,{config:ye(Ne,{environmentVariables:{}})});const a={mono_wasm_bindings_is_ready:!1,config:n.module.config,diagnosticTracing:!1,nativeAbort:e=>{throw e||new Error("abort")},nativeExit:e=>{throw new Error("exit:"+e)}},l={gitHash:"297acf930fb0f5c07fd4e51d78e521b4ad2e5d1f",config:n.module.config,diagnosticTracing:!1,maxParallelDownloads:16,enableDownloadRetry:!0,_loaded_files:[],loadedFiles:[],loadedAssemblies:[],libraryInitializers:[],workerNextNumber:1,actual_downloaded_assets_count:0,actual_instantiated_assets_count:0,expected_downloaded_assets_count:0,expected_instantiated_assets_count:0,afterConfigLoaded:r(),allDownloadsQueued:r(),allDownloadsFinished:r(),wasmCompilePromise:r(),runtimeModuleLoaded:r(),loadingWorkers:r(),is_exited:Ve,is_runtime_running:Be,assert_runtime_running:Je,mono_exit:Xe,createPromiseController:r,getPromiseController:s,assertIsControllablePromise:i,mono_download_assets:oe,resolve_single_asset_path:Y,setup_proxy_console:x,set_thread_prefix:h,installUnhandledErrorHandler:He,retrieve_asset_download:re,invokeLibraryInitializers:be,isDebuggingSupported:Re,exceptionsFinal:e,simd:t,relaxedSimd:o};Object.assign(Pe,a),Object.assign(ke,l)}(Fe);let no,ro,so,io=!1,ao=!1;async function lo(e){if(!ao){if(ao=!0,Me&&ke.config.forwardConsole&&void 0!==globalThis.WebSocket&&x("main",globalThis.console,globalThis.location.origin),ze||We(!1,"Null moduleConfig"),ke.config||We(!1,"Null moduleConfig.config"),"function"==typeof e){const o=e(Fe.api);if(o.ready)throw new Error("Module.ready couldn't be redefined.");Object.assign(ze,o),ve(ze,o)}else{if("object"!=typeof e)throw new Error("Can't use moduleFactory callback of createDotnetRuntime function.");ve(ze,e)}await S(ze)}}async function co(e){return await lo(e),ke.config.exitOnUnhandledError&&He(),Ge(),async function(){var e;await Te(ze),ne();const o=uo();(async function(){try{const e=Y("dotnetwasm");await se(e),e&&e.pendingDownloadInternal&&e.pendingDownloadInternal.response||We(!1,"Can't load dotnet.native.wasm");const o=await e.pendingDownloadInternal.response,t=o.headers&&o.headers.get?o.headers.get("Content-Type"):void 0;let n;if("function"==typeof WebAssembly.compileStreaming&&"application/wasm"===t)n=await WebAssembly.compileStreaming(o);else{Me&&"application/wasm"!==t&&v('WebAssembly resource does not have the expected content type "application/wasm", so falling back to slower ArrayBuffer instantiation.');const e=await o.arrayBuffer();ke.diagnosticTracing&&b("instantiate_wasm_module buffered"),n=Se?await Promise.resolve(new WebAssembly.Module(e)):await WebAssembly.compile(e)}e.pendingDownloadInternal=null,e.pendingDownload=null,e.buffer=null,e.moduleExports=null,ke.wasmCompilePromise.promise_control.resolve(n)}catch(e){ke.wasmCompilePromise.promise_control.reject(e)}})(),setTimeout(async()=>{try{D(),await oe()}catch(e){Xe(1,e)}},0);const t=await Promise.all(o);return await fo(t),await Pe.dotnetReady.promise,await he(null===(e=ke.config.resources)||void 0===e?void 0:e.modulesAfterRuntimeReady),await be("onRuntimeReady",[Fe.api]),Oe}()}function uo(){const e=Y("js-module-runtime"),o=Y("js-module-native");if(no&&ro)return[no,ro,so];"object"==typeof e.moduleExports?no=e.moduleExports:(ke.diagnosticTracing&&b(`Attempting to import '${e.resolvedUrl}' for ${e.name}`),no=import(/*! webpackIgnore: true */e.resolvedUrl)),"object"==typeof o.moduleExports?ro=o.moduleExports:(ke.diagnosticTracing&&b(`Attempting to import '${o.resolvedUrl}' for ${o.name}`),ro=import(/*! webpackIgnore: true */o.resolvedUrl));const t=X("js-module-diagnostics");return t&&("object"==typeof t.moduleExports?so=t.moduleExports:(ke.diagnosticTracing&&b(`Attempting to import '${t.resolvedUrl}' for ${t.name}`),so=import(/*! webpackIgnore: true */t.resolvedUrl))),[no,ro,so]}async function fo(e){const{initializeExports:o,initializeReplacements:t,configureRuntimeStartup:n,configureEmscriptenStartup:r,configureWorkerStartup:s,setRuntimeGlobals:i,passEmscriptenInternals:a}=e[0],{default:l}=e[1],c=e[2];i(Fe),o(Fe),c&&c.setRuntimeGlobals(Fe),await n(ze),ke.runtimeModuleLoaded.promise_control.resolve(),l(()=>(Object.assign(ze,{__dotnet_runtime:{initializeReplacements:t,configureEmscriptenStartup:r,configureWorkerStartup:s,passEmscriptenInternals:a}}),ze)).catch(e=>{if(e.message&&e.message.toLowerCase().includes("out of memory"))throw new Error(".NET runtime has failed to start, because too much memory was requested. Please decrease the memory by adjusting EmccMaximumHeapSize.");throw e})}Ce&&async function(){(function(){const e=new MessageChannel,o=e.port1,t=e.port2;o.addEventListener("message",e=>{!function(e){const o=JSON.parse(e.config),t=JSON.parse(e.monoThreadInfo);ze.config=o,ze.wasmModule=e.wasmModule,ze.wasmMemory=e.wasmMemory,ze.handlers=e.handlers,io?ke.diagnosticTracing&&b("mono config already received"):(ye(ke.config,o),Pe.monoThreadInfo=t,Ae(),ke.diagnosticTracing&&b("mono config received"),io=!0,ke.afterConfigLoaded.promise_control.resolve(ke.config),Me&&o.forwardConsole&&void 0!==globalThis.WebSocket&&ke.setup_proxy_console("worker-idle",console,globalThis.location.origin))}(e.data),o.close(),t.close()},{once:!0}),o.start(),self.postMessage({[a]:{monoCmd:"preload",port:t}},[t])})(),await ke.afterConfigLoaded.promise,function(){const e=ke.config;e.assets||We(!1,"config.assets must be defined");for(const o of e.assets)K(o),q[o.behavior]&&N.push(o)}();const e=uo(),o=await Promise.all(e);return globalThis.name="em-pthread",await fo(o),ke.config.exitOnUnhandledError&&He(),Ge(),Me&&ke.config.forwardConsole&&void 0!==globalThis.WebSocket&&x("main",globalThis.console,globalThis.location.origin),await S(ze),await oe(),self.dispatchEvent(new MessageEvent("message",{data:{cmd:1,handlers:ze.handlers,wasmMemory:ze.wasmMemory,wasmModule:ze.wasmModule}})),ze}().catch(e=>Xe(1,e));const mo=new class{withModuleConfig(e){try{return ve(ze,e),this}catch(e){throw Xe(1,e),e}}withInterpreterPgo(e,o){try{return ye(Ne,{interpreterPgo:e,interpreterPgoSaveDelay:o}),Ne.runtimeOptions?Ne.runtimeOptions.push("--interp-pgo-recording"):Ne.runtimeOptions=["--interp-pgo-recording"],this}catch(e){throw Xe(1,e),e}}withConfig(e){try{return ye(Ne,e),this}catch(e){throw Xe(1,e),e}}withConfigSrc(e){return this}withVirtualWorkingDirectory(e){try{return e&&"string"==typeof e||We(!1,"must be directory path"),ye(Ne,{virtualWorkingDirectory:e}),this}catch(e){throw Xe(1,e),e}}withEnvironmentVariable(e,o){try{const t={};return t[e]=o,ye(Ne,{environmentVariables:t}),this}catch(e){throw Xe(1,e),e}}withEnvironmentVariables(e){try{return e&&"object"==typeof e||We(!1,"must be dictionary object"),ye(Ne,{environmentVariables:e}),this}catch(e){throw Xe(1,e),e}}withDiagnosticTracing(e){try{return"boolean"!=typeof e&&We(!1,"must be boolean"),ye(Ne,{diagnosticTracing:e}),this}catch(e){throw Xe(1,e),e}}withDebugging(e){try{return null!=e&&"number"==typeof e||We(!1,"must be number"),ye(Ne,{debugLevel:e}),this}catch(e){throw Xe(1,e),e}}withApplicationArguments(...e){try{return e&&Array.isArray(e)||We(!1,"must be array of strings"),ye(Ne,{applicationArguments:e}),this}catch(e){throw Xe(1,e),e}}withRuntimeOptions(e){try{return e&&Array.isArray(e)||We(!1,"must be array of strings"),Ne.runtimeOptions?Ne.runtimeOptions.push(...e):Ne.runtimeOptions=e,this}catch(e){throw Xe(1,e),e}}withMainAssembly(e){try{return ye(Ne,{mainAssemblyName:e}),this}catch(e){throw Xe(1,e),e}}withApplicationArgumentsFromQuery(){try{if(!globalThis.window)throw new Error("Missing window to the query parameters from");if(void 0===globalThis.URLSearchParams)throw new Error("URLSearchParams is supported");const e=new URLSearchParams(globalThis.window.location.search).getAll("arg");return this.withApplicationArguments(...e)}catch(e){throw Xe(1,e),e}}withApplicationEnvironment(e){try{return ye(Ne,{applicationEnvironment:e}),this}catch(e){throw Xe(1,e),e}}withApplicationCulture(e){try{return ye(Ne,{applicationCulture:e}),this}catch(e){throw Xe(1,e),e}}withResourceLoader(e){try{return ke.loadBootResource=e,this}catch(e){throw Xe(1,e),e}}async download(){try{await async function(){lo(ze),await Te(ze),ne(),D(),oe(),await ke.allDownloadsFinished.promise}()}catch(e){throw Xe(1,e),e}}async create(){try{return this.instance||(this.instance=await async function(){return await co(ze),Fe.api}()),this.instance}catch(e){throw Xe(1,e),e}}run(){return this.runMainAndExit()}async runMainAndExit(){try{return ze.config||We(!1,"Null moduleConfig.config"),this.instance||await this.create(),this.instance.runMainAndExit()}catch(e){throw Xe(1,e),e}}async runMain(){try{return ze.config||We(!1,"Null moduleConfig.config"),this.instance||await this.create(),this.instance.runMain()}catch(e){throw Xe(1,e),e}}},go=Xe,po=co;Se||"function"==typeof globalThis.URL||We(!1,"This browser/engine doesn't support URL API. Please use a modern version."),"function"!=typeof globalThis.BigInt64Array&&We(!1,"This browser/engine doesn't support BigInt64Array API. Please use a modern version. See also https://learn.microsoft.com/aspnet/core/blazor/supported-platforms"),globalThis.performance&&"function"==typeof globalThis.performance.now||We(!1,"This browser/engine doesn't support performance.now. Please use a modern version."),Se||globalThis.crypto&&"object"==typeof globalThis.crypto.subtle||We(!1,"This engine doesn't support crypto.subtle. Please use a modern version."),Se||globalThis.crypto&&"function"==typeof globalThis.crypto.getRandomValues||We(!1,"This engine doesn't support crypto.getRandomValues. Please use a modern version."),Ee&&"function"!=typeof process.exit&&We(!1,"This engine doesn't support process.exit. Please use a modern version."),mo.withConfig(/*json-start*/{
  "mainAssemblyName": "AllMultiplayerGames.WebAssembly",
  "resources": {
    "hash": "sha256-2QggNCvycnPy3zn50gy45WKsa08gnyNdxYfjwgDz7VA=",
    "jsModuleNative": [
      {
        "name": "dotnet.native.gyn70opcq7.js"
      }
    ],
    "jsModuleRuntime": [
      {
        "name": "dotnet.runtime.uyfhwbfd13.js"
      }
    ],
    "wasmNative": [
      {
        "name": "dotnet.native.mjledzavap.wasm",
        "hash": "sha256-kl3KCioIefd3enHfxtrrGZHcFqHrgSFx2cuFa/M2WW0=",
        "cache": "force-cache"
      }
    ],
    "icu": [
      {
        "virtualPath": "icudt_CJK.dat",
        "name": "icudt_CJK.5lgyv9xn0b.dat",
        "hash": "sha256-eZuX0pntrUwNrAmFCMwpxJjFA3/Myi/rW2x9mEZ+Mbg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "icudt_EFIGS.dat",
        "name": "icudt_EFIGS.xyuimhy3ww.dat",
        "hash": "sha256-SQcxb+bdx2UXUCU9tFdOWCr4Ctk64xghCnr0JGLWWKQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "icudt_no_CJK.dat",
        "name": "icudt_no_CJK.h0en30vv0c.dat",
        "hash": "sha256-T8YllylpxyWp9Aq4AiF+BMAxKXqYyzWB9RA5RqY19vs=",
        "cache": "force-cache"
      }
    ],
    "coreAssembly": [
      {
        "payloadSize": 45136,
        "virtualPath": "System.Runtime.InteropServices.JavaScript.wasm",
        "name": "System.Runtime.InteropServices.JavaScript.vfjk7aherr.wasm",
        "hash": "sha256-a/7qJOWn20tCSpNZEEDDWgNNm1d+r6jed44yP9qZsfA=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 2418768,
        "virtualPath": "System.Private.CoreLib.wasm",
        "name": "System.Private.CoreLib.f3wffdl2j0.wasm",
        "hash": "sha256-O+MR57Xp25w/6oDvXR1uDZpM4u0DD3pfhJG/3iRZcnA=",
        "cache": "force-cache"
      }
    ],
    "assembly": [
      {
        "payloadSize": 303696,
        "virtualPath": "Microsoft.AspNetCore.Components.wasm",
        "name": "Microsoft.AspNetCore.Components.nsxs4ucp0x.wasm",
        "hash": "sha256-6akIC5MafRfxTV6YLfLsG6UHGYewrQhGTgmxYaBhkuM=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 40528,
        "virtualPath": "Microsoft.AspNetCore.Components.Forms.wasm",
        "name": "Microsoft.AspNetCore.Components.Forms.km2w6zwsit.wasm",
        "hash": "sha256-tPgTwC09iVm3R09aWemmGhDK6Kxm18m6FThH48Ov/go=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 78928,
        "virtualPath": "Microsoft.AspNetCore.Components.Web.wasm",
        "name": "Microsoft.AspNetCore.Components.Web.yopaczmlzm.wasm",
        "hash": "sha256-kjjB6s7sMaMd3K2jotKCf8ZddfPQ2tmcKQ5XVa0AeOA=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 145488,
        "virtualPath": "Microsoft.AspNetCore.Components.WebAssembly.wasm",
        "name": "Microsoft.AspNetCore.Components.WebAssembly.wpvzyvvzfd.wasm",
        "hash": "sha256-VHljedrLTABbtK8I5oUuPt3UPYufWKnfZKeGBjMTg1o=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 10832,
        "virtualPath": "Microsoft.AspNetCore.Connections.Abstractions.wasm",
        "name": "Microsoft.AspNetCore.Connections.Abstractions.b95a4dq1gx.wasm",
        "hash": "sha256-4Q5+VVB0TX2lncdq5lAQZj65cesL0i4/SyepD6hFMK4=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 106576,
        "virtualPath": "Microsoft.AspNetCore.Http.Connections.Client.wasm",
        "name": "Microsoft.AspNetCore.Http.Connections.Client.nrm0xkpcl8.wasm",
        "hash": "sha256-vWvU5M4BZG/YGUCQ9WXEywMZOFO823UYCtKXSVHHlyE=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 13392,
        "virtualPath": "Microsoft.AspNetCore.Http.Connections.Common.wasm",
        "name": "Microsoft.AspNetCore.Http.Connections.Common.dihosqbmbm.wasm",
        "hash": "sha256-peJV1egeipgLfdPn8pcITEfKuh/LKwAMlIspr8PS7g0=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 8784,
        "virtualPath": "Microsoft.AspNetCore.SignalR.Client.wasm",
        "name": "Microsoft.AspNetCore.SignalR.Client.mntmu0auts.wasm",
        "hash": "sha256-oj0QswFYH25JJr/1uums4YFWBUR+2UvlAihaVoF6IV4=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 162896,
        "virtualPath": "Microsoft.AspNetCore.SignalR.Client.Core.wasm",
        "name": "Microsoft.AspNetCore.SignalR.Client.Core.03v2ux3hv6.wasm",
        "hash": "sha256-3HuYtMei7jF+y2gmiFh8D3mZp5tBRZkBvTzTw+NxgpY=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 23632,
        "virtualPath": "Microsoft.AspNetCore.SignalR.Common.wasm",
        "name": "Microsoft.AspNetCore.SignalR.Common.pnoo9ulm9m.wasm",
        "hash": "sha256-K7xRu3xKBUbvFo+eTrr7tm+rasxeiIoGLAQ9eDLjvXk=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 22608,
        "virtualPath": "Microsoft.AspNetCore.SignalR.Protocols.Json.wasm",
        "name": "Microsoft.AspNetCore.SignalR.Protocols.Json.2j0mmyqj7y.wasm",
        "hash": "sha256-0lWt04gmCvudf/TeLjTgXIy3jdhJsjVw1E0dQqBLTs0=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 13392,
        "virtualPath": "Microsoft.Extensions.Configuration.wasm",
        "name": "Microsoft.Extensions.Configuration.634d3566hd.wasm",
        "hash": "sha256-DrNvWxHYAJK7IjBFKEpA5NH3PvDjVmxlOnohqs2VX/U=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 9296,
        "virtualPath": "Microsoft.Extensions.Configuration.Binder.wasm",
        "name": "Microsoft.Extensions.Configuration.Binder.klck754k0k.wasm",
        "hash": "sha256-yFcg/rcJQxgB8FnsMez8GdKLXku9MQRRBrVPE5HHVxE=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 12880,
        "virtualPath": "Microsoft.Extensions.Configuration.EnvironmentVariables.wasm",
        "name": "Microsoft.Extensions.Configuration.EnvironmentVariables.vaqacjgd1g.wasm",
        "hash": "sha256-WWSvU1JDlu+bkUC9QASXcgI6FBxn6nqhoi+goYlADAM=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 13904,
        "virtualPath": "Microsoft.Extensions.Configuration.FileExtensions.wasm",
        "name": "Microsoft.Extensions.Configuration.FileExtensions.udpxheam72.wasm",
        "hash": "sha256-PjhAwZ/AlFDZmbmtkRTyJjh956hHoJ5fi+q7rY1Me3Y=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 9808,
        "virtualPath": "Microsoft.Extensions.Configuration.Json.wasm",
        "name": "Microsoft.Extensions.Configuration.Json.q81lkglnox.wasm",
        "hash": "sha256-it2ZhBMdA01nWq87yJoqpIh2zzD4VlW5qVKw+RKqPzw=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 54864,
        "virtualPath": "Microsoft.Extensions.DependencyInjection.wasm",
        "name": "Microsoft.Extensions.DependencyInjection.htc74pxz47.wasm",
        "hash": "sha256-W2vGt8MB6QHx7wCd5kqpdaOU1h7mXWDjCA2f6axHQLY=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 14928,
        "virtualPath": "Microsoft.Extensions.Diagnostics.wasm",
        "name": "Microsoft.Extensions.Diagnostics.es1aeztafo.wasm",
        "hash": "sha256-jrG0mdpst0h6GpNSYnKL6CGIpoqljOAai75Nx5vueow=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 10320,
        "virtualPath": "Microsoft.Extensions.Features.wasm",
        "name": "Microsoft.Extensions.Features.ud1s3641rx.wasm",
        "hash": "sha256-/s4l48/hJ8WLhxvN2wKGGMOIeu4O1S8T0m9Jnlo4rgk=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 28752,
        "virtualPath": "Microsoft.Extensions.FileProviders.Physical.wasm",
        "name": "Microsoft.Extensions.FileProviders.Physical.iq9yq1niv8.wasm",
        "hash": "sha256-ylMXmrnrKLxFlBuXb6gnc4dOeD8Ct/bZJDkNboqlnRo=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 29776,
        "virtualPath": "Microsoft.Extensions.FileSystemGlobbing.wasm",
        "name": "Microsoft.Extensions.FileSystemGlobbing.0rgg1f65au.wasm",
        "hash": "sha256-NGoHKZvbKw6ZF9f45tP6+O+Nfvab+kdHAPzoU8Ed4jc=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 5712,
        "virtualPath": "Microsoft.Extensions.Localization.Abstractions.wasm",
        "name": "Microsoft.Extensions.Localization.Abstractions.b2zmeqgqub.wasm",
        "hash": "sha256-/a5GuIgvHJ3nPQg/M+CY+r95mEIuE76UqesU3pTN7TE=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 19536,
        "virtualPath": "Microsoft.Extensions.Logging.wasm",
        "name": "Microsoft.Extensions.Logging.xpk1ev67m1.wasm",
        "hash": "sha256-2xbW12ofAh3V+8qjEjO/gQTbvTKG7/woocum9yc1/xU=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 8272,
        "virtualPath": "Microsoft.Extensions.Validation.wasm",
        "name": "Microsoft.Extensions.Validation.ldu2yz4khd.wasm",
        "hash": "sha256-SRTMKPr3Z5FePw1q6Wp9LtpCKZ5t4kA7iSPq1TUBwJg=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 48720,
        "virtualPath": "Microsoft.JSInterop.wasm",
        "name": "Microsoft.JSInterop.sdsvsefh07.wasm",
        "hash": "sha256-cGW5r3F1zkIt4K2WVWB+5atFQDy8wFatSGE8zocRdmo=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 11856,
        "virtualPath": "Microsoft.JSInterop.WebAssembly.wasm",
        "name": "Microsoft.JSInterop.WebAssembly.kthmj8ue8z.wasm",
        "hash": "sha256-uHbb5b7vnE0GwS6Qws3ipDRp2E0UWNZ9G2JJrz8Au4U=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 56912,
        "virtualPath": "A21DiceGame.wasm",
        "name": "A21DiceGame.22tzokhssc.wasm",
        "hash": "sha256-JoovBG6VqcbQjAGjp+yDP+IE8JB0Ig6/uWxbRRi8WXU=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 101968,
        "virtualPath": "A8RoundRummy.wasm",
        "name": "A8RoundRummy.cjpfynl69q.wasm",
        "hash": "sha256-CB3qJOTwup0xaSxGIzah/Z/ZFULURyerMHJ493QTVlc=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 449104,
        "virtualPath": "Aggravation.wasm",
        "name": "Aggravation.ikexbdgstm.wasm",
        "hash": "sha256-/vjOjGg09kGQSDwBMRoIBg5SzdZ8XfDrWM0DB649t7s=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 151632,
        "virtualPath": "Backgammon.wasm",
        "name": "Backgammon.2dig274uay.wasm",
        "hash": "sha256-9j6T1sayKY1KeI7YAHpSbqTJQE7PfIGs9RDqMWB2tbs=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 592464,
        "virtualPath": "BasicBlazorLibrary.wasm",
        "name": "BasicBlazorLibrary.59epptx7hs.wasm",
        "hash": "sha256-aTHdECEUQzs4J0cugLkg9WNIb7g6bPjIiRTe3m8CPgo=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 1481296,
        "virtualPath": "BasicGameFrameworkLibrary.wasm",
        "name": "BasicGameFrameworkLibrary.jeosn0ejyv.wasm",
        "hash": "sha256-i4EhxxEVP4UUVIwC+zwagOn+6stp5Px7MXLbai27UEg=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 88656,
        "virtualPath": "Battleship.wasm",
        "name": "Battleship.udkjjrwxsu.wasm",
        "hash": "sha256-8mxQWHNwYo9STWUbItyoKDCLVtKU8s6Zd8pmTHashjo=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 75344,
        "virtualPath": "BattleshipLite.wasm",
        "name": "BattleshipLite.z7y77439je.wasm",
        "hash": "sha256-/w/Mz0f4tdxWW7hMH1u+cF4TrbL+cI6oAsmNjRj+osU=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 63568,
        "virtualPath": "Bingo.wasm",
        "name": "Bingo.hw83q6uk8h.wasm",
        "hash": "sha256-L57mNpg4Qw2SpPEHni1OziU/83T9Ge7qnphNBxOkoJs=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 122960,
        "virtualPath": "BladesOfSteel.wasm",
        "name": "BladesOfSteel.2nwvdnrybl.wasm",
        "hash": "sha256-AjANdd/6BEv4QLi7QZ4sldudvPrcsK2QDJoaNhRvovg=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 102480,
        "virtualPath": "BowlingDiceGame.wasm",
        "name": "BowlingDiceGame.v9yyw50dh3.wasm",
        "hash": "sha256-/Ynn0jnFxheVnz1BNkZsvqgn6Ae1xj2sGREZTXXMakw=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 79440,
        "virtualPath": "CaliforniaJack.wasm",
        "name": "CaliforniaJack.k4i24j1u2i.wasm",
        "hash": "sha256-vPeYLwEuAQ6qyPCBR7WA0Z2KlkbkPxwl0aCAN6LvNuQ=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 749136,
        "virtualPath": "Candyland.wasm",
        "name": "Candyland.3kx4omoyar.wasm",
        "hash": "sha256-47IIz1fL/fhEE31FFB1WKrNIw9yMtmZAt6C5x1gpkVQ=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 78416,
        "virtualPath": "Checkers.wasm",
        "name": "Checkers.dw1xur2c28.wasm",
        "hash": "sha256-Iy49Vi+luVfC0J9745ZUqSCEG+HXQbvJNkLGEQBQ5N0=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 106576,
        "virtualPath": "Chess.wasm",
        "name": "Chess.8j5salw91t.wasm",
        "hash": "sha256-/PZEAiAfPO/+jylg3WWMpqx9EvkJcvUg9vRPasvoQ/g=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 113744,
        "virtualPath": "Chinazo.wasm",
        "name": "Chinazo.25v4k2ghm2.wasm",
        "hash": "sha256-ppKaDdfNUXIAeukHX8DRG/zBiavXWA+79UCJo31dGdw=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 220752,
        "virtualPath": "ChineseCheckers.wasm",
        "name": "ChineseCheckers.1zjoydfema.wasm",
        "hash": "sha256-HaFanUIIkAR3HFvMCYbeQlph8zg3UGb+KLVfJrtMNlE=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 1652816,
        "virtualPath": "ClueBoardGame.wasm",
        "name": "ClueBoardGame.7lyinryfm3.wasm",
        "hash": "sha256-myJy96G2bEdyxHenRvuDclmVb+wYQswVRhy2ouSrnj0=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 1009744,
        "virtualPath": "ClueCardGame.wasm",
        "name": "ClueCardGame.llyrntj7px.wasm",
        "hash": "sha256-6eJ0joYg15IuCYqVRxcUJpuRsOrc2IQ8XT68Bhrmaks=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 469584,
        "virtualPath": "CommonBasicLibraries.wasm",
        "name": "CommonBasicLibraries.8goq9b2qqn.wasm",
        "hash": "sha256-uKxaFwbSjJTWWhZYq742RmVHTbNiudwqjUOFOU7DMs0=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 74320,
        "virtualPath": "Concentration.wasm",
        "name": "Concentration.j9kljyu933.wasm",
        "hash": "sha256-1zRD22l2shwJlucvuKMXnyHKq/BYY/Ctsh8W+k06Z+s=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 59472,
        "virtualPath": "ConnectFour.wasm",
        "name": "ConnectFour.kjwlvg31cd.wasm",
        "hash": "sha256-ADmgKJu/c7LtoMs2Q8ej6pmSdjorbd6PCA0vrZk/afI=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 76368,
        "virtualPath": "ConnectTheDots.wasm",
        "name": "ConnectTheDots.c3m63i8tqz.wasm",
        "hash": "sha256-qB9D6Z26nBPleYp3ju74itRosvRu22KQrwIem4AOZRg=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 70224,
        "virtualPath": "Countdown.wasm",
        "name": "Countdown.ourodoximp.wasm",
        "hash": "sha256-AEBGGdygSSS7OpxfsEaiQTXHg0b8KlZq1TFIUiXUY7w=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 109136,
        "virtualPath": "CousinRummy.wasm",
        "name": "CousinRummy.wf6wpix8of.wasm",
        "hash": "sha256-ZMbRZ+cHbx/74fxyI7v7HAfv61UkvQwwlJb/JCzkH/w=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 75344,
        "virtualPath": "CoveredUp.wasm",
        "name": "CoveredUp.7moy3ywwq3.wasm",
        "hash": "sha256-4aPQvJljCqqbgpaFmuzajXaIIyYPP6wPidMDLV+K3xk=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 74320,
        "virtualPath": "CrazyEights.wasm",
        "name": "CrazyEights.3hcg5cxfle.wasm",
        "hash": "sha256-J0h/y/DJNukxBS5FN18XWAVRJSajfuM37fMSkhOadEI=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 113744,
        "virtualPath": "Cribbage.wasm",
        "name": "Cribbage.574bhjt3tr.wasm",
        "hash": "sha256-AVeuGVOGRbw5k/yirnxFa5WmqYF96hW8TZzPwz7togw=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 52304,
        "virtualPath": "DeadDie96.wasm",
        "name": "DeadDie96.1fweab579b.wasm",
        "hash": "sha256-nQGk3KpPEesgOjvaEqOGN0C9QsUtfCzlwEhDgjmd5bA=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 298064,
        "virtualPath": "DealCardGame.wasm",
        "name": "DealCardGame.sjgxbj93iz.wasm",
        "hash": "sha256-CDmcMm9RUXxuIn6e0q1K1DKxmLbjH4nEeJWQIta86vc=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 66128,
        "virtualPath": "DiceDominos.wasm",
        "name": "DiceDominos.5bcc2w2w8r.wasm",
        "hash": "sha256-UasKjtABKpUFaTWITVopC1ZpphsVYC/he8Ey1+UoTY8=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 76880,
        "virtualPath": "DominosRegular.wasm",
        "name": "DominosRegular.duevp6u6jv.wasm",
        "hash": "sha256-G7KQMuylnQn/+o7yebgqDPjbQqYohHFL2VYyruUsAK0=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 90192,
        "virtualPath": "DummyRummy.wasm",
        "name": "DummyRummy.gmtw9stm6c.wasm",
        "hash": "sha256-CLmTT1ZMV7v8k1kvEaqg2TRIwHdlUJr7/GtRvmaHWu4=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 102992,
        "virtualPath": "DutchBlitz.wasm",
        "name": "DutchBlitz.jx6ciu0r6w.wasm",
        "hash": "sha256-F/g79O3Y/+cbCfm8p9eUTUcmQoo7yL3idktHQPBp/0c=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 92752,
        "virtualPath": "FillOrBust.wasm",
        "name": "FillOrBust.ts0w86ktbm.wasm",
        "hash": "sha256-DSxBlZ2EEA1n/PKevvFdV2dVfvof7VqgIFoBloL1z04=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 117328,
        "virtualPath": "FiveCrowns.wasm",
        "name": "FiveCrowns.vxhmxr9pns.wasm",
        "hash": "sha256-rR4AdA3Oc4SjEntlU5fFKUDRqpbHaq3oHIm3Da1Dlyc=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 128080,
        "virtualPath": "Flinch.wasm",
        "name": "Flinch.yyknmb2a9z.wasm",
        "hash": "sha256-6kuLCVgcLV5X6ouK3OS8O8KAGeZ9/2fmgkKMEi/YiBE=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 446544,
        "virtualPath": "Fluxx.wasm",
        "name": "Fluxx.719sxk0q1b.wasm",
        "hash": "sha256-RdIpIFBsLRq1YVGnY5W+byfxp1r5GwBGt4jhtprLDdc=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 96848,
        "virtualPath": "FourSuitRummy.wasm",
        "name": "FourSuitRummy.djoapk6yfu.wasm",
        "hash": "sha256-uQOTO6G5wUpEghFevxpoLSURbUDmhrHscBh1vmqJ4ME=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 111184,
        "virtualPath": "GalaxyCardGame.wasm",
        "name": "GalaxyCardGame.g30jse4bov.wasm",
        "hash": "sha256-PButD00q9YwmaEDXVC1M3aZpFRPxqqR/rVW6o2W6KiA=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 56912,
        "virtualPath": "GameLoaderBlazorLibrary.wasm",
        "name": "GameLoaderBlazorLibrary.mdhwc3lkr7.wasm",
        "hash": "sha256-+udKe8PKT+JA90mQVJQVJvU4EMYETw0mHwBsLIiw/H0=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 7248,
        "virtualPath": "GamePackageContractsLibrary.wasm",
        "name": "GamePackageContractsLibrary.mruifzqzd0.wasm",
        "hash": "sha256-QqfZnvTBmtVQhJy+SyOTr4hGnVSZ3m/supmqiKN+gPU=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 67152,
        "virtualPath": "GamePackageSignalRClasses.wasm",
        "name": "GamePackageSignalRClasses.myj2si5cnd.wasm",
        "hash": "sha256-jkXA0/HpjZ8UwT7iwqKCoQo1ncCW4qAYfW4cq2IhQZM=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 74320,
        "virtualPath": "GermanWhist.wasm",
        "name": "GermanWhist.mt4nr23ehz.wasm",
        "hash": "sha256-KmvLNtjGBWUpWe5fsgcCes62vp37pO+6hL3WPinWB08=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 80976,
        "virtualPath": "GoFish.wasm",
        "name": "GoFish.ikjxajsvud.wasm",
        "hash": "sha256-Utdjdj6bFA0oC6kEGg/BWIcgv7PO+ibsPKmgYAyC5bA=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 99408,
        "virtualPath": "GolfCardGame.wasm",
        "name": "GolfCardGame.guc4aq7c9h.wasm",
        "hash": "sha256-CHyZGleciUYL2vLaKVc8ft753XnZAV9eHO3Rt3BnFaY=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 98384,
        "virtualPath": "Hearts.wasm",
        "name": "Hearts.zm2mcm79ha.wasm",
        "hash": "sha256-2wrQ7ooAhUNjNV1mlbQfOnugUxzhH3cZzADzoMXFBoM=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 109136,
        "virtualPath": "HitTheDeck.wasm",
        "name": "HitTheDeck.bu9095j77m.wasm",
        "hash": "sha256-LQFDCZmwwtWYsokauhjzCuq+2EU2cHBPit/nSjevL0g=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 88656,
        "virtualPath": "HorseshoeCardGame.wasm",
        "name": "HorseshoeCardGame.4j5sixt1b8.wasm",
        "hash": "sha256-AJGeVU4fwyNgkvlM/0W6YFkrCojaAn5s0VurAOBJEik=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 108112,
        "virtualPath": "HuseHearts.wasm",
        "name": "HuseHearts.ewy5l0pckp.wasm",
        "hash": "sha256-EvvlU1fK32OUrVh0Nx+9Ub1qB+FdVOkGvbMWoaLgk1o=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 58448,
        "virtualPath": "ItalianDominos.wasm",
        "name": "ItalianDominos.36a2mcl8dt.wasm",
        "hash": "sha256-BYqb3XcD1ZOJKtt7PGL4156FyT2RrDvlzfErDXVzV30=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 51280,
        "virtualPath": "Kismet.wasm",
        "name": "Kismet.j6oa8o6oni.wasm",
        "hash": "sha256-62CTy53FvYlKkieVjK/fCTo1o8PE/ZomkQI5eutX/Sw=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 2000976,
        "virtualPath": "LifeBoardGame.wasm",
        "name": "LifeBoardGame.090dmahuib.wasm",
        "hash": "sha256-hBAhB6JyOU5ewRSgMfYr3ITkUgv07hNE117SbjWotaY=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 1026128,
        "virtualPath": "LifeCardGame.wasm",
        "name": "LifeCardGame.njc9azflm1.wasm",
        "hash": "sha256-w41SiI0XtMgg6W3Q3UkZwzhZ70JgDvLEB3UxuNJ2Tz8=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 65104,
        "virtualPath": "LottoDominos.wasm",
        "name": "LottoDominos.u4jhbv8xpx.wasm",
        "hash": "sha256-4v1js4DACL2YGhGOjbEpOE3IHfAj1/dNTv2GaeF17Is=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 61520,
        "virtualPath": "Mancala.wasm",
        "name": "Mancala.9nsbn38w9y.wasm",
        "hash": "sha256-xUgXmGjiRmV7Cu9PAf0FqEZ/1u22DZqeoPYc3yeqd1s=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 17488,
        "virtualPath": "MessengingHelpers.wasm",
        "name": "MessengingHelpers.6sz1a9au9g.wasm",
        "hash": "sha256-ZpnsuDYgWDEFBuk8HbL/PWJRt8SLYt9Pf0y5W3f2Eko=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 169040,
        "virtualPath": "MilkRun.wasm",
        "name": "MilkRun.wae155vr1g.wasm",
        "hash": "sha256-qAe7BcT/1R9NzkWlnXUpZFBi7h2kBV1ht4iU/swQ95A=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 383568,
        "virtualPath": "Millebournes.wasm",
        "name": "Millebournes.lm2yu7jk9v.wasm",
        "hash": "sha256-MzTcVQfuWa7hyDbB/bPBL8wXUhBSdtrFjgkIS90qq/U=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 126032,
        "virtualPath": "MonasteryCardGame.wasm",
        "name": "MonasteryCardGame.9fbgph4u33.wasm",
        "hash": "sha256-KwXYXTKEKqqNUJ1NoEfR9DSrRdirq/wiaAy46Yr8uQg=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 331856,
        "virtualPath": "MonopolyCardGame.wasm",
        "name": "MonopolyCardGame.tcve8fhcww.wasm",
        "hash": "sha256-w7UdmPO9wXmvDVSGSYME3VS3KPH0V7HyON/H0et+jpA=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 223312,
        "virtualPath": "MonopolyDicedGame.wasm",
        "name": "MonopolyDicedGame.l3gtr9e948.wasm",
        "hash": "sha256-wdVPaNCGamQDh3tCPDpdNOGJ8qLnqXup259p2LJ9+jY=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 14928,
        "virtualPath": "MultiplayerGamesBlazorLoaderLibrary.wasm",
        "name": "MultiplayerGamesBlazorLoaderLibrary.20qqrfk4k1.wasm",
        "hash": "sha256-3iI7+ZOIH/Sb+7iuruqP6XVUUQdJvpHg5fz8VoeR30s=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 78928,
        "virtualPath": "OldMaid.wasm",
        "name": "OldMaid.tall32e24d.wasm",
        "hash": "sha256-6xX35z9FhpuYgnwi/00TrgQiMwWJ47Kvmy4CCRt+HVQ=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 88144,
        "virtualPath": "Opetong.wasm",
        "name": "Opetong.9d6rxvbe0n.wasm",
        "hash": "sha256-A9ob1zzKu+zRs48fpLO/OYTprj3+1fMxhgwuzOJ0nkA=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 75344,
        "virtualPath": "PassOutDiceGame.wasm",
        "name": "PassOutDiceGame.z5782xur0u.wasm",
        "hash": "sha256-uSMrLG/ix0TtEUL4BlBes18Mu2rpRzYA3fJf2m/KoW4=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 804944,
        "virtualPath": "Payday.wasm",
        "name": "Payday.enpykg0trj.wasm",
        "hash": "sha256-pjUIn5hAKpfscOGQigDtqxdVAHsoEy9OCyuNTWF5GxQ=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 116816,
        "virtualPath": "Phase10.wasm",
        "name": "Phase10.716xpf5uq0.wasm",
        "hash": "sha256-NT53vCxQa0uO5KWv+pfEBFc4yQiHCHacLNL9B0dqMGY=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 102992,
        "virtualPath": "PickelCardGame.wasm",
        "name": "PickelCardGame.zljw5ddfef.wasm",
        "hash": "sha256-ucs6zc1sa626oVS0OjwAzEqZpdfo5Mkal4RPqxqeQmg=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 114256,
        "virtualPath": "Pinochle2Player.wasm",
        "name": "Pinochle2Player.cjb9k072i2.wasm",
        "hash": "sha256-WNkYtkR1DADc+Mp0ANEVdJbMm292VqMpuJTdufpC+ag=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 85584,
        "virtualPath": "Racko.wasm",
        "name": "Racko.uizpdskoil.wasm",
        "hash": "sha256-Ft0yPJ/RD4Rcx0PUlhIERxZprrpRR4/kGkq9XCjCSD0=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 115280,
        "virtualPath": "RageCardGame.wasm",
        "name": "RageCardGame.2dhqzijq8v.wasm",
        "hash": "sha256-ZhXI27b5sAMI/cceAP64TnJRFvPoqYOqOJGc1ZQ6h9I=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 734800,
        "virtualPath": "Risk.wasm",
        "name": "Risk.345ozwtcbo.wasm",
        "hash": "sha256-HX3OBPT7yfPtrhlYAci0/nAVgiF8Ad2OR5gvIshmBcE=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 72784,
        "virtualPath": "RollEm.wasm",
        "name": "RollEm.6ovx8k60o9.wasm",
        "hash": "sha256-aql/SdOd9WK00Iis9uiKRgqffiMfQ2eCP64EDLm0nqA=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 189008,
        "virtualPath": "Rook.wasm",
        "name": "Rook.p6crh6igtg.wasm",
        "hash": "sha256-j+Bo6/4Mamu3yGqrtzeHlDcXM2nar/SfchS8kkeTgBc=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 78928,
        "virtualPath": "RoundsCardGame.wasm",
        "name": "RoundsCardGame.gv07e8vlhy.wasm",
        "hash": "sha256-1OGnDiCbFlXSoH0XHAbxWpxfZ5MnmMNjrakyoAeTR0Y=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 93776,
        "virtualPath": "Rummy500.wasm",
        "name": "Rummy500.u8nu9njyua.wasm",
        "hash": "sha256-0hmGmAwllf7VGbq17yW7uk/y9p/NdIUfz8xBwu7bSKA=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 123472,
        "virtualPath": "RummyDice.wasm",
        "name": "RummyDice.7qyf7kpnud.wasm",
        "hash": "sha256-j+S1bC2+W3xbIL7soooqZCyrph+CdgpK71JKL6v4EhU=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 111696,
        "virtualPath": "Savannah.wasm",
        "name": "Savannah.eigf2ngxza.wasm",
        "hash": "sha256-qsBaDEA64TSBw5NzukdzHXpDN9Ci6IxbHZ6JOra9qtY=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 78928,
        "virtualPath": "SequenceDice.wasm",
        "name": "SequenceDice.b54qy97thj.wasm",
        "hash": "sha256-f20Nve0snRw6/k7gMZ+N4UdeeQ6tE2rn7U0VjM/FMlg=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 57424,
        "virtualPath": "ShipCaptainCrew.wasm",
        "name": "ShipCaptainCrew.s365hgg4s9.wasm",
        "hash": "sha256-2GAE2OkuTH+rvAQwQrgyXjOJxuEhgWACX+svOZ/Ru5c=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 56912,
        "virtualPath": "SinisterSix.wasm",
        "name": "SinisterSix.acpfqs135r.wasm",
        "hash": "sha256-9rf1UGWQ4yWBgJlr8vqM85OU7REwbtOk+sQY/kAfCLs=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 100944,
        "virtualPath": "SixtySix2Player.wasm",
        "name": "SixtySix2Player.pqf4y67hen.wasm",
        "hash": "sha256-T+3fioMnLfynfCDe5uycP5GX4JYBj6bL4KDTxYwBi/M=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 113744,
        "virtualPath": "Skipbo.wasm",
        "name": "Skipbo.2s5sfydww4.wasm",
        "hash": "sha256-QhN6vFpus4QUcfvmrz+strco1/f8VRTqwbenvW/PqqY=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 110672,
        "virtualPath": "SkuckCardGame.wasm",
        "name": "SkuckCardGame.k2jyjc55ge.wasm",
        "hash": "sha256-DMhJWdedsdJ7M761dAHKGGHKAxZ1kmnTIUMWFgJiA30=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 95312,
        "virtualPath": "SnagCardGame.wasm",
        "name": "SnagCardGame.og85szla55.wasm",
        "hash": "sha256-6G1mtiJRZLn7xu3k4mBNJnbl1hAn8Hff/PmYuWoZ9D4=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 191056,
        "virtualPath": "SnakesAndLadders.wasm",
        "name": "SnakesAndLadders.uy1a9zbg6y.wasm",
        "hash": "sha256-du1ZC1aYpzZPJv3JJyyz92ReCrqP0McMxu5qrZMgSWE=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 680016,
        "virtualPath": "Sorry.wasm",
        "name": "Sorry.64iwziidjm.wasm",
        "hash": "sha256-SvFkGUW3t8meZ6X9TtK0KnBLa3ByzV8zJoENDGlCezI=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 118864,
        "virtualPath": "SorryCardGame.wasm",
        "name": "SorryCardGame.4ur6i0pgh8.wasm",
        "hash": "sha256-lEuwoQim2SaXXCVONhvqfhwgNwg8VnqSUSCOzVqVCYk=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 116304,
        "virtualPath": "SorryDicedGame.wasm",
        "name": "SorryDicedGame.cfuco8cbvy.wasm",
        "hash": "sha256-+CISRrR1ZMfQhNf2MdfjeH2w9a9zjWsr2/j2SbduhXI=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 95312,
        "virtualPath": "Spades2Player.wasm",
        "name": "Spades2Player.hnb78671tb.wasm",
        "hash": "sha256-vcZyFn2jlp4CXdevKIU1qSCmeV/9u3xXaPCaRHAMJJw=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 80976,
        "virtualPath": "Spades4Player.wasm",
        "name": "Spades4Player.0jtxfts79v.wasm",
        "hash": "sha256-RGm0XwMIIxuVqFWCd9vPbDNZmYgOsB2Cl6EfKk68W+8=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 72272,
        "virtualPath": "SvgHelper.Blazor.wasm",
        "name": "SvgHelper.Blazor.2ev1jpxdka.wasm",
        "hash": "sha256-Kpzoa5VcHkUNX/pD4TmvrYElPDdGcK9DR8rytR6UqBQ=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 171088,
        "virtualPath": "TeeItUp.wasm",
        "name": "TeeItUp.5a3g2r16p8.wasm",
        "hash": "sha256-Y22UdiWyVN3oo5tiuO0QYEnS57SGfJ6jdIQ+m+6u6fo=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 93776,
        "virtualPath": "ThinkTwice.wasm",
        "name": "ThinkTwice.rmlpo9bsnq.wasm",
        "hash": "sha256-PTrTeONWxNqEBTMCNGhRuEwLbYYsjQS2p51aSiIGJ8E=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 320592,
        "virtualPath": "ThreeLetterFun.wasm",
        "name": "ThreeLetterFun.nrbsgu3cnl.wasm",
        "hash": "sha256-k6KQnDw5XyFFqMO6URD5ICq3il/cP8D1A2LdHnAkuhk=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 53840,
        "virtualPath": "TicTacToe.wasm",
        "name": "TicTacToe.i0ee1i2uya.wasm",
        "hash": "sha256-jvi4/pNIQdHbf5jDAQXJmdbWozJ/smxPlLl0fO8FT+c=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 127056,
        "virtualPath": "TileRummy.wasm",
        "name": "TileRummy.49o7o06bqy.wasm",
        "hash": "sha256-iK41sXhCWekAB5qutgNPJk/cXsu+LvbVgoAReuh9ayw=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 2591312,
        "virtualPath": "Trouble.wasm",
        "name": "Trouble.hymyzepvtx.wasm",
        "hash": "sha256-ufNx1J15OxwbhkIhP3pdy2zXRnllM/HjgNIjb4wr9PA=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 104528,
        "virtualPath": "Uno.wasm",
        "name": "Uno.b3pgb3mtfz.wasm",
        "hash": "sha256-B1rZQQHbppVRgdo5o6mmI0MSVeybYOkAI1Roy1HBVfU=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 142416,
        "virtualPath": "Xactika.wasm",
        "name": "Xactika.tgs529jxkn.wasm",
        "hash": "sha256-o2qUwvM7KZXtPVxj60Ke1RRHW2MrZacsSkRavji0dbo=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 144976,
        "virtualPath": "YaBlewIt.wasm",
        "name": "YaBlewIt.1wtifef8f0.wasm",
        "hash": "sha256-L0E6Cgy/4AiKHn8l1H9GjS6m22PodEm9zD4kV+eC4O4=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 54864,
        "virtualPath": "YachtRace.wasm",
        "name": "YachtRace.h41147id4y.wasm",
        "hash": "sha256-8RuWQs1WHj5Zh+eDNVHGiD8yCYo43SZ9NmonnTn2nr4=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 46160,
        "virtualPath": "Yahtzee.wasm",
        "name": "Yahtzee.rgvgmbsj76.wasm",
        "hash": "sha256-tZr35w6eMbWjA4rY5F/OD3vdYr+TMZ4zgKCxzFkngpU=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 106064,
        "virtualPath": "YahtzeeHandsDown.wasm",
        "name": "YahtzeeHandsDown.mudgsjzgdq.wasm",
        "hash": "sha256-HqLrjh29Mcky1I/Szmf8dqnB9Uyl1HDcbNc7WjYQJC4=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 6736,
        "virtualPath": "Microsoft.Extensions.Configuration.Abstractions.wasm",
        "name": "Microsoft.Extensions.Configuration.Abstractions.umikcf8ifq.wasm",
        "hash": "sha256-VsMRgeDr1y1LfvTMJ699qcqZbCLOJGtoH0NG5wb6JPg=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 27216,
        "virtualPath": "Microsoft.Extensions.DependencyInjection.Abstractions.wasm",
        "name": "Microsoft.Extensions.DependencyInjection.Abstractions.afcykxuiuh.wasm",
        "hash": "sha256-ZovOnjuApMwLkj4VMHhuelKdFh5zVysWlEV7jqRcEOM=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 8272,
        "virtualPath": "Microsoft.Extensions.Diagnostics.Abstractions.wasm",
        "name": "Microsoft.Extensions.Diagnostics.Abstractions.qz20gv1zfo.wasm",
        "hash": "sha256-2jQ7jiew9q+5Ke8i4fl+RClN1kk9u0ejlFTCHyIWg4Q=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 7760,
        "virtualPath": "Microsoft.Extensions.FileProviders.Abstractions.wasm",
        "name": "Microsoft.Extensions.FileProviders.Abstractions.9yyzyhzoar.wasm",
        "hash": "sha256-sRFB2uRBAtZSby7XviddUiuqLTzVKdcxj+MLSw4N124=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 5200,
        "virtualPath": "Microsoft.Extensions.Hosting.Abstractions.wasm",
        "name": "Microsoft.Extensions.Hosting.Abstractions.wgrd77yf8o.wasm",
        "hash": "sha256-UI/VpVCSQq1k6851I2nIRybFHWT0BJkz8pnAhtB+6fs=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 31312,
        "virtualPath": "Microsoft.Extensions.Logging.Abstractions.wasm",
        "name": "Microsoft.Extensions.Logging.Abstractions.odr8nr64jh.wasm",
        "hash": "sha256-ZKDCkYCZDa7If6TzlUZspHFlAC7W/fqb5vw29DtBBos=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 27216,
        "virtualPath": "Microsoft.Extensions.Options.wasm",
        "name": "Microsoft.Extensions.Options.5ya6i84xrk.wasm",
        "hash": "sha256-E5F7spkpp43og2uetXvYmKGrfQRsYW1laAzBbBVliOA=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 18512,
        "virtualPath": "Microsoft.Extensions.Primitives.wasm",
        "name": "Microsoft.Extensions.Primitives.fg61bmp360.wasm",
        "hash": "sha256-7ymu3EHE854L14tTkSWlyI+UJ8E1Z40ALfeJ3tivXoI=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 5712,
        "virtualPath": "System.Collections.Concurrent.wasm",
        "name": "System.Collections.Concurrent.y1gijyulzg.wasm",
        "hash": "sha256-xvx/w4IwzVNuFAbIBp7weEiiHjSGMMhVObIV7+P9bQ4=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 55376,
        "virtualPath": "System.Collections.Immutable.wasm",
        "name": "System.Collections.Immutable.0hhhvfaqn0.wasm",
        "hash": "sha256-tK3mGFeeAC1syw4gTHh5ouj2pTP5Z9F2nIETXPNFF1g=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 8272,
        "virtualPath": "System.Collections.NonGeneric.wasm",
        "name": "System.Collections.NonGeneric.ag9nzj9s85.wasm",
        "hash": "sha256-ZrHBSj7OWteTvibbyvQpgzGJrXuItKHnzcmE729Eaq4=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 10832,
        "virtualPath": "System.Collections.Specialized.wasm",
        "name": "System.Collections.Specialized.1xfxbngu2i.wasm",
        "hash": "sha256-1fWMZm6cu1ZVxmVugNuso5IOyR3tD8yuV21jW+W0YYo=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 27728,
        "virtualPath": "System.Collections.wasm",
        "name": "System.Collections.iawxsft623.wasm",
        "hash": "sha256-RlZyuN9OVbCblkhSyK621H4JYqTUjqkBvBOsRCD++EA=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 31824,
        "virtualPath": "System.ComponentModel.Annotations.wasm",
        "name": "System.ComponentModel.Annotations.8vvz7xnvhi.wasm",
        "hash": "sha256-FEdZkEMnN5xUEsyJLQEFrETf8o5j1sS/NNlZ2DNOLX0=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 12368,
        "virtualPath": "System.ComponentModel.Primitives.wasm",
        "name": "System.ComponentModel.Primitives.o56fxjpl3q.wasm",
        "hash": "sha256-FHYuPVeZ7wGAzOIC5RhejMW2XRxxMyMST+dFCeWvmww=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 116304,
        "virtualPath": "System.ComponentModel.TypeConverter.wasm",
        "name": "System.ComponentModel.TypeConverter.n9a4wb8i6y.wasm",
        "hash": "sha256-+ziDvHkTRvRHSH4W/P+TXwaa7l/itMMinhxedfReeac=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 4688,
        "virtualPath": "System.ComponentModel.wasm",
        "name": "System.ComponentModel.dre8ytm0cg.wasm",
        "hash": "sha256-uVJJUT1DKu5RCowE7r2KWzwN9Q9Ep0+XYi0dg7lEvvs=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 18512,
        "virtualPath": "System.Console.wasm",
        "name": "System.Console.uwf3h0z8zq.wasm",
        "hash": "sha256-TlQiriMJI05PO1Md+d1f+ldVqRyXP+O01QGbvD/NKwU=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 15440,
        "virtualPath": "System.Data.Common.wasm",
        "name": "System.Data.Common.oj95v37ca6.wasm",
        "hash": "sha256-lJo08qn4NzwY8K8GJCvyJiVO9ct6f7WfPbTv/0Zvuxs=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 154704,
        "virtualPath": "System.Diagnostics.DiagnosticSource.wasm",
        "name": "System.Diagnostics.DiagnosticSource.nh1uj3xl2i.wasm",
        "hash": "sha256-9W1NY4Gs0InddmxZ9ydJn3gk5/1sOdaBpZuy7lXsLs0=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 8272,
        "virtualPath": "System.Diagnostics.Process.wasm",
        "name": "System.Diagnostics.Process.sj8utgtwve.wasm",
        "hash": "sha256-OCylU5IZRbOvSSVt3FAproC1Tw1z/FlvyAA2xcAZV7M=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 12368,
        "virtualPath": "System.Drawing.Primitives.wasm",
        "name": "System.Drawing.Primitives.2uuu4psq55.wasm",
        "hash": "sha256-ZkCYSs0hi//TxIXVdCwcTOislUr5fO7UezVK8IqHNmM=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 4688,
        "virtualPath": "System.Drawing.wasm",
        "name": "System.Drawing.3bol086sgb.wasm",
        "hash": "sha256-sRGmaSBlOf/bQnTB1qXnbF0bok44BoRdRtQlNm8PzRg=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 28752,
        "virtualPath": "System.IO.Compression.ZipFile.wasm",
        "name": "System.IO.Compression.ZipFile.f90g0k1wal.wasm",
        "hash": "sha256-U0W1wQLAjzlnxUX2pEMKqLjmHqgVHmkhOGF6gCOQGcM=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 165456,
        "virtualPath": "System.IO.Compression.wasm",
        "name": "System.IO.Compression.ch8ryeqj8k.wasm",
        "hash": "sha256-sB1e1DwykW15CpKtySuNqLjVWQLXL9DdzSRcvt9A5Vs=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 7248,
        "virtualPath": "System.IO.FileSystem.DriveInfo.wasm",
        "name": "System.IO.FileSystem.DriveInfo.7q06hzm4jj.wasm",
        "hash": "sha256-0TkApRmjngiO7OlExsj16txqoO4qfuntgzIMb2XelZM=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 7248,
        "virtualPath": "System.IO.FileSystem.Watcher.wasm",
        "name": "System.IO.FileSystem.Watcher.fodwfqn89v.wasm",
        "hash": "sha256-wWvSlQUtmZ+EUK6c5qyFVkP86ol63rXAlk7xWR3LbjI=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 31312,
        "virtualPath": "System.IO.Pipelines.wasm",
        "name": "System.IO.Pipelines.ib1v7e8rt7.wasm",
        "hash": "sha256-kkg/s5H1hirWy8PbVSoMh6Em4V043ax9kwPqeD6ZAEM=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 362576,
        "virtualPath": "System.Linq.Expressions.wasm",
        "name": "System.Linq.Expressions.p0frzhpz34.wasm",
        "hash": "sha256-N0SIodGzK72yD3cTjHPxm44rbU8hCs1IQGDO4HJA2ZM=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 56400,
        "virtualPath": "System.Linq.Queryable.wasm",
        "name": "System.Linq.Queryable.itpf6x10g9.wasm",
        "hash": "sha256-itVYQ+DVi1WR2sLg9R0I/Sh4rhrBVl8ib2BEBcniMZE=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 162384,
        "virtualPath": "System.Linq.wasm",
        "name": "System.Linq.oovafhzwof.wasm",
        "hash": "sha256-6EHoaz/SglVnXs0XB4a0Szs3fHoN3CSrPneHR9IzWVI=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 20048,
        "virtualPath": "System.Memory.wasm",
        "name": "System.Memory.8or3fx98r1.wasm",
        "hash": "sha256-KC5FKIR8HTC/Fm7vbVBanSnP5hLQH/66Up5hX9w5i2M=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 183376,
        "virtualPath": "System.Net.Http.wasm",
        "name": "System.Net.Http.6in08kos2v.wasm",
        "hash": "sha256-/s5YTSX/uYVqR3p7xQfueXqQoeIfhKtJCN9rhwFSx1w=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 37456,
        "virtualPath": "System.Net.Mail.wasm",
        "name": "System.Net.Mail.kddpxafp6s.wasm",
        "hash": "sha256-+GiGh86MRuo/XqQhEdlMVxqObtTvDqH59O4B9I33s2E=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 5200,
        "virtualPath": "System.Net.NameResolution.wasm",
        "name": "System.Net.NameResolution.xvmypg0q6h.wasm",
        "hash": "sha256-XSHQpHL/2OVWLEmKEDQ7RSU1mD/XzeOVRTEJkHwQ4TA=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 6224,
        "virtualPath": "System.Net.Ping.wasm",
        "name": "System.Net.Ping.zzilc52c1b.wasm",
        "hash": "sha256-kcxxpRz6cfScuA5gzVtPSQXKR8venuaXHx3lIBENkSE=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 29776,
        "virtualPath": "System.Net.Primitives.wasm",
        "name": "System.Net.Primitives.cx7pj91vte.wasm",
        "hash": "sha256-YHsWWf5KwXVemWhlZTyBuH0tphPeP6QYumIsssUchm8=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 5200,
        "virtualPath": "System.Net.Requests.wasm",
        "name": "System.Net.Requests.0cm6e9i3sh.wasm",
        "hash": "sha256-cNcaT8RaF2avDTQKtqxYrjwhu0sW0Hv2tmwaHhhH7Nc=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 5200,
        "virtualPath": "System.Net.Security.wasm",
        "name": "System.Net.Security.ertc45i4ud.wasm",
        "hash": "sha256-qvmuIpQjJI1rqXX3PmprZBsBxM0goRvicPbu54KIN+U=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 18000,
        "virtualPath": "System.Net.ServerSentEvents.wasm",
        "name": "System.Net.ServerSentEvents.qz4vs2ziox.wasm",
        "hash": "sha256-+kDLKYxW2VvU0zUkv2tJtNsAUI82g/OkeeIJyGmKnZ0=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 6224,
        "virtualPath": "System.Net.Sockets.wasm",
        "name": "System.Net.Sockets.qb9l5paet6.wasm",
        "hash": "sha256-ipSD0ajk2arbrUW6AoKCpqipFgVOEd0W6gX5EDUWw9M=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 28752,
        "virtualPath": "System.Net.WebSockets.Client.wasm",
        "name": "System.Net.WebSockets.Client.k4f2118uaw.wasm",
        "hash": "sha256-FP5TSiJ6uhgtKCzABf6NASLlUp5bzFNitX4eMB+VvI0=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 13392,
        "virtualPath": "System.Net.WebSockets.wasm",
        "name": "System.Net.WebSockets.g3pj5p5i7i.wasm",
        "hash": "sha256-zP4y2Mk4eR5p/Yjvx5zLnvoXuxDz6xeIVg9nJpkUFgA=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 6224,
        "virtualPath": "System.ObjectModel.wasm",
        "name": "System.ObjectModel.7kgla4n2ny.wasm",
        "hash": "sha256-FxEwOIlej158y4Z/ea5ipatnmNRAAbmWn5zbLFZkEqc=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 70224,
        "virtualPath": "System.Private.Uri.wasm",
        "name": "System.Private.Uri.7wc502qxu1.wasm",
        "hash": "sha256-h/j4UEW2Raxzftvvj8h13YBBlNl8oYeSuI3sqpZkqjE=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 35920,
        "virtualPath": "System.Private.Xml.Linq.wasm",
        "name": "System.Private.Xml.Linq.ujrwf466rb.wasm",
        "hash": "sha256-hs22RBg7SffX5mH5T3UpobERLurOrOF2TU2ula0iYXk=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 328272,
        "virtualPath": "System.Private.Xml.wasm",
        "name": "System.Private.Xml.mevve1lb2o.wasm",
        "hash": "sha256-Qs08GdEpwxXqeQUJL06WNfHRpverEm3Hz2uAnIciBJo=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 4688,
        "virtualPath": "System.Runtime.InteropServices.wasm",
        "name": "System.Runtime.InteropServices.h45u78t9gg.wasm",
        "hash": "sha256-j/P89v2MxGvt+Y4i4ajPrcb9yjdm5kbgTypp6vcLK2U=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 10832,
        "virtualPath": "System.Runtime.wasm",
        "name": "System.Runtime.e8086vgz0m.wasm",
        "hash": "sha256-LhVVTHEQTytI4zBMm2bX62Uy9v89yXEPANGfFJez8dM=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 24144,
        "virtualPath": "System.Security.Cryptography.wasm",
        "name": "System.Security.Cryptography.tfhlz62zka.wasm",
        "hash": "sha256-d/lyUBQAA5baM9sd+8+UDDNfORWhJcLRCHClo4UnIA4=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 32336,
        "virtualPath": "System.Text.Encodings.Web.wasm",
        "name": "System.Text.Encodings.Web.omf6jwget4.wasm",
        "hash": "sha256-oIdlhOoghVdd+nFRZ8kZ/ANp03yGlv9h8ofx4GEZlME=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 463952,
        "virtualPath": "System.Text.Json.wasm",
        "name": "System.Text.Json.rz3t6wsa0e.wasm",
        "hash": "sha256-dz+PvmB6bW5fTHmvP3TXapp2cN1RlB+g89UVEzzFvGk=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 166480,
        "virtualPath": "System.Text.RegularExpressions.wasm",
        "name": "System.Text.RegularExpressions.d80lj3ejiv.wasm",
        "hash": "sha256-k4yaUKPoGcK/FshmqsDHZJ7W6m6jrdXj7nuUqTflIoE=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 35408,
        "virtualPath": "System.Threading.Channels.wasm",
        "name": "System.Threading.Channels.9hammd2hgh.wasm",
        "hash": "sha256-jWjyYwGNENFVuOJLHXR3ZRscaI/bC4CrT6kUn8vg8u4=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 4688,
        "virtualPath": "System.Threading.wasm",
        "name": "System.Threading.4j3vyue1ko.wasm",
        "hash": "sha256-YCK+VQLAH0mkSI5jRhJTH5PPhdA+7JesxWoq7CN6E9A=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 4176,
        "virtualPath": "System.Xml.Linq.wasm",
        "name": "System.Xml.Linq.6jrwceho2h.wasm",
        "hash": "sha256-Yue7a3j8L0A300dI+FSbE9aWjzz0C7n1n3cYfwSb/as=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 4688,
        "virtualPath": "System.Xml.ReaderWriter.wasm",
        "name": "System.Xml.ReaderWriter.utao3818lg.wasm",
        "hash": "sha256-LqDGFyiaB+6nZwdX7KzCKJgLvJ0yCE3ToLKQnK7BJmk=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 4688,
        "virtualPath": "System.Xml.XDocument.wasm",
        "name": "System.Xml.XDocument.mp6u0t9lky.wasm",
        "hash": "sha256-hh4nMVjUf0e9+CJZfuL8KlEAhihbAemVxXe4pr+pVEs=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 4688,
        "virtualPath": "System.wasm",
        "name": "System.n1lgwvdeih.wasm",
        "hash": "sha256-deV0DUTbY0DlBTfQncbI/Sg+Eb7dON2nXbyolKeyvTM=",
        "cache": "force-cache"
      },
      {
        "payloadSize": 34896,
        "virtualPath": "AllMultiplayerGames.WebAssembly.wasm",
        "name": "AllMultiplayerGames.WebAssembly.chuvsyr13u.wasm",
        "hash": "sha256-8P9RYZYFcfSOiIOYmnr6chIncGuf0a8QJRqjQciGnI0=",
        "cache": "force-cache"
      }
    ]
  },
  "debugLevel": 0,
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
        "System.Diagnostics.Metrics.Meter.IsSupported": true,
        "System.Diagnostics.Tracing.EventSource.IsSupported": true,
        "System.GC.Server": true,
        "System.Globalization.Invariant": false,
        "System.TimeZoneInfo.Invariant": false,
        "System.Linq.Enumerable.IsSizeOptimized": true,
        "System.Net.Http.EnableActivityPropagation": true,
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
        "Microsoft.AspNetCore.Components.Endpoints.NavigationManager.DisableThrowNavigationException": false,
        "System.Diagnostics.StackTrace.IsLineNumberSupported": false,
        "System.Runtime.CompilerServices.RuntimeFeature.IsMultithreadingSupported": false
      }
    }
  }
}/*json-end*/);export{po as default,mo as dotnet,go as exit};
