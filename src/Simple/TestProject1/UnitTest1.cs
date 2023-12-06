using Simple;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var vm = new Form1ViewModel();
            Assert.AreEqual("defualt1", vm.Label1Text);

            vm.GetButtonClick();
            Assert.AreEqual("fake!!", vm.Label1Text);
        }
    }
}