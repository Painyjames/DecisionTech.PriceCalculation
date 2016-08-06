namespace DecisionTech.PriceCalculation.Specs
{
	using System.Collections.Generic;
	using System.Linq;
	using TechTalk.SpecFlow;

	[Binding]
	public sealed class PriceCalculationSteps
	{
		private List<Product> _products;

		[Given("the basket has")]
		public void GivenTheBasketHas(Table table)
		{
			_products = table
				.Rows
				.Select(p => new Product { Quantity = p["Quantity"], Name = p["Name"] });
		}

		[When("I total the basket")]
		public void WhenITotalTheBasket()
		{
			var calculator = new Calculator();

		}

		[Then("the price should be (.*)")]
		public void ThenTheResultShouldBe(string price)
		{
		}
	}
}
