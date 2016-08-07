namespace DecisionTech.PriceCalculation
{
	using System;
	using System.Collections.Concurrent;
	using Models;

	public class DiscounterFactory : IDiscounterFactory
	{
		private static readonly Lazy<ConcurrentDictionary<string, IDiscounter>> _discounters =
			new Lazy<ConcurrentDictionary<string, IDiscounter>>(() => new ConcurrentDictionary<string, IDiscounter>());

		public IDiscounter GetDiscounter(Product product)
		{
			IDiscounter discounter = null;
			if (!_discounters.Value.TryGetValue(product.Name, out discounter))
			{
				switch (product.Name)
				{
					case "milk":
						{
							discounter = new Discounter
							{
								Product = "milk",
								QuantityNeeded = 4,
								DiscountOn = "milk",
								Discount = 100,
								DiscountType = DiscountType.Percentage
							};
							break;
						}
					case "butter":
						{
							discounter = new Discounter
							{
								Product = "butter",
								QuantityNeeded = 2,
								DiscountOn = "bread",
								Discount = 50,
								DiscountType = DiscountType.Percentage
							};
							break;
						}
					default:
						break;
				}
				_discounters.Value.AddOrUpdate(product.Name, discounter, (k, o) => discounter);
			}
			return discounter;
		}
	}
}
