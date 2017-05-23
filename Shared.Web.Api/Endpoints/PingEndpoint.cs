using Nancy;

namespace Shared.Web.Api.Endpoints
{
    public class PingEndpoint : NancyModule
    {
        public PingEndpoint()
        {
            Get("/ping", x => Ping());
        }

        private string Ping()
        {
            return "Hello World!";
        }
    }
}