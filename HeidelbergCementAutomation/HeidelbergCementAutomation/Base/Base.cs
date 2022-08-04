using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;

namespace HeidelbergCementAutomation.Base
{
    public class Base
    {
        public WebDriverWait wait;
        public IWebDriver driver;

        #region General Actions

        public void BrowserStart()
        {
            driver = new EdgeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void Wait(int waitTime)
        {
            Thread.Sleep(waitTime);
        }

        public void MaximaseWindow()
        {
            driver.Manage().Window.Maximize();
        }

        public void BrowserClose()
        {
            driver.Quit();
        }

        #endregion
    }
}
