using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day20_Ms_Test_UserRegistration;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Program program;

        public UnitTest1()
        {
            program = new Program();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var result = program.FirstNameInput("Tejas");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var result = program.LastNameInput("Sonar");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var result = program.EmailInput("sonartejas908@gmail.com");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var result = program.MobileInput("91 8668454516");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestMethod5()
        {
            var result = program.PasswordInput("Tejas@123");
            Assert.AreEqual(true, result);
        }
    }
}
