using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
namespace UnitTestProject1
{
    public class TestingSession
    {

        protected static IWebDriver driver;
        protected static IWebElement element;
        protected static WebDriverWait wait;

        protected const string url_to_navigate = @"https://www.google.com";

        public static void SetUp(TestContext testContext)
        {

            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, timeout: TimeSpan.FromSeconds(25));

        }



        public static void TearDown()
        {
            driver.Close();
            driver.Quit();

        }


    }
}
