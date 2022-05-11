using System.Web.Http;
using Newtonsoft.Json.Linq;

namespace ToDoListAPI.Controllers
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class AuthenticationController : ApiController
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
        [HttpPost]
        [Route("Authentication")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public JObject AuthenticationService([FromBody] JObject authenticationJson)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            JObject retJson = new JObject();
            string username = authenticationJson["username"].ToString();
            string password = authenticationJson["password"].ToString();
            if (username == "user" && password == "user")
            {
                retJson.Add(new JProperty("authentication ", "successful"));
            }
            else
            {
                retJson.Add(new JProperty("authentication ", "unsuccessful"));
            }
            return retJson;
        }
    }
}