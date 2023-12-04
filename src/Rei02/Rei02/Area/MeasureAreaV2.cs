using Rei02.Data;

namespace Rei02.Area
{
    internal sealed class MeasureAreaV2 : AreaBase
    {
        private Condition _condition = Condition.Normal;

        public MeasureAreaV2(KaisouEntity entity) : base(entity)
        {
        }

        public override void Add(AreaBase area)
        {
            throw new NotImplementedException($"Addはできません this.Id={Id} arg.Id={area.Id}");
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
