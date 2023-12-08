using アブストラクトファクトリー.Data;

namespace アブストラクトファクトリー.Factory
{
    public abstract class AbstractFactory
    {
        public abstract IProduct CreateProduct();
        public abstract IStock CreateStock();
    }
}
