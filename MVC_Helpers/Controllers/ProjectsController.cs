using MVC_Helpers.Models;
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

        // TD Label
        public ActionResult TD_Label()
        {
            var project = new MVC_Helpers.Models.Project();
            return View(project);
        }


        // TD EditorFor
        public ActionResult TD_EditorFor()
        {
            var project = new MVC_Helpers.Models.Project();
            project.Name = "Project 1";
            project.Description = "Description project 1";
            return View(project);
        }



        public ActionResult ShowProject()
        {
            return View();
        }


    }
}