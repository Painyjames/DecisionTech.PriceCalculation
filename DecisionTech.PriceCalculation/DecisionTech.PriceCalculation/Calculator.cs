namespace DecisionTech.PriceCalculation
{
	using System.Linq;
	using Models;

	public class Calculator : ICalculator
	{
		public Receipt Calculate(Basket basket)
		{
			var receipt =  new Receipt();

			receipt.Products = basket.Products;
			receipt.Total = receipt
				.Products
				.Sum(p => p.Price.Amount * p.Quantity);

			return receipt;
		}
	}
}
