using NekoSiteTest.Models;

namespace NekoSiteTest.Clients
{
	public class CreateClient
	{
		public NekoPost Neko = new()
		{
			Id = -1,
			Name = "",
			Image = "любое",
			Price = 0m,
			Description = "",
			Photos = [],
			Specifications = []
		};
	}
}
