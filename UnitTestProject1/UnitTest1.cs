using Microsoft.VisualStudio.TestTools.UnitTesting;
using testingDemo;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private readonly testingDemo.Program program;
        
        public UnitTest1()
        {
            program = new testingDemo.Program();
        }
        
        [TestMethod]
        public void TestMethod1()
        {
            int valOne = 5;
            int valTwo = 10;
            var result = program.add(valOne, valTwo);
            Assert.AreEqual(13, result);
        }
    }
}
