using ファクトリーメソッド.Data;

namespace ファクトリーメソッド.Services
{
    public abstract class ProductService
    {
        public IProduct Create()
        {
            var product = FactoryMethod(Program.Kind);

            if (product.GetValidDate() < DateTime.Now)
            {
                throw new Exception("無効な製品です");
            }

            return product;
        }

        public abstract IProduct FactoryMethod(int kind);
    }
}
