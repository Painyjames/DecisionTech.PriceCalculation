namespace DecisionTech.PriceCalculation
{
	using Models;

	public interface IDiscounterFactory
	{
		IDiscounter GetDiscounter(Product product);
	}
}
