
namespace Rei02.Area
{
    internal sealed class BlockArea : AreaBase
    {
        public List<AreaBase> _areas = new List<AreaBase>();

        public BlockArea(string name) : base(name)
        {
        }

        public override void Add(AreaBase area)
        {
            _areas.Add(area);
        }

        public override IEnumerable<AreaBase> GetChildren()
        {
            return _areas;
        }

        public override void Alarm()
        {
            throw new ArgumentException("一括警報設定はできません。");
        }

        public override Condition GetCondition()
        {
            foreach (var area in _areas)
            {
                if (area.GetCondition() == Condition.Alarm)
                {
                    return Condition.Alarm;
                }
            }
            return Condition.Normal;
        }
    }
}
