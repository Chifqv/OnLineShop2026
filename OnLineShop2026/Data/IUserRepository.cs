using OnLineShop2026.Models;

namespace OnLineShop2026.Data
{
	public interface IUserRepository
	{
		void Add(User user);
		List<User> GetAll();
		User? TryGetById(Guid userId);
	}
}
