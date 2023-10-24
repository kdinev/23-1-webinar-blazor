using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Features.Pages;
using Features.Northwind;

namespace TestFeatures
{
	[Collection("Features")]
	public class TestExport_Summaries
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbGridModule),
				typeof(IgbDataGridToolbarModule));
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			var componentUnderTest = ctx.RenderComponent<Export_Summaries>();
			Assert.NotNull(componentUnderTest);
		}
	}
}