namespace Rei02.Area
{
    internal sealed class MeasureArea : AreaBase
    {
        public MeasureArea(string name) : base(name)
        {
        }

        public override void Add(AreaBase area)
        {
            throw new NotImplementedException("Addはできません");
        }
    }
}
