using AbstractF.Data;
using System.ComponentModel;

namespace AbstractF
{
    public class Form1ViewModel : INotifyPropertyChanged
    {
        private IProduct _product;
        private IStock _stock;

        public Form1ViewModel(IProduct product, IStock stock)
        {
            _product = product;
            _stock = stock;
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
            if (_stock.GetStock() > 1)
            {
                Label1Text = "在庫なし";
                return;
            }

            Label1Text = _product.GetData() + "desu";
        }
    }
}
