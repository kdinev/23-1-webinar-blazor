using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Features.Pages;

namespace TestFeatures
{
	[Collection("Features")]
	public class TestOverview
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbListModule),
				typeof(IgbAvatarModule));
			var componentUnderTest = ctx.RenderComponent<Overview>();
			Assert.NotNull(componentUnderTest);
		}
	}
}