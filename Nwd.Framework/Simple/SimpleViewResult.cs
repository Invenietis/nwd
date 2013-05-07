using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Nwd.Framework
{
    public class SimpleViewResult : ControllerMethodResult
    {
        public object Model { get; set; }

        public SimpleViewResult( object model )
        {
            Model = model;
        }

        public override void Execute( HttpContext httpContext )
        {
            httpContext.Response.Write( Model.ToString() );
        }
    }
}
