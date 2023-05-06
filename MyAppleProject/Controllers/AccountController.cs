using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyAppleProject.Infrasrtucture;

namespace MyAppleProject.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly DataContext _context;
        public IActionResult Index()
        {
            return View();
        }
    }
}
