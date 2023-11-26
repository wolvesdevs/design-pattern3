namespace Rei01.Buhin
{
    internal interface IBuhin
    {
        int Id { get; }
        int ParentId { get; }
        string Name { get; }
        int Level { get; }

        void Execute();
        void Add(IBuhin buhin);
    }
}
