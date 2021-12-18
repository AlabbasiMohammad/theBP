using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1 : TestingSession
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine();
        }




        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            SetUp(testContext);
        }



        [ClassCleanup]
        public static void ClassCleanup()
        {
            TearDown();
        }

        [TestInitialize]
        public void TestInitialize()
        {
            driver.Navigate().GoToUrl(url_to_navigate);
            driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void TestCleanup()
        {

        }


    }
}
