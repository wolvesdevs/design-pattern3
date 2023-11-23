namespace Rei01.Buhin.Data
{
    internal static class KaisouFake
    {
        internal static IEnumerable<KaisouEntity> GetData()
        {
            var result = new List<KaisouEntity>();
            result.Add(new KaisouEntity(10, 0, 1, 0, "AAA"));
            result.Add(new KaisouEntity(101, 10, 2, 1, "A1"));
            result.Add(new KaisouEntity(102, 10, 2, 1, "A2"));
            return result;
        }
    }
}
