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

            result.Add(new KaisouEntity(20, 0, 1, 0, "BBB"));
            result.Add(new KaisouEntity(201, 20, 2, 1, "B1"));
            result.Add(new KaisouEntity(202, 20, 2, 1, "B2"));

            result.Add(new KaisouEntity(30, 20, 2, 1, "CCC"));
            result.Add(new KaisouEntity(301, 30, 2, 2, "C1"));
            result.Add(new KaisouEntity(302, 30, 2, 2, "C2"));

            return result;
        }
    }
}
