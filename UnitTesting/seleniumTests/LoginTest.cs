using Exercises.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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
        
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            wait.Until(d => d.FindElement(By.ClassName("call")).Displayed);    
            driver.FindElement(By.ClassName("call")).Click();

            driver.SwitchTo().DefaultContent();
            driver.FindElement(By.ClassName("ibm-profile-link")).Click();
            driver.FindElement(By.XPath("//li[@data-linktype='signin']/a")).Click();
            driver.FindElement(By.Id("username")).SendKeys(Constants.USERNAME);
            driver.FindElement(By.Id("continue-button")).Click();
            driver.FindElement(By.Id("password")).SendKeys(EncryptDecryptHelper.Decrypt(Constants.ENCODED_PASS));
            driver.FindElement(By.Id("signinbutton")).Click();
            
            #region test data helper
            //you cand use as IBMid (username): "doris.petrisoru@yahoo.com"
            //encrypted password: "YhRBMTukHZI8xTL4be7sD3yD98ulI+ZbwvlMowH7UEGFTpCt9ibMJ2DbUJWQlgtRRIlwzEjGUGwl4tg5KROdsJFecfuF/k/d8I7G/JXj3tAJcCsNIp9Wp1rIRC0mdbjf"
            //to decrypt pwd at run time use: EncryptDecryptHelper.Decrypt(encrypted_pwd);
            #endregion
        }
    }
}
