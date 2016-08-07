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
		private Basket _basket;
		private Receipt _receipt;

		[Given("the basket has")]
		public void GivenTheBasketHas(Table table)
		{
			var products = table
				.Rows
				.Select(p => new Product {
					Quantity = Convert.ToInt32(p["Quantity"]),
					Name = p["Name"]
				});
			_basket = new Basket
			{
				Products = products.ToList()
			};
		}

		[When("I total the basket")]
		public void WhenITotalTheBasket()
		{
			var calculator = new Calculator();
			_receipt = calculator.Calculate(_basket);
		}

		[Then("the price should be (.*)")]
		public void ThenTheResultShouldBe(string price)
		{
			var priceAsDecimal = Convert.ToDecimal(price.Substring(1));
			Assert.Same(_receipt.Total, priceAsDecimal);
		}
	}
}
