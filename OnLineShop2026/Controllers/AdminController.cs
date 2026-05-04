using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Data;

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
			var users = usersRepository.GetAll();

			return View(users);
		}
	}
}
