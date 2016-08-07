namespace DecisionTech.PriceCalculation
{
	using Models;

	public interface ICalculator
	{
		Receipt Calculate(Basket basket);
	}
}
