using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace DevCard_MVC.Controllers
{
    public class Test : Controller
    {
        // public PartialViewResult Index()
        // {
        //     return PartialView("Footer");
        // }


        // public ContentResult Index()
        // {
        //     return Content("<h1 style='color:red';>salaaaaaaaaaaaaam</h1>","text/html");
        // }

        // public EmptyResult Index()
        // {
        //     return new EmptyResult();
        //     return null;
        // }

        // public FileResult Index()
        // {
        //    //  return File("~/test.txt", "text/html");
        //     var fileByte = System.IO.File.ReadAllBytes("wwwroot/test.txt");
        //     const String fileName = "textFile.txt";
        //     return File(fileByte, MediaTypeNames.Text.Plain, fileName);
        // }


        // public JsonResult Index()
        // {
        //     return Json(new
        //     {
        //         id = 12,
        //         name = "hasan",
        //         job = "program"
        //     });
        // }


        /*public class JavaScriptResult:ContentResult
        {
            public JavaScriptResult(String Data)
            {
                Content = Data;
                ContentType = "application/javascript";
            }
        }

        public JavaScriptResult Index()
        {
            return new JavaScriptResult("alert('salam')");
        }*/

        // public RedirectResult Index()
        // {
        //     return Redirect("https://www.google.com");
        //
        // }


        // public RedirectToActionResult Index()
        // {
        //     return RedirectToAction("Contact", "Home");
        // }

        public IActionResult Index()
        {
           // return new BadRequestResult();
        //   return new OkResult();
       // return new NoContentResult();
        return new StatusCodeResult(401);
        }
    }
}
