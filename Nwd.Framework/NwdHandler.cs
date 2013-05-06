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
            }
            else
            {
                // 404, no controller to invoke.
                context.Response.StatusCode = 404;
            }
        }
    }
}
