﻿
namespace Rei02.Area
{
    internal sealed class MeasureArea : AreaBase
    {
        private Condition _condition = Condition.Normal;

        public MeasureArea(string name) : base(name)
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

        public override Condition GetCondition()
        {
            return _condition;
        }
    }
}
