namespace DecisionTech.PriceCalculation.UnitTests
{
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;
	using Models;
	using Xunit;

	[Trait("Category", "UnitTests")]
	public class DiscountersTests
	{
		[Fact]
		public async Task ButterDiscounter_AppliesDiscount_Correctly()
		{
			var discounter = new Discounter
			{
				Product = "butter",
				QuantityNeeded = 1,
				DiscountOn = "bread",
				Discount = 50,
				DiscountType = DiscountType.Percentage
			};
			var butter = new Product
			{
				Name = "butter",
				Price = new Price { Amount = 0.80m },
				Quantity = 2
			};
			var bread = new Product
			{
				Name = "bread",
				Price = new Price { Amount = 1.00m },
				Quantity = 1
			};
			var products = new List<Product>
			{
				butter,
				bread
			};
			var receipt = new Receipt
			{
				Products = products,
				Total = products.Sum(p => p.Quantity * p.Price.Amount)
			};

			await discounter.ApplyDiscountAsync(receipt);

			Assert.Equal(receipt.Total, 2.10m);
		}

		[Fact]
		public async Task MilkDiscounter_AppliesDiscount_Correctly()
		{
			var discounter = new Discounter
			{
				Product = "milk",
				QuantityNeeded = 4,
				DiscountOn = "milk",
				Discount = 100,
				DiscountType = DiscountType.Percentage
			};
			var milk = new Product
			{
				Name = "milk",
				Price = new Price { Amount = 1.15m },
				Quantity = 8
			};
			var products = new List<Product> { milk };
			var receipt = new Receipt
			{
				Products = products,
				Total = products.Sum(p => p.Quantity * p.Price.Amount)
			};

			await discounter.ApplyDiscountAsync(receipt);

			Assert.Equal(receipt.Total, 6.90m);
		}
	}
}
