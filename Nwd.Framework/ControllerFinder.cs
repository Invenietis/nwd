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
            // In order to find a class, in the .Net App Domain, we use reflection.

            var assemblies = Assembly.Load( "Nwd" );
            foreach( var type in assemblies.GetTypes() )
            {
                if( type.Name.EndsWith( controllerName + "Controller", StringComparison.InvariantCultureIgnoreCase ) )
                {
                    return Activator.CreateInstance( type );
                }

            }

            return null;
        }
    }
}
