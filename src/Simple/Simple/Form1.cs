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
            if (Program.Kind == 0)
            {
                var product = new ProductFake();
                label1.Text = product.GetData();
            }
            else if (Program.Kind == 1)
            {
                var product = new ProductSqlServer();
                label1.Text = product.GetData();
            }   
        }
    }
}