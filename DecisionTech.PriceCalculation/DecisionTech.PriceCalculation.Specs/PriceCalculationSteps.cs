namespace DecisionTech.PriceCalculation.Specs
{
	using System;
	using System.Linq;
	using Models;
	using TechTalk.SpecFlow;
	using Xunit;

	[Binding]
	public sealed class PriceCalculationSteps
	{
		private static readonly DiscounterFactory _discounterFactory = new DiscounterFactory();
		private const string Basket = "Basket";
		private const string Receipt = "Receipt";

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
			var basket = new Basket
			{
				Products = products.ToList()
			};
			ScenarioContext.Current.Add(Basket, basket);
		}

		[When("I total the basket")]
		public void WhenITotalTheBasket()
		{
			var basket = (Basket)ScenarioContext.Current[Basket];
			var calculator = new Calculator(_discounterFactory);
			var task = calculator.Calculate(basket);
			task.Wait();
			var receipt = task.Result;
			ScenarioContext.Current.Add(Receipt, receipt);
		}

		[Then("the price should be (.*)")]
		public void ThenTheResultShouldBe(string price)
		{
			var receipt = (Receipt)ScenarioContext.Current[Receipt];
			var priceAsDecimal = Convert.ToDecimal(price.Substring(1));
			Assert.Equal(priceAsDecimal, receipt.Total);
		}
	}
}
