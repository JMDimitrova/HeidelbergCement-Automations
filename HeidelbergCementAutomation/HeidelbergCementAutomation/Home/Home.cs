using NUnit.Framework;
using OpenQA.Selenium;


namespace HeidelbergCementAutomation.Base
{
    public class Home : Base
    {
        #region Home Page Selectors

        public IWebElement menu => driver.FindElement(By.XPath("/html/body/div[1]/div/div/header/div[1]/div[2]/button[3]"));
        public IWebElement investorRelations => driver.FindElement(By.XPath("/html/body/div[1]/div/div/header/div[2]/div/nav/ul/li[5]/button"));
        public IWebElement share => driver.FindElement(By.XPath("/html/body/div[1]/div/div/header/div[2]/div/nav/ul/li[5]/div/ul/li[4]/a"));

        #endregion

        #region Home Page Actions

        public void HomeActions()
        {
            wait.Until(e => menu.Displayed);
            menu.Click();
            wait.Until(e => investorRelations.Displayed);
            investorRelations.Click();
            wait.Until(e => share.Displayed);
            share.Click();
        }

        public void HomeValidation()
        {
            Assert.That(driver.Title.Contains("HeidelbergCement"));
        }

        public void HomeResults()
        {
            TestContext.WriteLine(driver.Url);
            TestContext.WriteLine(driver.PageSource);
        }

        #endregion
    }
}
