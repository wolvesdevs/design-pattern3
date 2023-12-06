using Simple.Data;
using System.ComponentModel;

namespace Simple
{
    public class Form1ViewModel : INotifyPropertyChanged
    {
        private string _label1Text = "defualt1";
        public string Label1Text
        {
            get { return _label1Text; }
            set
            {
                _label1Text = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Label1Text"));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void GetButtonClick()
        {
            IProduct product = Factories.CreateProduct(Program.Kind);
            Label1Text = product.GetData();
        }
    }
}
