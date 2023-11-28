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
    }
}
