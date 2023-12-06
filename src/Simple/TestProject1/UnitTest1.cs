using Simple;
using Simple.Data;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mock = new ProductMock();
            var vm = new Form1ViewModel(mock);
            Assert.AreEqual("--", vm.Label1Text);

            vm.GetButtonClick();
            Assert.AreEqual("AAABBBdesu", vm.Label1Text);
        }
    }

    internal sealed class ProductMock : IProduct
    {
        public string GetData()
        {
            return "AAABBB";
        }
    }
}