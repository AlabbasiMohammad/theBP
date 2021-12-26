using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1 : TestingSession
    {
        [TestMethod]
        public void TestMethod1()
        {
            wait.Until(e => e.FindElement(By.Name("q")).Displayed);
            element = wait.Until(e => e.FindElement(By.Name("q")));
            Assert.IsNotNull(element);
            element.SendKeys("mechanical engineering" + Keys.Enter);

            wait.Until(e => e.FindElement(By.Id("abar_button_opt")).Displayed);
            element = wait.Until(e => e.FindElement(By.Id("abar_button_opt")));
            element.Click();



        }




        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            SetUp(testContext);
        }



        [ClassCleanup]
        public static void ClassCleanup()
        {
            //TearDown();
        }

        [TestInitialize]
        public void TestInitialize()
        {
            driver.Navigate().GoToUrl(url_to_navigate);
            driver.Manage().Window.Maximize();

            wait.Until(e => e.FindElement(By.CssSelector("#L2AGLb")).Displayed);
            element = wait.Until(e => e.FindElement(By.CssSelector("#L2AGLb")));
            element.Click();
        }

        [TestCleanup]
        public void TestCleanup()
        {

        }


    }
}
