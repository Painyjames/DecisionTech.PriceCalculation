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
		public void Calculator_CalculatesPrices_Correctly()
		{
			var discounterFactory = new Mock<IDiscounterFactory>();
			var calculator = new Calculator(discounters);
			var products = new List<Product>()
			{
				new Product { Name = "milk", Quantity = 1, Price = new Price { Amount = 1.15m } },
				new Product { Name = "bread", Quantity = 1, Price = new Price { Amount = 1.00m } }
			};
			var basket = new Basket
			{
				Products = products
			};

			var receipt = calculator.Calculate(basket);

			Assert.True(receipt.Total == 2.15m);
		}

		[Fact]
		public void Calculator_CalculatesPricesWithDiscount_Correctly()
		{
			var butterDiscounter = new Mock<IDiscounter>();
			var discounterFactory = new Mock<IDiscounterFactory>();
			var calculator = new Calculator(discounters);
			var butter = new Product { Name = "butter", Quantity = 2, Price = new Price { Amount = 1.15m } };
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
				.Setup(f => f.GetDiscounterAsync(It.Is<Product>(p => p.Name == "butter")))
				.Returns(Task.FromResult(butterDiscounter.Object));
			discounterFactory
				.Setup(f => f.GetDiscounterAsync(It.Is<Product>(p => p.Name == "bread")))
				.Returns(Task.FromResult<IDiscounter>(null));
			butterDiscounter
				.Setup(d => d.ApplyDiscountAsync(It.IsAny<Receipt>()))
				.Callback((Receipt r) =>
				{
					r.Total -= butter.Price.Amount / 2;
				});

			var receipt = calculator.Calculate(basket);

			Assert.True(receipt.Total == 2.20m);
			butterDiscounter.Verify();
			discounterFactory.Verify();
		}
	}
}
