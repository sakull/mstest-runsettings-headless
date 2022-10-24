using Microsoft.Playwright.MSTest;
using Microsoft.Playwright.TestAdapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PlaywrightTests
{
    [TestClass]
    public class RunsettingsTests : PageTest
    {
        [TestMethod]
        public void HeadlessIsSetFromRunsettingsFile()
        {
            var headless = PlaywrightSettingsProvider.LaunchOptions.Headless;

            Assert.IsFalse(headless);
        }
    }
}