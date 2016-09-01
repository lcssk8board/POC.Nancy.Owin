using Nancy;
using POC.Nancy.Owin.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POC.Nancy.Owin.Modules
{
    public class SampleModule : NancyModule
    {
        private readonly IService _service;

        public SampleModule(IService service) 
            : base("/sample")
        {
            _service = service;

            Get["/"] = _ => "Hello World!";
        }
    }
}