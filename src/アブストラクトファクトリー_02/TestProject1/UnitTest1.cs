using Moq;
using System.Diagnostics;
using アブストラクトファクトリー;
using アブストラクトファクトリー.Data;
using アブストラクトファクトリー.Factory;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //var factoryMock = new FacoryMock();
            var factoryMock = new Mock<AbstractFactory>();
            var productMock = new Mock<IProduct>();

            factoryMock.Setup(x => x.CreateProduct()).Returns(productMock.Object);
            productMock.Setup(x => x.GetData()).Returns("AAABBB");

            var vm = new Form1ViewModel(factoryMock.Object);
            Assert.AreEqual("--", vm.Label1Text);

            vm.GetButtonClick();
            Assert.AreEqual("AAABBBdesu", vm.Label1Text);
        }
    }

    //internal sealed class FacoryMock : AbstractFactory
    //{
    //    public override IProduct CreateProduct()
    //    {
    //        return new ProductMock();
    //    }

    //    public override IStock CreateStock()
    //    {
    //        return new StockMock();
    //    }
    //}

    //internal sealed class ProductMock : IProduct
    //{
    //    public string GetData()
    //    {
    //        return "AAABBB";
    //    }
    //}

    //internal sealed class StockMock : IStock
    //{
    //    public int GetStock()
    //    {
    //        return 1;
    //    }
    //}
}