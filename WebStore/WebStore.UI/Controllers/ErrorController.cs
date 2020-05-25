using Microsoft.AspNetCore.Mvc;

namespace WebStore.UI.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    ViewBag.StatusCode = "404";
                    ViewBag.ErrorMessage = "Sorry, the resource you requested could not be found!";
                    break;
            }

            return View("NotFound");
        }
    }
}