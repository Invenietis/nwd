using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nwd.Framework
{
    internal class IntexViewEngine
    {
        public static IView FindView( string name )
        {
            return new IntexView( name );
        }
    }
}
