using Rei01.Buhin.Data;

namespace Rei01.Buhin
{
    internal sealed class Youki : IBuhin
    {
        private List<IBuhin> _buhins = new List<IBuhin>();
        private KaisouEntity _entity;

        public Youki(KaisouEntity enitty)
        {
            _entity = enitty;
        }

        public string Name => _entity.Name;
        public int Level => _entity.Level;

        public void Execute()
        {
            MessageBox.Show(Name);

            foreach (var buhin in _buhins)
            {
                buhin.Execute();
            }
        }

        public void Add(IBuhin buhin)
        {
            _buhins.Add(buhin);
        }

        public override string ToString()
        {
            return string.Concat(Enumerable.Repeat("+", Level)) + Name;
        }
    }
}
