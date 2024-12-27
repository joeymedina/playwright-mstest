using Microsoft.Playwright.MSTest;
using Microsoft.Playwright;
using System.Text.RegularExpressions;

namespace PlaywrightIssue
{
    [TestClass]
    public sealed class PlaywrightBrowserStackSampleTests : PageTest
    {
        [TestMethod]
        public async Task HasTitle()
        {
            await Page.GotoAsync("https://playwright.dev");

            await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));
        }

        [TestMethod]
        public async Task GetStartedLink()
        {
            await Page.GotoAsync("https://playwright.dev");

            await Page.GetByRole(AriaRole.Link, new() { Name = "Get started" }).ClickAsync();

            await Expect(Page.GetByRole(AriaRole.Heading, new() { Name = "Installation" })).ToBeVisibleAsync();
        }

    }
}
