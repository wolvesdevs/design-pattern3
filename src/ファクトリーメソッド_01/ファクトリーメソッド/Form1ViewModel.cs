using ファクトリーメソッド.Data;
using System.ComponentModel;

namespace ファクトリーメソッド
{
    public class Form1ViewModel : INotifyPropertyChanged
    {
        private IProduct _product;
        public Form1ViewModel(IProduct product)
        {
            _product = product;
        }

        private string _label1Text = "--";
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
            Label1Text = _product.GetData() + "desu";
        }
    }
}
