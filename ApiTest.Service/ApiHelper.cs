using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;

namespace ApiTest.Service
{
    public class ApiHelper
    {
        public static HttpResponseMessage GetApiResponse(String url, HttpMethod type, StringContent data)
        {
            HttpClient client = new HttpClient();
            if (type == HttpMethod.Post)
            {
                return client.PostAsync(url, data).Result;
            }
            else if (type == HttpMethod.Get)
            {
                return client.GetAsync(url).Result;
            }
            else if (type == HttpMethod.Put)
            {
                return client.PutAsync(url, data).Result;
            }
            else if (type == HttpMethod.Delete)
            {
                return client.DeleteAsync(url).Result;
            }
            else
            {
                return client.GetAsync(url).Result;
            }
        }
        public static StringContent ConvertObjectToStringContent(Object obj)
        {
            var json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            return data;
        }
    }
}
