using RestSharp;

namespace RaidArmyDS
{
    static class CaptchaSolving
    {
        private static RestClient client = new RestClient();
        private static RestRequest request = new RestRequest();
        private static IRestResponse response;

        public static string SolveCaptcha(string urlWhereCaptcha)
        {
            request.Resource = $"https://rucaptcha.com/in.php?key={FormConfigs.ruCaptchaApiKey}&method=userrecaptcha&googlekey=6Lef5iQTAAAAAKeIvIY-DeexoO3gj7ryl9rLMEnn&pageurl={urlWhereCaptcha}";
            switch (WebDriverInteractions.proxyData.Length)
            {
                case 4:
                    request.Resource += $"&proxy={WebDriverInteractions.proxyData[2]}:{WebDriverInteractions.proxyData[3]}@{WebDriverInteractions.proxyData[0]}:{WebDriverInteractions.proxyData[1]}&proxytype=HTTPS";
                    break;
                case 2:
                    request.Resource += $"&proxy={WebDriverInteractions.proxyData[0]}:{WebDriverInteractions.proxyData[1]}&proxytype=HTTPS";
                    break;
                default:
                    request.Resource = $"https://rucaptcha.com/in.php?key={FormConfigs.ruCaptchaApiKey}&method=userrecaptcha&googlekey=6Lef5iQTAAAAAKeIvIY-DeexoO3gj7ryl9rLMEnn&pageurl={urlWhereCaptcha}";
                    break;
            }
            response = client.Execute(request, Method.POST);
            request = new RestRequest($"https://rucaptcha.com/res.php?key={FormConfigs.ruCaptchaApiKey}&action=get&id={response.Content.Split('|')[1]}");
            response = client.Execute(request, Method.GET);
            while (response.Content == "CAPCHA_NOT_READY")
            {
                System.Threading.Thread.Sleep(5000);
                response = client.Execute(request, Method.GET);
            }
            if (response.Content == "ERROR_CAPTCHA_UNSOLVABLE")
            {
                return SolveCaptcha(urlWhereCaptcha);
            }
            return response.Content.Split('|')[1];
        }
    }
}
