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
		private static readonly DiscounterFactory _discounterFactory = new DiscounterFactory();

		[Given("the basket has")]
		public void GivenTheBasketHas(Table table)
		{
			var products = table
				.Rows
				.Select(p => new Product {
					Quantity = Convert.ToInt32(p["Quantity"]),
					Name = p["Name"],
					Price = new Price
					{
						Amount = Convert.ToDecimal(p["Price"])
					}
				});
			_basket = new Basket
			{
				Products = products.ToList()
			};
		}

		[When("I total the basket")]
		public async void WhenITotalTheBasket()
		{
			var calculator = new Calculator(_discounterFactory);
			_receipt = await calculator.Calculate(_basket);
		}

		[Then("the price should be (.*)")]
		public void ThenTheResultShouldBe(string price)
		{
			var priceAsDecimal = Convert.ToDecimal(price.Substring(1));
			Assert.Equal(priceAsDecimal, _receipt.Total);
		}
	}
}
