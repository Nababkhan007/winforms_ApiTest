using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace ApiTest.Service
{
    public class ApiClient<ResponseType> where ResponseType : new()
    {
        private readonly String _ApiUrl;
        public ApiClient(String UrlPath)
        {
            _ApiUrl = ApiUrl.UrlBase + UrlPath;
        }
        public virtual ResponseType Get()
        {
            HttpResponseMessage response = ApiHelper.GetApiResponse(_ApiUrl, HttpMethod.Get, null);
            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<ResponseType>(response.Content.ReadAsStringAsync().Result);
                return result;
            }
            else
            {
                return new ResponseType();
            }
        }

        public virtual System.Collections.Generic.List<ResponseType> GetList()
        {
            HttpResponseMessage response = ApiHelper.GetApiResponse(_ApiUrl, HttpMethod.Get, null);
            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<System.Collections.Generic.List<ResponseType>>(response.Content.ReadAsStringAsync().Result);
                return result;
            }
            else
            {
                return new System.Collections.Generic.List<ResponseType>();
            }
        }
    }
    public class ApiClient<RequestType, ResponseType> where RequestType : new() where ResponseType : new()
    {
        private readonly String _ApiUrl;
        public ApiClient(String UrlPath)
        {
            _ApiUrl = ApiUrl.UrlBase + UrlPath;
        }
        public virtual ResponseType Post(RequestType obj)
        {
            var data = ApiHelper.ConvertObjectToStringContent(obj);
            HttpResponseMessage response = ApiHelper.GetApiResponse(_ApiUrl, HttpMethod.Post, data);
            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<ResponseType>(response.Content.ReadAsStringAsync().Result);
                return result;
            }
            else
            {
                return new ResponseType();
            }
        }
    }
}
