using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nwd.Framework
{
    public class ControllerFinder
    {
        internal static object CreateControllerBy( string controllerName )
        {
            return null;
        }

        internal static string ExtractControllerNameFrom( System.Web.HttpRequest httpRequest )
        {
            return "Controller";
        }
    }
}
