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

        // TD DropDownList
        public ActionResult TD_DropDownList()
        {
            List<Project> ls_project = new List<Project>();
            for (int i = 0; i < 10; i++)
            {
                ls_project.Add(new Project() {
                    Name = "Project " + i,
                    ProjectId = i
                });
            }
            Task task = new Task();
            task.Name = "Task1";
            task.Project = ls_project.Last();
            task.ProjectId = 9;

            ViewBag.ProjectId = new SelectList(
                ls_project, "ProjectId", "Name", task.ProjectId);
            return View(task);
        }



        public ActionResult ShowProject()
        {
            
            return View();
        }


    }
}