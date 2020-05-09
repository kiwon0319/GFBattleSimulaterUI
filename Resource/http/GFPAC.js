function FindProxyForURL(url, host) {
  /* GFAlarm Proxy */
  if (dnsDomainIs(host, "gf-game.girlfrontline.co.kr") || // Korea
      shExpMatch(host, "*.ppgame.com") || // China
      shExpMatch(host, "*.sunborngame.com") || // Global/Japan
      shExpMatch(host, "*.txwy.tw")) { // Taiwan
    return "PROXY 192.168.0.10:9000";
  } else {
    return "DIRECT";
  } 
}