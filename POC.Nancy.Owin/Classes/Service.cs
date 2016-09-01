using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POC.Nancy.Owin.Classes
{
    public class Service : IService
    {
        public void Test()
        {
            Console.Write("OK");
        }
    }
}