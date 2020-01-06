using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace UnitTesting.seleniumTests
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void TC01_NavigateToIbmSite()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://www.ibm.com/ro-en");
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[contains(@id, 'pop-frame')]")));
            driver.FindElement(By.ClassName("call")).Click();
        }
    }
}
