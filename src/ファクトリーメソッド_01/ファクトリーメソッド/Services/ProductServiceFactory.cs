using ファクトリーメソッド.Data;

namespace ファクトリーメソッド.Services
{
    internal sealed class ProductServiceFactory : ProductService
    {
        protected override IProduct FactoryMethod(int kind)
        {
            if (kind == 0)
            {
                return new ProductFake();
            }

            if (kind == 1)
            {
                return new ProductSqlServer();
            }

            throw new ArgumentException("kindがおかしい");
        }
    }
}
