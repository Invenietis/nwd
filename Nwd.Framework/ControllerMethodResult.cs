using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Nwd.Framework
{
    public abstract class ControllerMethodResult
    {
        public abstract void Execute( HttpContext httpContext );
    }

    public interface IView
    {
        void RenderWith( HttpContext httpContext, object model );
    }
}
