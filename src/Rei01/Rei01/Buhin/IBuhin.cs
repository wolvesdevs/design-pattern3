namespace Rei01.Buhin
{
    internal interface IBuhin
    {
        string Name { get; }
        int Level { get; }

        void Execute();
    }
}
