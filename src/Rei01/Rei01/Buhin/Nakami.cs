using Rei01.Buhin.Data;

namespace Rei01.Buhin
{
    internal sealed class Nakami : IBuhin
    {
        private KaisouEntity _entity;

        public Nakami(KaisouEntity entity)
        {
            _entity = entity;
        }

        public int Id => _entity.Id;
        public int ParentId => _entity.Id;
        public string Name => _entity.Name;
        public int Level => _entity.Level;


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
