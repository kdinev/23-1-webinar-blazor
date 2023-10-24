using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Features.Pages;

namespace TestFeatures
{
	[Collection("Features")]
	public class TestStepper
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbStepperModule),
				typeof(IgbExpansionPanelModule));
			var componentUnderTest = ctx.RenderComponent<Stepper>();
			Assert.NotNull(componentUnderTest);
		}
	}
}