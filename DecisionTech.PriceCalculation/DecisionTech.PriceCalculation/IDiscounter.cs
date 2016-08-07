namespace DecisionTech.PriceCalculation
{
	using System.Threading.Tasks;
	using Models;

	public interface IDiscounter
	{
		string Product { get; }

		int QuantityNeeded { get; }

		string DiscountOn { get; }

		decimal Discount { get; }

		DiscountType DiscountType { get; }

		bool IsSatisfiedBy(Product product, Product productWithDiscount);

		Task ApplyDiscountAsync(Receipt receipt);
	}
}
