using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nwd.Framework
{
    internal class IntexView : IView
    {
        string _name;
        public IntexView( string name )
        {
            _name = name;
        }

        public void RenderWith( System.Web.HttpContext httpContext, object model )
        {
            httpContext.Response.Write( model.ToString() );
        }
    }
}
