using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeManagement
{
    public partial class BrowseStudent : Form
    {
        public BrowseStudent()
        {
            InitializeComponent();
        }

        private void BrowseStudent_Load(object sender, EventArgs e)
        {
            AddTree();
            AddStudent();
        }

        private void AddTree()
        {
            // 建立根节点
            TreeNode root = this.tvwDpart.Nodes.Add("明月大学");
            // 建立父节点
            TreeNode depart1 = root.Nodes.Add("信息工程学院");
            TreeNode depart2 = root.Nodes.Add("机电工程学院");
            TreeNode depart3 = root.Nodes.Add("通讯工程学院");
            TreeNode depart4 = root.Nodes.Add("机械与自动化学院");
            TreeNode depart5 = root.Nodes.Add("土木工程学院");
            // 建立子节点
            TreeNode cs1 = new TreeNode("信息工程1班");
            TreeNode cs2 = new TreeNode("信息工程2班");
            TreeNode cs3 = new TreeNode("机电工程1班");
            TreeNode cs4 = new TreeNode("机电工程2班");
            TreeNode cs5 = new TreeNode("通讯工程1班");
            TreeNode cs6 = new TreeNode("通讯工程2班");
            TreeNode cs7 = new TreeNode("机械与自动化1班");
            TreeNode cs8 = new TreeNode("机械与自动化2班");
            TreeNode cs9 = new TreeNode("土木工程1班");
            TreeNode cs10 = new TreeNode("土木工程2班");
            // 将子节点添加到父节点
            depart1.Nodes.Add(cs1);
            depart1.Nodes.Add(cs2);
            depart2.Nodes.Add(cs3);
            depart2.Nodes.Add(cs4);
            depart3.Nodes.Add(cs5);
            depart3.Nodes.Add(cs6);
            depart4.Nodes.Add(cs7);
            depart4.Nodes.Add(cs8);
            depart5.Nodes.Add(cs9);
            depart5.Nodes.Add(cs10);
        }

        private void AddStudent()
        {
            // TODO 从数据库读
            //Student[] stu = new Student[]
            //{
            //    new("20120101001", "张志强", "男", "党员", "18", "河南省许昌市"),
            //    new("20120101002", "张晓丽", "女", "团员", "18", "河南省洛阳市")
            //};
            //this.dgvStudent.DataSource = stu; // 数据绑定
        }

        private void 全部展开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tvwDpart.ExpandAll();
        }

        private void 全部折叠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tvwDpart.CollapseAll();
        }
    }
}
