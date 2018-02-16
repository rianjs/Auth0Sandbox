using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using Auth0Echo.Controllers;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Auth0Echo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            var mediaTypeFormatter = new JsonMediaTypeFormatter
            {
                SerializerSettings =
                    new JsonSerializerSettings
                    {
                        DefaultValueHandling = DefaultValueHandling.Ignore,
                        ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    }
            };
            config.Formatters.Clear();
            config.Formatters.Add(mediaTypeFormatter);
            config.Services.Replace(typeof(IHttpControllerActivator), new EchoControllerActivator());
            config.Services.AddMvc();
        }
    }
}
