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
            var k = new BlockArea("関東");
            var a = new BlockArea("東京");
            var a1 = new MeasureArea("立川");
            var a2 = new MeasureArea("三鷹");

            var s = new BlockArea("四国");
            var b = new BlockArea("香川");
            var b1 = new MeasureArea("高松");

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

        private void AlarmButton_Click(object sender, EventArgs e)
        {
            var area = treeView1.SelectedNode.Tag as AreaBase;

            if (area == null)
            {
                MessageBox.Show("地域を選択してください");
                return;
            }

            area.Alarm();
            SetImage();
        }

        private void SetImage()
        {
            foreach (TreeNode node in treeView1.Nodes)
            {
                SetImageMethod(node);
            }
        }

        private void SetImageMethod(TreeNode node)
        {
            var area = node.Tag as AreaBase;

            if (area != null)
            {
                if (area.GetCondition() == Condition.Alarm)
                {
                    node.ImageIndex = 1;
                    node.SelectedImageIndex = 1;
                }
                else
                {
                    node.ImageIndex = 0;
                    node.SelectedImageIndex = 0;
                }
            }

            foreach(TreeNode child in node.Nodes)
            {
                SetImageMethod(child);
            } 
        }
    }
}