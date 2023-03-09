using ApiTest.Model;
using ApiTest.Service;

namespace ApiTest.Api
{
    public class ApiBasePost : ApiClient<PostModel>
    {
        public ApiBasePost(string UrlPath) : base(UrlPath)
        {

        }
    }
}
