using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace TRMDesktopUI.Helpers
{
    class APIHelper
    {
        public HttpClient ApiClient { get; set; }

        public APIHelper()
        {
            IntializeClient();
        }

        private void IntializeClient()
        {
            string api = ConfigurationManager.AppSettings["api"];


            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task Athenticate(string username, string password)
        {
            var data = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "password"),
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password)

            });

            using (HttpResponseMessage response = await ApiClient.PostAsync("/token", data))
            {
                var result = await response.Content.ReadAsAsync<string>();
            }
        }
    }
}
