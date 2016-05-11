using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using SimpleBrowser.WebDriver;

namespace UnitTests.Tests
{
    [TestFixture]
    class FirstTest
    {
        [Test]
        public void OpenBrowser()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://seleniumsimplified.com/");

            driver.Close();
            driver.Quit();
        }

        [Test]
        public void OpenBrowserBySimpleBrowser()
        {
            IWebDriver driver = new SimpleBrowserDriver();
            driver.Navigate().GoToUrl("http://seleniumsimplified.com/");

            driver.Close();
            driver.Quit();
        }



    }
}
