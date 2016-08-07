namespace DecisionTech.PriceCalculation.Specs
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Models;
	using TechTalk.SpecFlow;
	using Xunit;

	[Binding]
	public sealed class PriceCalculationSteps
	{
		private IEnumerable<Product> _products;
		private Receipt _receipt;

		[Given("the basket has")]
		public void GivenTheBasketHas(Table table)
		{
			_products = table
				.Rows
				.Select(p => new Product {
					Quantity = Convert.ToInt32(p["Quantity"]),
					Name = p["Name"]
				});
		}

		[When("I total the basket")]
		public void WhenITotalTheBasket()
		{
			var calculator = new Calculator();
			_receipt = calculator.Calculate();
		}

		[Then("the price should be (.*)")]
		public void ThenTheResultShouldBe(string price)
		{
			var priceAsDecimal = Convert.ToDecimal(price.Substring(1));
			Assert.Same(_receipt.Total, priceAsDecimal);
		}
	}
}
