namespace Rei01.Buhin
{
    internal sealed class Nakami : IBuhin
    {
        public Nakami(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void Execute()
        {
            MessageBox.Show(Name);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
