using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        // QueryStrings

        // url//Default/Index/10?a=10&b=20
        // url//Default/Index/10?b=20
        // url//Default/Index/10?a=10
        // url//Default/Index/10?a=10&b=20&c=30
        // url//Default/Index/10?c=30&a=10&b=20


        public IActionResult Index(int? id, int a=10, int b=20 ,int c=30)
        {   
            //if(id== null)
            //    return NotFound();

            ViewBag.id = id;
            ViewBag.a = a;
            ViewBag.b = b;
            ViewBag.c = c;

            return View();
        }
        public IActionResult View1()
        {
            //if(id== null)
            //    return NotFound();

            
            return View("Index1");
        }
        public IActionResult View2()
        {
            //if(id== null)
            //    return NotFound();


            return View();
        }
        public IActionResult View3()
        {
            //if(id== null)
            //    return NotFound();


            return View();
        }
        public IActionResult View4()
        {
            //if(id== null)
            //    return NotFound();

            return View();
        }
        public IActionResult View5()
        {
            //if(id== null)
            //    return NotFound();



            return View();
        }
    }
}
