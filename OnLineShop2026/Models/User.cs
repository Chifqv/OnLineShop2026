using Microsoft.Extensions.Hosting;

namespace OnLineShop2026.Models
{
	public class User
	{

		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Sername { get; set; }
		public string Email { get; set; }
		public string PhotoPath { get; set; }

		public User(string name,string sername, string email, string photoPath = "/images/basePhoto.jpg")
		{
			Id = Guid.NewGuid();
			Name = name;
			Sername = sername;
			Email = email;
			PhotoPath = photoPath;
		}

		public override string ToString()
		{
			return $"Имя - {Name + " " + Sername }, почта - {Email}";
		}
	}
}
