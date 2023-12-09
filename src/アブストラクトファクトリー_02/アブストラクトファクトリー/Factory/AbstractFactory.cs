using アブストラクトファクトリー.Data;

namespace アブストラクトファクトリー.Factory
{
    public abstract class AbstractFactory
    {
        public abstract IProduct CreateProduct();
        public abstract IStock CreateStock();

        public static AbstractFactory Create(int kind)
        {
            switch (kind)
            {
                case 0:
#if DEBUG
#else
                    throw new ArgumentException("リリースモードでFakeは使えません");
#endif
                    return new FaceFactory();
                case 1:
                    return new SqlServerFactory();
                default:
                    throw new ArgumentException("kindがおかしい");
            }
        } 

    }
}
