using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Quiz2Selenium
{
    public class BasePage
    {
        

        public static IWebDriver driver;
        public static void Browser(string browser)

        {

            driver = new ChromeDriver();

        }
        public static void OpenUrl(string url)

        {

            driver.Url = url;

        }
        public static void Write(By by, string value)

        {

            driver.FindElement(by).SendKeys(value);

        }
        public void Click(By by)

        {

            driver.FindElement(by).Click();

        }
        public void maxwindow()
        {
            driver.Manage().Window.Maximize();
        }
        public void Selectdrop(By by, String value)
        {
            IWebElement dropdown = driver.FindElement(by);
            SelectElement dropdownmenu = new SelectElement(dropdown);
            dropdownmenu.SelectByValue(value);
        }
        public void hoverhandle(By by)
        {
            Actions hover = new Actions(driver);
            hover.MoveToElement(driver.FindElement(by)).Build().Perform();
            driver.FindElement(by).Click();
        }
        public void AssertionVerify(By by)
        {
            IWebElement element = driver.FindElement(by);
            bool status = element.Displayed;
            Assert.AreEqual(status, true);
        }
        public void scrollelement1(By by)
        {
            var scrollement = driver.FindElement(by);

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", scrollement);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", by);

        }
    }
}