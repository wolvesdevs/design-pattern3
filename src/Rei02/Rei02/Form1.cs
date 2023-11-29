using Rei02.Area;

namespace Rei02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            treeView1.HideSelection = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var k = new BlockArea("�֓�");
            var a = new BlockArea("����");
            var a1 = new MeasureArea("����");
            var a2 = new MeasureArea("�O��");

            var s = new BlockArea("�l��");
            var b = new BlockArea("����");
            var b1 = new MeasureArea("����");

            k.Add(a);
            a.Add(a1);
            a.Add(a2);

            s.Add(b);
            b.Add(b1);

            AddNode(k, null);
            AddNode(s, null);

            treeView1.ExpandAll();
        }

        private void AddNode(AreaBase area, TreeNode? parentNode)
        {
            var node = new TreeNode(area.Name, 0, 0);
            node.Tag = area;

            if (parentNode == null)
            {
                treeView1.Nodes.Add(node);
            }
            else
            {
                parentNode.Nodes.Add(node);
            }

            foreach (var child in area.GetChildren())
            {
                AddNode(child, node);
            }
        }
    }
}