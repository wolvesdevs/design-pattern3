namespace Simple.Data
{
    internal sealed class ProductSqlServer : IProduct
    {
        public string GetData()
        {
            return "SQL Server";
        }
    }
}
