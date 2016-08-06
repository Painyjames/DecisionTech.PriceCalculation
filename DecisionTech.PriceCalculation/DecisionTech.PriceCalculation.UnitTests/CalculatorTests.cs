namespace DecisionTech.PriceCalculation.UnitTests
{
	using System.Collections.Generic;
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

			var receipt = calculator.Calculates();

			Assert.True(receipt.Total);
		}
	}
}
