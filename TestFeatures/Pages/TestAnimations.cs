using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Features.Pages;

namespace TestFeatures
{
	[Collection("Features")]
	public class TestAnimations
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbSnackbarModule),
				typeof(IgbRippleModule));
			var componentUnderTest = ctx.RenderComponent<Animations>();
			Assert.NotNull(componentUnderTest);
		}
	}
}