using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTests
{
    [TestClass]
    public class Basic
    {
        static IWebDriver globalDriver_UT;
        
        // ***
        // Stand alone unit tests. 
        // ***
        [AssemblyInitialize]
        public static void StartDriver(TestContext context)
        {
           globalDriver_UT = new ChromeDriver(@"C:\Users\Frank\Documents\Visual Studio 2017\Projects\Transavia\Transavia\bin\Debug\");
        }

        [TestMethod]
        public void NavigateToHomePage()
        {
            globalDriver_UT.Navigate().GoToUrl("https://www.transavia.com/nl-NL/home/");
        }

        [TestMethod]
        public void StopDriver()
        {
            globalDriver_UT.Quit();
        }
    }

    public static class SF
    {
        // ***
        // Unit tests that can be called by SpecFlow.
        // ***

        // Start.
        public static IWebDriver StartDriver_SF()
        {
            return new ChromeDriver(@"C:\Users\Frank\Documents\Visual Studio 2017\Projects\Transavia\Transavia\bin\Debug\");
        }

        // Navigate.
        public static void NavigateToUrl_SF(IWebDriver driver, String url)
        {
            driver.Navigate().GoToUrl(url);
        }

        // Stop.
        public static void StopDriver_SF(IWebDriver driver)
        {
            driver.Quit();
        }

        // Input field.
        public static void SendKeysToElementById_SF(IWebDriver driver, String id, String value)
        {
            driver.FindElement(By.Id(id)).SendKeys(value);
        }

        // Input field. Clear first.
        public static void ClearAndSendKeysToElementById_SF(IWebDriver driver, String id, String value)
        {
            driver.FindElement(By.Id(id)).Clear();
            driver.FindElement(By.Id(id)).SendKeys(value);
        }

        // Input field, via JS.
        public static void SetValueElementById_SF(IWebDriver driver, String id, String value)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            string result = (string)js.ExecuteScript("window.document.getElementById('" + id + "').setAttribute('value', '" + value + "'); element.blur();");
        }

        // Any element.
        public static void ClickElementById_SF(IWebDriver driver, String id)
        {
            driver.FindElement(By.Id(id)).Click();
        }
        
        // Any element.
        public static void ClickElementByXPath_SF(IWebDriver driver, String XPath)
        {
            driver.FindElement(By.XPath(XPath)).Click();
        }

        // Check box.
        public static bool CheckBoxIsCheckedById_SF(IWebDriver driver, String id)
        {
            return driver.FindElement(By.Id(id)).Selected;
        }

        // Get page header text.
        public static string GetElementTextByXPath_SF(IWebDriver driver, String XPath)
        {
            return driver.FindElement(By.XPath(XPath)).Text;
        }
    }
}
