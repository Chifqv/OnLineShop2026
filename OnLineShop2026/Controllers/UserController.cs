using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Data;
using OnLineShop2026.Models;

namespace OnLineShop2026.Controllers
{
    public class UserController : Controller
    {
		public IActionResult Index()
		{
			User user = new User("Элина", "Кокоева", "elina@mail.ru");
			return View(user);
		}
	}
}
