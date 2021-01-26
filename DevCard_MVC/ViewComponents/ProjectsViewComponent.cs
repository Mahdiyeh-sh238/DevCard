using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent

    {
       
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(1,"تاکسی","snapp","در خواست تاکسی درون شهری","Snapp","project-1.jpg"),
                new Project(2,"زودفود","zoodfood","در خواست غذا","tehranFood","project-2.jpg"),
                new Project(3,"مدارس","school","در خواست تاکسی درون شهری","School","project-3.jpg"),
                new Project(4,"فضاپیما","snapp","در خواست فضاپیما درون شهری","NASA","project-4.jpg"),

            };
            return View("_Projects",projects);
        }
    }
}
