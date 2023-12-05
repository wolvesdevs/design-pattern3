using Simple.Data;

namespace Simple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            var product = new ProductSqlServer();
            label1.Text = product.GetData();
        }
    }
}