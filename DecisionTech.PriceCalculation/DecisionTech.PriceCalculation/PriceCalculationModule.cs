namespace DecisionTech.PriceCalculation
{
	using Autofac;

	public class PriceCalculationModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder
				.RegisterType<Calculator>()
				.AsImplementedInterfaces()
				.SingleInstance();

			builder
				.RegisterType<DiscounterFactory>()
				.AsImplementedInterfaces()
				.SingleInstance();
		}
	}
}
