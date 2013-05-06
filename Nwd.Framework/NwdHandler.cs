using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Nwd.Framework
{
    public class NwdHandler : IHttpHandler
    {
        /// <summary>
        /// Web don't know for the moment if we need to be reusable or not.
        /// This could be optimized further.
        /// </summary>
        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest( HttpContext context )
        {
            string pathAndQuery = context.Request.Url.PathAndQuery;
            pathAndQuery = pathAndQuery.Trim('/').ToLowerInvariant();
            if( pathAndQuery == String.Empty || pathAndQuery == "index" )
            {
                // Invoke our controller
                // Need to find a way to get a controller !
                // What is a controller here ? This is a class that owns methods. 
                // But, what will be the search key ? How we associates a controller with a request URL Get ?
                string controllerName = ControllerFinder.ExtractControllerNameFrom( context.Request ); // ?
                
                // In order to find a class, in the .Net App Domain, we use reflection.
                object controller = ControllerFinder.CreateControllerBy( controllerName );
                
            }
            else
            {
                // 404, no controller to invoke.
                context.Response.StatusCode = 404;
            }
        }
    }
}
