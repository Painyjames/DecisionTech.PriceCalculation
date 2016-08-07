namespace DecisionTech.PriceCalculation.UnitTests
{
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;
	using Models;
	using Xunit;

	[Trait("Category", "UnitTests")]
	class DiscounterFactoryTests
	{
		[Fact]
		public async Task DiscounterFactory_GetsDiscounterForButter_WithCorrectValues()
		{
			var factory = new DiscounterFactory();
			var product = new Product { Name = "milk" };

			var discounter = await factory.GetDiscounterAsync(product);

			Assert.Same(discounter.Product, "butter");
			Assert.Same(discounter.QuantityNeeded, 1);
			Assert.Same(discounter.DiscountOn, "bread");
			Assert.Same(discounter.Discount, 50);
			Assert.Same(discounter.DiscountType, DiscountType.Percentage);
		}

		[Fact]
		public async Task DiscounterFactory_GetsDiscounterForMilk_WithCorrectValues()
		{
			var factory = new DiscounterFactory();
			var product = new Product { Name = "milk" };

			var discounter = await factory.GetDiscounterAsync(product);

			Assert.Same(discounter.Product, "milk");
			Assert.Same(discounter.QuantityNeeded, 4);
			Assert.Same(discounter.DiscountOn, "milk");
			Assert.Same(discounter.Discount, 100);
			Assert.Same(discounter.DiscountType, DiscountType.Percentage);
		}
	}
}
