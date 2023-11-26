namespace Rei01.Buhin
{
    internal sealed class NakamiAddException : Exception
    {
        public NakamiAddException(int id) : base($"NakamiにAddはできません Id={id}")
        {
        }
    }
}
