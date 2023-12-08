namespace AbstractF.Data
{
    internal sealed class StockFake : IStock
    {
        public int GetStock()
        {
            return 10;
        }
    }
}
