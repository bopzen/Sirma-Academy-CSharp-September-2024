using Newtonsoft.Json;

namespace _05ClassStorage
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Product productOne = new Product("cucumber", 1.50, 15);
			Product productTwo = new Product("tomato", 0.90, 25);
			Product productThree = new Product("bread", 1.10, 8);
			Storage storage = new Storage(50);

			storage.AddProduct(productOne);
			storage.AddProduct(productTwo);
			storage.AddProduct(productThree);
			Console.WriteLine(storage.GetProducts());
			Console.WriteLine(storage.Capacity);
			Console.WriteLine(storage.TotalCost);
		}
	}

	public class Storage 
	{ 
		public int Capacity { get; private set; }
		public List<Product> ProductList { get; private set; }

		public Storage(int capacity) 
		{
			Capacity = capacity;
			ProductList = new List<Product>();
		}

		public double TotalCost
		{
			get
			{
				double totalCost = 0;
				foreach (var product in ProductList)
				{
					totalCost += product.Price * product.Quantity;
				}
				return totalCost;
			}
		}

		public void AddProduct(Product product)
		{
            if (product.Quantity <= Capacity)
            {
				ProductList.Add(product);
				Capacity -= product.Quantity;
			}
            
		}

		public string GetProducts()
		{
			return JsonConvert.SerializeObject(ProductList, Formatting.Indented);
		}

	}

	public class Product
	{
		public string Name { get; set; }
		public double Price { get; set; }
		public int Quantity { get; set; }

		public Product(string name, double price, int quantity) 
		{
			Name = name;
			Price = price;
			Quantity = quantity;
		}
	}
}
