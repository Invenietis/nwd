using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Nwd.Framework
{
    public class RouteExtractor
    {
        public static RouteContext Extract( HttpRequest request )
        {
            string pathAndQuery = request.Url.PathAndQuery;
            string[] routesParams = pathAndQuery.Trim( '/' ).ToLowerInvariant().Split( '/' );

            RouteContext ctx = new RouteContext();
            ctx.ControllerName = routesParams[0];
            ctx.MethodName = routesParams[1];
            ctx.MethodParams = routesParams.Skip( 2 ).ToArray();
            return ctx;
        }
    }

    public class RouteContext
    {
        public string ControllerName { get; set; }

        public string MethodName { get; set; }

        public object[] MethodParams { get; set; }
    }
}
