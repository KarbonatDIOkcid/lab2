using NUnit.Framework;
using PageObject;
using SpecFlowProject.Steps;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class DeleteCustomersSteps : BaseSteps
    {
        private CustomersPage customersPage;
        List<string> actualListOfCustomers = new List<string>();
        List<string> expectedListOfCustomers = new List<string>();
        int expected;
        int actual;

        [Given(@"open XYZ Bank page")]
        public void GivenOpenXYZBankPage()
        {
            driver.Url = "https://www.globalsqa.com/angularJs-protractor/BankingProject";
            customersPage = new CustomersPage(driver);
        }

        [Given(@"click Bank Manager Login")]
        public void GivenClickBankManagerLogin()
        {
            customersPage.ClickBtnBankManagerLogin();
        }

        [Given(@"click on the Customers")]
        public void GivenClickOnTheCustomers()
        {
            customersPage.ClickBtnCustomers();
        }

        [When(@"delete the client by clicking on Delete")]
        public void WhenDeleteTheClientByClickingOnDelete()
        {
            expected = customersPage.lentghOfCustomer;
            customersPage.ClickBtnDelete();
            actual = customersPage.lentghOfCustomer;
        }

        [Then(@"the client is removed from the list")]
        public void ThenTheClientIsRemovedFromTheList()
        {
            Assert.AreNotEqual(expected, actual);
        }
    }
}
