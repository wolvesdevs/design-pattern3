using Rei02.Area;
using Rei02.Data;

namespace Rei02
{
    public partial class Form1 : Form
    {
        private List<AreaBase> _areas = new List<AreaBase>();

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            treeView1.HideSelection = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var entities = KaisouFake.GetData();

            foreach (var entity in entities)
            {
                if (entity.Kind == 1)
                {
                    _areas.Add(new BlockArea(entity));
                }
                else if (entity.Kind == 2)
                {
                    _areas.Add(new MeasureArea(entity));
                }
                else if (entity.Kind == 99)
                {
                    _areas.Add(new LargeBlockArea(entity));
                }
            }

            foreach (var area in _areas)
            {
                var parent = _areas.Find(x => x.Id == area.ParentId);
                if (parent != null)
                {
                    parent.Add(area);
                }
            }

            var roots = _areas.FindAll(x => x.ParentId == 0);

            if (roots.Count < 1)
            {
                throw new Exception("rootがありません。。");
            }

            foreach (var root in roots)
            {
                AddNode(root, null);
            }

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

        private void ReleaseButton_Click(object sender, EventArgs e)
        {
            var area = treeView1.SelectedNode.Tag as AreaBase;

            if (area == null)
            {
                MessageBox.Show("地域を選択してください");
                return;
            }

            area.Release();
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

            foreach (TreeNode child in node.Nodes)
            {
                SetImageMethod(child);
            }
        }
    }
}