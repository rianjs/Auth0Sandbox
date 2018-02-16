using System.Web.Http;
using System.Web.Http.Description;

namespace Auth0Echo.Controllers
{
    public class EchoController : ApiController
    {
        [HttpGet]
        [Route("ping")]
        [ResponseType(typeof(string))]
        public string Ping() => "Pong!";

        [HttpGet]
        [Route("echo")]
        [ResponseType(typeof(string))]
        public string Echo()
        {
            return "Hello world";
        }
    }
}