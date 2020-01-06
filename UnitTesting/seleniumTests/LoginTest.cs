using Exercises.Helpers;
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

            #region test data helper
            //you cand use as IBMid (username): "doris.petrisoru@yahoo.com"
            //encrypted password: "YhRBMTukHZI8xTL4be7sD3yD98ulI+ZbwvlMowH7UEGFTpCt9ibMJ2DbUJWQlgtRRIlwzEjGUGwl4tg5KROdsJFecfuF/k/d8I7G/JXj3tAJcCsNIp9Wp1rIRC0mdbjf"
            //decyption key: "tESTaUTOMATION"
            //to decrypt pwd at run time use: EncryptDecryptHelper.Decrypt(encrypted_pwd, key);
            #endregion
        }
    }
}
