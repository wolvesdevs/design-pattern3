using Rei01.Buhin;

namespace Rei01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var youkiAAA = new Youki("AAA");
            var nakamiAAA1 = new Nakami("AAA1");
            var nakamiAAA2 = new Nakami("AAA2");

            youkiAAA.Add(nakamiAAA1);
            youkiAAA.Add(nakamiAAA2);

            listBox1.Items.Add(youkiAAA);
            listBox1.Items.Add(nakamiAAA1);
            listBox1.Items.Add(nakamiAAA2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var buhin = listBox1.SelectedItem as IBuhin;

            if (buhin == null)
            { 
                return;
            }

            buhin.Execute();
        }
    }
}