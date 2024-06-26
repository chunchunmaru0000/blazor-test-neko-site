﻿using NekoSiteTest.Models;

namespace NekoSiteTest.Clients
{
    public class NekoClient
    {
		public string UrlWas = "nekolog";

		public List<NekoPost>? GottenPosts = null;
		private List<NekoPost> Posts = 
		[
			new()
			{
				Id = 0,
				Image = "https://upload.wikimedia.org/wikipedia/commons/1/13/Vladimir_Putin_September_5%2C_2022_%28cropped%29.jpg",
				Name = "Владимир Владимирович Путин",
				Price = 999999999m,
				Description = "дадада",
				Specifications = new Dictionary<string, string>()
				{
					{ "рост", "123" },
					{ "возраст", "1" },
				},
				Photos = []
			},
			new()
			{
				Id = 1,
				Image = "/Images/felix.jpg",
				Name = "Феликс",
				Price = 1488m,
				Description = "Не трап точно.",
				Specifications = new Dictionary<string, string>()
				{
					{ "рост", "321" },
					{ "возраст", "0" },
				},
				Photos = []
			},
			new()
			{
				Id = 2,
				Image = "/Images/pfelis/pf0.jpg",
				Name = "Пардофелис",
				Price = 111111110m,
				Description = "泱泱大國中國贈送貓妻",
				Specifications = new Dictionary<string, string>()
				{
					{ "рост", "164см" },
					{ "вес", "50кг" },
					{ "возраст", "50000+" },
				},
				Photos = [
					"/Images/pfelis/pf0.jpg",
					"/Images/pfelis/pf1.jpg",
					"/Images/pfelis/pf2.jpg",
					"/Images/pfelis/pf3.jpg",
					"/Images/pfelis/pf4.png",
					]
			},
		];

        public NekoPost[] GetNekos() => [.. Posts];

		public void EraseGotten() => GottenPosts = null;

		public void SetPosts(List<NekoPost> posts) => Posts = posts.Where(p => !Cart.Any(c => c.Id == p.Id)).ToList();

        public void AddPost(NekoPost post) => Posts.Add(post);

        public void DeletePost(int id) => Posts.Remove(Posts.Single(p => p.Id == id));

		public void ReplaceNeko(NekoPost neko)
		{
			for(int i = 0; i < Posts.Count; i++)
				if (Posts[i].Id == neko.Id)
				{
					Posts[i] = neko;
					break;
				}
		}

		// Cart
		public List<NekoPost> Cart = [];

		public void AddToCart(NekoPost post) => Cart.Add(post);

		public NekoPost[] GetCart() => [.. Cart];

		public void DeleteCart(int id) => Cart.Remove(Cart.Single(p => p.Id == id));

		// Liked
		public List<NekoPost> Liked = [];

		public void AddToLiked(NekoPost post) => Liked.Add(post);

		public NekoPost[] GetLiked() => [.. Liked];

		public void DeleteLiked(int id) => Liked.Remove(Liked.Single(p => p.Id == id));
	}
}
