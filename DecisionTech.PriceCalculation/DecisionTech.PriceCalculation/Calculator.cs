namespace DecisionTech.PriceCalculation
{
	using Models;

	public class Calculator : ICalculator
	{
		public Receipt Calculate(Basket basket)
		{
			return new Receipt();
		}
	}
}
