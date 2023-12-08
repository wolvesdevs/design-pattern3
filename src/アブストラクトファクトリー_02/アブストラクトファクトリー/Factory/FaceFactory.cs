using アブストラクトファクトリー.Data;

namespace アブストラクトファクトリー.Factory
{
    internal sealed class FaceFactory : AbstractFactory
    {
        public override IProduct CreateProduct()
        {
            return new ProductFake();
        }

        public override IStock CreateStock()
        {
            return new StockFake();
        }
    }
}
