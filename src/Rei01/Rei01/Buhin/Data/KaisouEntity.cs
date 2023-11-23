namespace Rei01.Buhin.Data
{
    internal sealed class KaisouEntity
    {
        public KaisouEntity(int id, int parentId, int kind, int level, string name)
        {
            Id = id;
            ParentId = parentId;
            Kind = kind;
            Level = level;
            Name = name;
        }

        public int Id { get; }
        public int ParentId { get; }
        public int Kind { get; }
        public int Level { get; }
        public string Name { get; }
    }
}
