var config = {
  mode: "fixed_servers",
  rules: {
    singleProxy: {
      scheme: "http",
      host: "zproxy.lum-superproxy.io",
      port: parseInt("22225")
    },
    bypassList: ["foobar.com"]
  }
};

chrome.proxy.settings.set({ value: config, scope: "regular" }, function () { });

function callbackFn(details) {
  return {
    authCredentials: {
      username: "lum-customer-hl_eb9f8420-zone-static-ip-205.237.94.135",
      password: "29gqn7d916xf"
    }
  };
}

chrome.webRequest.onAuthRequired.addListener(
  callbackFn,
  { urls: ["<all_urls>"] },
  ['blocking']
);