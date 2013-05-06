using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Nwd.Framework
{
    public class ControllerFinder
    {
        internal static object CreateControllerBy( string controllerName )
        {
            var assemblies = Assembly.Load( "Nwd" );
            foreach( var type in assemblies.GetTypes() )
            {
                if( type.Name.EndsWith( "MyController" ) )
                {
                    return Activator.CreateInstance( type );
                }

            }

            return null;
        }

        internal static string ExtractControllerNameFrom( System.Web.HttpRequest httpRequest )
        {
            return "Controller";
        }
    }
}
