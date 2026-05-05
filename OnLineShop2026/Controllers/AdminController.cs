using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Data;
using OnLineShop2026.Models;

namespace OnLineShop2026.Controllers
{
    public class AdminController : Controller
    {
		IUserRepository usersRepository;

		public AdminController(IUserRepository userRep)
		{
			usersRepository = userRep;

		}
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult UsersCatalog()
		{
			var users = usersRepository.GetAll();

			return View(users);
		}
	}
}
