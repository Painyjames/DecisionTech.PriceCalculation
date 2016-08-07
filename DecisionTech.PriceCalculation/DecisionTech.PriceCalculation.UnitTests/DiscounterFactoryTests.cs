namespace DecisionTech.PriceCalculation.UnitTests
{
	using Models;
	using Xunit;

	[Trait("Category", "UnitTests")]
	public class DiscounterFactoryTests
	{
		[Fact]
		public void DiscounterFactory_GetsDiscounterForButter_WithCorrectValues()
		{
			var factory = new DiscounterFactory();
			var product = new Product { Name = "butter" };

			var discounter = factory.GetDiscounter(product);

			Assert.Equal(discounter.Product, "butter");
			Assert.Equal(discounter.QuantityNeeded, 2);
			Assert.Equal(discounter.DiscountOn, "bread");
			Assert.Equal(discounter.Discount, 50);
			Assert.Equal(discounter.DiscountType, DiscountType.Percentage);
		}

		[Fact]
		public void DiscounterFactory_GetsDiscounterForMilk_WithCorrectValues()
		{
			var factory = new DiscounterFactory();
			var product = new Product { Name = "milk" };

			var discounter = factory.GetDiscounter(product);

			Assert.Equal(discounter.Product, "milk");
			Assert.Equal(discounter.QuantityNeeded, 4);
			Assert.Equal(discounter.DiscountOn, "milk");
			Assert.Equal(discounter.Discount, 100);
			Assert.Equal(discounter.DiscountType, DiscountType.Percentage);
		}
	}
}
