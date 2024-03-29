﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nwd.Framework;

namespace Nwd.Controllers
{
    public class MyController
    {
        /// <summary>
        /// This method by calling my website by using GET: http://mywebsite/ and http://mywebsite/index
        /// </summary>
        /// <returns></returns>
        public ControllerMethodResult Index( string name )
        {
            return new SimpleViewResult( name.ToUpperInvariant() );
        }
    }
}