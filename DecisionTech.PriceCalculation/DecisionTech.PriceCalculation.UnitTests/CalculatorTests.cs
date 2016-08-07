namespace DecisionTech.PriceCalculation.UnitTests
{
	using System.Collections.Generic;
	using Models;
	using Xunit;

	[Trait("Category", "UnitTests")]
	public class CalculatorTests
	{
		[Fact]
		public void Calculator_CalculatesPrices_Correctly()
		{
			var calculator = new Calculator();
			var products = new List<Product>()
			{
				new Product { Name = "milk", Quantity = 1 },
				new Product { Name = "bread", Quantity = 1 }
			};
			var basket = new Basket
			{
				Products = products
			};

			var receipt = calculator.Calculate(basket);

			Assert.True(receipt.Total == 2.15m);
		}
	}
}
