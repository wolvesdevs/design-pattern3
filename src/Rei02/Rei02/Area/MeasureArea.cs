
using Rei02.Data;

namespace Rei02.Area
{
    internal sealed class MeasureArea : AreaBase
    {
        private Condition _condition = Condition.Normal;

        public MeasureArea(KaisouEntity entity) : base(entity)
        {
        }

        public override void Add(AreaBase area)
        {
            throw new NotImplementedException("Addはできません");
        }

        public override IEnumerable<AreaBase> GetChildren()
        {
            return new List<AreaBase>();
        }

        public override void Alarm()
        {
            _condition = Condition.Alarm;
        }

        public override void Release()
        {
            _condition = Condition.Normal;
        }

        public override Condition GetCondition()
        {
            return _condition;
        }
    }
}
