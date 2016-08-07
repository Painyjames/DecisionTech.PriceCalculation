namespace DecisionTech.PriceCalculation
{
	using Models;

	public class Calculator : ICalculator
	{
		public Receipt Calculate()
		{
			return new Receipt();
		}
	}
}
