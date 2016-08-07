namespace DecisionTech.PriceCalculation
{
	using System.Threading.Tasks;
	using Models;

	public interface ICalculator
	{
		Task<Receipt> Calculate(Basket basket);
	}
}
