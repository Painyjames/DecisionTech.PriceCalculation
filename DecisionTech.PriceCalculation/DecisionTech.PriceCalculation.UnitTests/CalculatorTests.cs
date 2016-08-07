namespace DecisionTech.PriceCalculation.UnitTests
{
	using System.Collections.Generic;
	using System.Threading.Tasks;
	using Models;
	using Moq;
	using Xunit;

	[Trait("Category", "UnitTests")]
	public class CalculatorTests
	{
		[Fact]
		public async void Calculator_CalculatesPrices_Correctly()
		{
			var discounterFactory = new Mock<IDiscounterFactory>();
			var calculator = new Calculator(discounterFactory.Object);
			var products = new List<Product>()
			{
				new Product { Name = "milk", Quantity = 1, Price = new Price { Amount = 1.15m } },
				new Product { Name = "bread", Quantity = 1, Price = new Price { Amount = 1.00m } }
			};
			var basket = new Basket
			{
				Products = products
			};
			discounterFactory
				.Setup(f => f.GetDiscounter(It.IsAny<Product>()))
				.Returns<IDiscounter>(null);

			var receipt = await calculator.Calculate(basket);

			Assert.True(receipt.Total == 2.15m);
		}

		[Fact]
		public async void Calculator_CalculatesPricesWithDiscount_Correctly()
		{
			var butterDiscounter = new Mock<IDiscounter>();
			var discounterFactory = new Mock<IDiscounterFactory>();
			var calculator = new Calculator(discounterFactory.Object);
			var butter = new Product { Name = "butter", Quantity = 2, Price = new Price { Amount = 0.80m } };
			var bread = new Product { Name = "bread", Quantity = 1, Price = new Price { Amount = 1.00m } };
			var products = new List<Product>()
			{
				butter,
				bread
			};
			var basket = new Basket
			{
				Products = products
			};
			discounterFactory
				.Setup(f => f.GetDiscounter(It.Is<Product>(p => p.Name == "butter")))
				.Returns(butterDiscounter.Object);
			discounterFactory
				.Setup(f => f.GetDiscounter(It.Is<Product>(p => p.Name == "bread")))
				.Returns<IDiscounter>(null);
			butterDiscounter
				.Setup(d => d.ApplyDiscountAsync(It.IsAny<Receipt>()))
				.Callback((Receipt r) =>
				{
					r.Total -= bread.Price.Amount / 2;
				})
				.Returns(Task.Delay(0));

			var receipt = await calculator.Calculate(basket);

			Assert.Equal(receipt.Total, 2.10m);
			butterDiscounter.Verify();
			discounterFactory.Verify();
		}
	}
}
