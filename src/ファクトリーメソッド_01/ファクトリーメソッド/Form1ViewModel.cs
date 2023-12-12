using ファクトリーメソッド.Data;
using System.ComponentModel;
using ファクトリーメソッド.Services;

namespace ファクトリーメソッド
{
    public class Form1ViewModel : INotifyPropertyChanged
    {
        private ProductService _service;
        public Form1ViewModel(ProductService service)
        {
            _service = service;
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
            var product = _service.Create();
            Label1Text = product.GetData() + "desu";
        }
    }
}
