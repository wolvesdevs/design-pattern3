using �A�u�X�g���N�g�t�@�N�g���[;
using �A�u�X�g���N�g�t�@�N�g���[.Data;

namespace TestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      var mock = new ProductMock();
      var stockMock = new StockMock();
      var vm = new Form1ViewModel(mock, stockMock);
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

  internal sealed class StockMock : IStock
  {
    public int GetStock()
    {
      return 1;
    }
  }
}