namespace Rei02.Data
{
    internal sealed class KaisouEntity
    {
        public KaisouEntity(
          int id, int parentId, int kind, string name)
        {
            Id = id;
            ParentId = parentId;
            Kind = kind;
            Name = name;
        }

        public int Id { get; }
        public int ParentId { get; }
        public int Kind { get; }
        public string Name { get; }
    }
}
