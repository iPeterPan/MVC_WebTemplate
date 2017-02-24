using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace MVC_WebfTemplate.Controllers
{
    public class HomeController : ApiController
    {
        public HomeController()
        {
            
        }

        public ActionResult Index()
        {
            return this.View();
        }
    }
}
