using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Features.Pages;
using Features.Financial;

namespace TestFeatures
{
	[Collection("Features")]
	public class TestPivot_Grid
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbPivotDataSelector));
			ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
			var componentUnderTest = ctx.RenderComponent<Pivot_Grid>();
			Assert.NotNull(componentUnderTest);
		}
	}
}