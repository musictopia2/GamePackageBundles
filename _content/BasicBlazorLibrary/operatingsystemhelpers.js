export function getOS() {
    var userAgent = window.navigator.userAgent,
        platform = window.navigator.platform,
        macosPlatforms = ['Macintosh', 'MacIntel', 'MacPPC', 'Mac68K'],
        windowsDesktops = ['Win32', 'Win64', 'Windows'],
        iosPlatforms = ['iPhone', 'iPad', 'iPod'],
        os = "othertabletorphone"; //does not matter if its windows phones.
    if (macosPlatforms.indexOf(platform) !== -1) {
        os = 'Mac OS';
    } else if (iosPlatforms.indexOf(platform) !== -1) {
        os = 'iOS';
    } else if (windowsDesktops.indexOf(platform) !== -1) {
        os = 'Windows';

    } else if (/Android/.test(userAgent)) {
        os = 'Android';
    } else if (!os && /Linux/.test(platform)) {
        os = 'Linux';
    }
    return os;
}

export function hasKeyboard() {
    var os = getOS();
    if (os == 'Windows') {
        return true;
    }
    if (os == 'Mac OS') {
        return true;
    }
    if (os == 'Linux') {
        return true;
    }
    return false;
}