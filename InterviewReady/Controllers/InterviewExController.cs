using Microsoft.AspNetCore.Mvc;

namespace InterviewReady.Controllers
{
    public class InterviewExController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
