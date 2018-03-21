using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Helpers.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: HelpersDemo
        public ActionResult Index()
        {
            return View();
        }

        // TD - Beginform
        public ActionResult TD_Beginform()
        {
            return View();
        }

        // TD - EditorForm
        public ActionResult TD_AntiForgeryToken()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        public ActionResult TD_AntiForgeryToken_Action()
        {
            return View();
        }


    }
}