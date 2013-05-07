using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nwd.Framework
{
    public class IntexViewResult : ControllerMethodResult
    {
        public string ViewName { get; set; }

        public object Model { get; set; }

        public IntexViewResult( string viewName, object model )
        {
            ViewName = viewName;
            Model = model;
        }

        public override void Execute( System.Web.HttpContext httpContext )
        {
            // Find view
            IView view = IntexViewEngine.FindView( ViewName );
            // Render view response with model
            view.RenderWith( httpContext, Model );
        }
    }
}
