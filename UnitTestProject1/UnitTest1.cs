using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prototypes1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MyFunctions reverseOp = new MyFunctions();

            string revString = reverseOp.ReverseString("abcd");
        }
    }
}
