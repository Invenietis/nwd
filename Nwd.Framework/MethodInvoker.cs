using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nwd.Framework
{
    public class MethodInvoker
    {
        internal static ControllerMethodResult InvokeControllerMethod( object controller, RouteContext routeContext )
        {
            return (ControllerMethodResult)controller
                .GetType()
                .GetMethod( routeContext.MethodName, System.Reflection.BindingFlags.IgnoreCase | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public )
                .Invoke( controller, routeContext.MethodParams );
        }
    }
}
