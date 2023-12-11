using ファクトリーメソッド.Data;

namespace ファクトリーメソッド.Services
{
    public abstract class ProductService
    {
        public void dddd()
        {

        }

        protected abstract IProduct FactoryMethod(int kind);
    }
}
