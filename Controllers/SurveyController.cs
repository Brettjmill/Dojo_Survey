using Microsoft.AspNetCore.Mvc;
namespace Time_Display.Controllers     //be sure to use your own project's namespace!
{
    public class SurveyController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]       //type of request
        [Route("result")]     //associated route string (exclude the leading /)
        public IActionResult Result(string NameInput, string DojoInput, string LangInput, string CommentInput)
        {
            ViewBag.Name = NameInput;
            ViewBag.Dojo = DojoInput;
            ViewBag.Lang = LangInput;
            ViewBag.Comment = CommentInput;
            return View();
        }
    }
}