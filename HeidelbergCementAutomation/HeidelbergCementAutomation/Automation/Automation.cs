using HeidelbergCementAutomation.Base;
using NUnit.Framework;

namespace HeidelbergCementAutomation.Automations
{
    public class Automations : Shares
    {
        [OneTimeSetUp]
        public void BrowserStartAutomation()
        {
            BrowserStart();
            NavigateTo("https://www.heidelbergcement.com/en");
            Wait(3000);
            MaximaseWindow();
        }

        [Test, Order(1)]
        [Category("Home Actions")]
        public void HomeActionsAutomation()
        {
            HomeActions();
        }

        [Test, Order(2)]
        [Category("Home Validations")]
        public void HomeValidationAutomation()
        {
            HomeValidation();
        }

        [Test, Order(3)]
        [Category("Home Results")]
        public void HomeResultsAutomation()
        {
            HomeResults();
        }

        [Test, Order(4)]
        [Category("Shares Actions")]
        public void ShareActionsAutomation()
        {
            SharesActions();
        }

        [Test, Order(5)]
        [Category("Shares Validations")]
        public void ShareVlidationAutomation()
        {
            SharesVlidation();
        }

        [Test, Order(6)]
        [Category("Shares Results")]
        public void ShareResultsAutomation()
        {
            SharesResults();
        }

        [OneTimeTearDown]
        public void BrowserCloseAutomation()
        {
            BrowserClose();
        }
    }
}