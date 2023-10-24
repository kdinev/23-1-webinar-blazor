using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Features.Pages;
using Features.Northwind;

namespace TestFeatures
{
	[Collection("Features")]
	public class TestCombo
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbInputModule),
				typeof(IgbComboModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule));
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			var componentUnderTest = ctx.RenderComponent<Combo>();
			Assert.NotNull(componentUnderTest);
		}
	}
}