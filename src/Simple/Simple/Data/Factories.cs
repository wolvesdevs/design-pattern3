namespace Simple.Data
{
    internal static class Factories
    {
        internal static IProduct CreateProduct(int kind)
        {
            if (kind == 0)
            {
                return new ProductFake();
            }

            if (kind == 1)
            {
                return new ProductSqlServer();
            }

            throw new ArgumentException("Invalid kind");
        }
    }
}
