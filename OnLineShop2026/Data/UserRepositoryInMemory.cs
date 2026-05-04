using OnLineShop2026.Models;

namespace OnLineShop2026.Data
{
	public class UserRepositoryInMemory : IUserRepository
	{
		List<User> users = new List<User>() { new User("Элина", "Кокоева", "elina@mail.ru"), new User("Лерочка", "Хубулова", "lera@gmail.com", "/images/userLera.jpg") };

		public void Add(User user)
		{
			user.Id = Guid.NewGuid();
			users.Add(user);
		}

		public List<User> GetAll() => users;

		public User? TryGetById(Guid userId) => users.FirstOrDefault(user => user.Id == userId);
	}
}
