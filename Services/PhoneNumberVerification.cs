using RestSharp;
using System.Diagnostics;

namespace RaidArmyDS
{
    class PhoneNumberVerification
    {
        private RestClient client = new RestClient();
        private RestRequest request;
        private IRestResponse response;
        private string idNumberReservation;
        private Stopwatch numberReservationTimer;

        public string NumberReservation()
        {
            request = new RestRequest($"https://sms-activate.ru/stubs/handler_api.php?api_key={FormConfigs.smsActivateApiKey}&action=getNumber&service=ds&country=2");
            response = client.Execute(request, Method.GET);
            numberReservationTimer = new Stopwatch();
            numberReservationTimer.Start();
            idNumberReservation = response.Content.Split(':')[1];
            return response.Content.Split(':')[2];
        }
        public string Verify()
        {
            request = new RestRequest($"https://sms-activate.ru/stubs/handler_api.php?api_key={FormConfigs.smsActivateApiKey}&action=getStatus&id={idNumberReservation}");
            response = client.Execute(request, Method.GET);
            while (response.Content == "STATUS_WAIT_CODE")
            {
                System.Threading.Thread.Sleep(5000);
                response = client.Execute(request, Method.GET);
                if (numberReservationTimer.Elapsed > System.TimeSpan.FromMinutes(2))
                {
                    numberReservationTimer.Stop();
                    request = new RestRequest($"https://sms-activate.ru/stubs/handler_api.php?api_key={FormConfigs.smsActivateApiKey}&action=setStatus&status=8&id={idNumberReservation}");
                    response = client.Execute(request, Method.POST);
                    return response.Content;
                }
            }
            return response.Content.Split(':')[1];
        }

        public void RecreateNumber()
        {
            request = new RestRequest($"https://sms-activate.ru/stubs/handler_api.php?api_key={FormConfigs.smsActivateApiKey}&action=setStatus&status=8&id={idNumberReservation}");
            response = client.Execute(request, Method.POST);
        }
    }
}
