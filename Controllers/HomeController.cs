using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace dojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")] 
        public IActionResult index()
        {
            return View();
        }

        [HttpPost]
        [Route("result")]

        public IActionResult Result(string name, string location, string favLanguage, string comment)
        {
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.favLanguage = favLanguage;
            ViewBag.comment = comment;

            return View();
        }
    }
}