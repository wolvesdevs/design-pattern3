using Rei01.Buhin;
using Rei01.Buhin.Data;

namespace Rei01
{
    public partial class Form1 : Form
    {
        private List<IBuhin> _buhins = new List<IBuhin>();

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var youkiAAA = new Youki("AAA", 0);
            //var nakamiAAA1 = new Nakami("AAA1", 1);
            //var nakamiAAA2 = new Nakami("AAA2", 1);

            //var youkiBBB = new Youki("BBB", 1);
            //var nakamiBBBA1 = new Nakami("BBBA1", 2);
            //var nakamiBBBA2 = new Nakami("BBBA2", 2);
            //var nakamiBBBA3 = new Nakami("BBBA3", 2);

            //var youkiCCC = new Youki("CCC", 0);
            //var nakamiCCC1 = new Nakami("CCC1", 1);

            //youkiAAA.Add(nakamiAAA1);
            //youkiAAA.Add(nakamiAAA2);
            //youkiAAA.Add(youkiBBB);
            //youkiBBB.Add(nakamiBBBA1);
            //youkiBBB.Add(nakamiBBBA2);
            //youkiBBB.Add(nakamiBBBA3);
            //youkiCCC.Add(nakamiCCC1);

            //listBox1.Items.Add(youkiAAA);
            //listBox1.Items.Add(nakamiAAA1);
            //listBox1.Items.Add(nakamiAAA2);
            //listBox1.Items.Add(youkiBBB);
            //listBox1.Items.Add(nakamiBBBA1);
            //listBox1.Items.Add(nakamiBBBA2);
            //listBox1.Items.Add(nakamiBBBA3);
            //listBox1.Items.Add(youkiCCC);
            //listBox1.Items.Add(nakamiCCC1);

            var entities = KaisouFake.GetData();
            foreach (var entity in entities)
            {
                if (entity.Kind == 1)
                {
                    _buhins.Add(new Youki(entity));
                }
                else if (entity.Kind == 2)
                {
                    _buhins.Add(new Nakami(entity));
                }
            }

            foreach (var buhin in _buhins)
            {
                var parent = _buhins.Find(x => x.Id == buhin.ParentId);

                if (parent != null)
                {
                    parent.Add(buhin);
                }
            }

            listBox1.DataSource = _buhins;
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