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

        }




        [ClassInitialize]
        public void ClassInitialize(TestContext testContext)
        {
            SetUp(testContext);
        }



        [ClassCleanup]
        public void ClassCleanup()
        {
            TearDown();
        }

        [TestInitialize]
        public void TestInitialize()
        {

        }

        [TestCleanup]
        public void TestCleanup()
        {

        }


    }
}
