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
                "<select name = 'language' id = 'language-select'>" +
                "<option value = 'english' selected > English </option >" +
                "<option value = 'french' > French </option >" + 
                "<option value = 'spanish' > Spanish </option >" +
                "<option value = 'german' > German </option >" +
                "<option value = 'italian' > Italian </option >" +
                "<option value = 'hindi' > Hindi </option >" +
                "<option value = 'farsi' > Farsi </option >" + 
                "</select >" +
                "</form>";

            return Content(html, "text/html");

            //return Redirect("Hello/Goodbye");
        }

        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name, string language)
        {

            //return Content(string.Format("<h1> Hello {0} </h1>", name), "text/html");

            if (string.IsNullOrEmpty(name))
            {
                name = "World";
            }

            return Content(string.Format("<h1> {0}</h1>", CreateMessage(name, language)), "text/html");
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

        public static string CreateMessage (string name, string language)
        {
            switch (language)
            {
                case "french":
                    return "Bonjour " + name;

                case "spanish":
                    return "Hola " + name;

                case "german":
                    return "Guten tag " + name;

                case "italian":
                    return "Caio " + name;

                case "hindi":
                    return "Namaste  " + name;

                case "farsi":
                    return "Salaam " + name;

                default:
                    return "Hello " + name;
            }
        }
    }
}