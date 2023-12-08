using アブストラクトファクトリー.Data;

namespace アブストラクトファクトリー.Factory
{
    internal sealed class SqlServerFactory : AbstractFactory
    {
        public override IProduct CreateProduct()
        {
            return new ProductSqlServer();
        }

        public override IStock CreateStock()
        {
            return new StockSqlServer();
        }
    }
}
