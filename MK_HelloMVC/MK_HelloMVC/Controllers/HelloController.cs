using Microsoft.AspNetCore.Mvc;

namespace MK_HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        //http://localhost:58231/hello?name=mary
        [HttpGet]
        public IActionResult Index(string name = "World")
        {
            /*
            if (string.IsNullOrEmpty(name))
            {
                name = "World";
            }
            */
            //return Content(string.Format("<h1> Hello {0} </h1>", name), "text/html");

            string html = "<form method='post' >" +
                "<input type='text' name='name' />" +
                "<input type='submit' value='Greet me!' />" +
                "</form>";

            //return Content(html, "text/html");

            return Redirect("Hello/Goodbye");
        }

        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name = "World")
        {
            return Content(string.Format("<h1> Hello {0} </h1>", name), "text/html");
        }

        [Route("Hello/{name}")]
        public IActionResult Index2(string name )
        {
            return Content(string.Format("<h1> Hello {0} </h1>", name), "text/html");
        }

        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}