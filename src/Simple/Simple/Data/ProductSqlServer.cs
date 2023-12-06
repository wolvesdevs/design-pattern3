namespace Simple.Data
{
    public sealed class ProductSqlServer : IProduct
    {
        public string GetData()
        {
            return "SQL Server";
        }
    }
}
