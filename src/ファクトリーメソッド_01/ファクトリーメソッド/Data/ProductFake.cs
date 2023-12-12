namespace ファクトリーメソッド.Data
{
    internal sealed class ProductFake : IProduct
    {
        public string GetData()
        {
            return "fake!!";
        }

        public DateTime GetValidDate()
        {
            return Convert.ToDateTime("2022/01/01");
        }
    }
}