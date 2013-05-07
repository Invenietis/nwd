using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nwd.Framework.Test
{
    public class Controller
    {
        /// <summary>
        /// This method by calling my website by using GET: http://mywebsite/ and http://mywebsite/index
        /// </summary>
        /// <returns></returns>
        public ControllerMethodResult Index( string name )
        {
            object model = name.ToUpperInvariant();
            
            return new SimpleViewResult( model );
        }
    }
}
