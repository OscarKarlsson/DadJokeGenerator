using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DadJokeGenerator.API
{
    public class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }
        public static void InitilizeClient()
        {
            ApiClient = new HttpClient();

            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
