using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace PageObject
{
    public class CustomersPage:BasePage
    {
        private static WebDriverWait wait;
        public CustomersPage(IWebDriver webDriver):base(webDriver)
        {
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }

        private IWebElement btnBankManagerLogin => wait.Until(ExpectedConditions.ElementExists((By.XPath("//button[contains(text(),'Bank Manager Login')]"))));

        public void ClickBtnBankManagerLogin() => btnBankManagerLogin.Click();

        private IWebElement btnCustomers => wait.Until(ExpectedConditions.ElementExists(By.XPath("//button[contains(text(),'Customers')]")));

        public void ClickBtnCustomers() => btnCustomers.Click();
        private IWebElement BtnDelete => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div/table/tbody/tr[1]/td[5]/button"))); 
        public void ClickBtnDelete() => BtnDelete.Click();
        public int lentghOfCustomer => driver.FindElements(By.XPath("//tbody/tr[@class='ng-scope']")).ToList<IWebElement>().Count;
    }
}
