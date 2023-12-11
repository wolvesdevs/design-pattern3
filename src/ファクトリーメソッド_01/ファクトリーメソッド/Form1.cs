using ファクトリーメソッド.Data;

namespace ファクトリーメソッド
{
    public partial class Form1 : Form
    {
        private Form1ViewModel _vm = new Form1ViewModel(Factories.CreateProduct(Program.Kind));

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            label1.DataBindings.Add("Text", _vm, "Label1Text");
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            _vm.GetButtonClick();
        }
    }
}