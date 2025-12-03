using System.Web.Http;
using System.Web.Http.Cors;

namespace Practica4.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Habilitar CORS global
            config.EnableCors(new EnableCorsAttribute(
                origins: "*",
                headers: "*",
                methods: "*"
            ));

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
