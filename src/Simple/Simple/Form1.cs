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
            IProduct product;

            if (Program.Kind == 0)
            {
                product = new ProductFake();
            }
            else if (Program.Kind == 1)
            {
                product = new ProductSqlServer();
            }
            else
            {
                throw new ArgumentException("Invalid kind");
            }

            label1.Text = product.GetData();
        }
    }
}