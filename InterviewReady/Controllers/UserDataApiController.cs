using InterviewReady.BusinessLogic;
using InterviewReady.UserContext;
using Microsoft.AspNetCore.Mvc;
namespace InterviewReady.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDataApiController : Controller
    {
        public readonly UserDbContext userontext;
        public UserDataApiController(UserDbContext userontext)
        {
            this.userontext = userontext;
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Get()
        {

            UserBL userBL = new UserBL(userontext);
            userBL.UserExists()
            return View();
        }


    }
}
