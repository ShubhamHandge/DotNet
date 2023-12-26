using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace StateManagement.Controllers
{
    public class DefaultController : Controller
    {
       
        public ActionResult Index()
        {

            ViewData["a"] = 100;
            TempData["b"] = 200;
            return View();
            //return RedirectToAction("Index2");  // will not be able to access ViewData from 1st view
        }
        public ActionResult Index1()
        {
            return View();
        }
        public ActionResult Session1()
        {
            HttpContext.Session.SetInt32("a", 20);
            HttpContext.Session.SetString("b", "abcd");

            Employee emp = new Employee { EmpNo=1,Name= "Ram" };

            string jsonEmp = JsonSerializer.Serialize<Employee>(emp);
            HttpContext.Session.SetString("emp", jsonEmp);
            
            return View();
        }
        public ActionResult Session2()
        {
            int a = HttpContext.Session.GetInt32("a").Value;
            string b = HttpContext.Session.GetString("b");

            string e = HttpContext.Session.GetString("emp");
            Employee emp = JsonSerializer.Deserialize<Employee>(e);

            ViewBag.name = emp.Name;
            return View();
        }
        public ActionResult Session3()
        {
            return View();
        }

    }
    public class  Employee
    {
        public int EmpNo {  get; set; }
        public string Name { get; set; }
    }
}
