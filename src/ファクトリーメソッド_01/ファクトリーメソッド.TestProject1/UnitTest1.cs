using Moq;
using ファクトリーメソッド;
using ファクトリーメソッド.Data;
using ファクトリーメソッド.Services;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var serviceMock = new Mock<ProductService>();
            var productMock = new Mock<IProduct>();

            productMock.Setup(x => x.GetValidDate()).Returns(DateTime.Now.AddHours(1));
            productMock.Setup(x => x.GetData()).Returns("AAABBB");
            serviceMock.Setup(x => x.FactoryMethod(0)).Returns(productMock.Object);

            var vm = new Form1ViewModel(serviceMock.Object);
            Assert.AreEqual("--", vm.Label1Text);

            vm.GetButtonClick();
            Assert.AreEqual("AAABBBdesu", vm.Label1Text);
        }
    }
}