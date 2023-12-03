using Rei02.Data;

namespace Rei02.Area
{
    internal abstract class AreaBase
    {
        private KaisouEntity _entity;

        protected AreaBase(KaisouEntity entity)
        {
            _entity = entity;
        }

        public int Id => _entity.Id;
        public int ParentId => _entity.ParentId;
        public string Name => _entity.Name;

        public abstract void Add(AreaBase area);
        public abstract IEnumerable<AreaBase> GetChildren();
        public abstract void Alarm();
        public abstract void Release();
        public abstract Condition GetCondition();
    }

    internal enum Condition
    {
        Normal,
        Alarm,
    }
}
