using OpenQA.Selenium;
using NUnit.Framework;


namespace HeidelbergCementAutomation.Base
{
    public class Shares : Home
    {
        #region Shares Page Selectors

        public IWebElement earningPerShare => driver.FindElement(By.XPath("/html/body/div[1]/div/div/main/div/div[2]/section/div[2]/div/div/div/div/nav/ul/li[2]/a"));
        public IWebElement sharePageTitle => driver.FindElement(By.XPath("/html/body/div[1]/div/div/main/div/div[2]/section/div[2]/div/div/h1"));
        public IWebElement sharePageText => driver.FindElement(By.XPath("/html/body/div[1]/div/div/main/div/div[3]/article/div/section/div[1]/div/div/div/div/div/p"));
        public IWebElement groupShare => driver.FindElement(By.XPath("/html/body/div[1]/div/div/main/div/div[3]/article/div/section/div/div/div[1]/div/div/div/div/table/tbody/tr[2]/td[3]/p/strong"));
        public IWebElement numberOfShares => driver.FindElement(By.XPath("/html/body/div[1]/div/div/main/div/div[3]/article/div/section/div/div/div[1]/div/div/div/div/table/tbody/tr[3]/td[3]/p/strong"));
        public IWebElement earingsPerShare => driver.FindElement(By.XPath("/html/body/div[1]/div/div/main/div/div[3]/article/div/section/div/div/div[1]/div/div/div/div/table/tbody/tr[4]/td[3]/p/strong"));

        #endregion

        #region Shares Page Actions

        public void SharesActions()
        {
            earningPerShare.Click();
        }

        public void SharesVlidation()
        {
            Assert.That(driver.Title.Contains("Earnings"));
            Assert.That(sharePageTitle.Text.Contains("Earnings per share"));
            Assert.That(sharePageText.Text.Contains("HeidelbergCement"));
        }

        public void SharesResults()
        {
            TestContext.WriteLine(driver.Url);
            TestContext.WriteLine(sharePageTitle.Text);
            TestContext.WriteLine(sharePageText.Text);
            TestContext.WriteLine("Group share of profit in €m for 2021 " + groupShare.Text);
            TestContext.WriteLine("Number of shares in ’000s (weighted average) for 2021 " + numberOfShares.Text);
            TestContext.WriteLine("Earnings per share in € for 2021 " + earingsPerShare.Text);
        }

        #endregion
    }
}
