using Microsoft.Playwright.MSTest;

namespace LetCodeInEdit;

[TestClass]
public class LetCodeInEdit : PageTest
{
    [TestMethod]
    public async Task UserCanClickTheEditButton()
    {
        await Page.GotoAsync("https://letcode.in/test");

        await Page.ClickAsync("text=Edit");

        await Expect(Page.GetByText("Input")).ToBeVisibleAsync();
    }
}
