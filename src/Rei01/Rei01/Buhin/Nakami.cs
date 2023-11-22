namespace Rei01.Buhin
{
    internal sealed class Nakami : IBuhin
    {
        public Nakami(string name, int level)
        {
            Name = name;
            Level = level;
        }

        public string Name { get; }
        public int Level { get; }

        public void Execute()
        {
            MessageBox.Show(Name);
        }

        public override string ToString()
        {
            return string.Concat(Enumerable.Repeat("+", Level)) + Name;
        }
    }
}
