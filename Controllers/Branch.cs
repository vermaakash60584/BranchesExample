using Microsoft.AspNetCore.Mvc;

namespace BranchExercise.Controllers
{
    public class Branch : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
