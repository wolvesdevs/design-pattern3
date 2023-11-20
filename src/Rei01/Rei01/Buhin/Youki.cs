namespace Rei01.Buhin
{
    internal sealed class Youki : IBuhin
    {
        private List<IBuhin> _buhins = new List<IBuhin>(); 
        public void Execute()
        {
            MessageBox.Show("容器です。");

            foreach (var buhin in _buhins)
            {
                buhin.Execute();
            }
        }

        public void Add(IBuhin buhin)
        {
            _buhins.Add(buhin);
        }
    }
}
