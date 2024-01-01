using BLL;
using Model;
using MySql.Data.MySqlClient;
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
        private StudentBLL studentBLL = new StudentBLL();
        private CollegeBLL collegeBLL = new CollegeBLL();
        private ClassBLL classBLL = new ClassBLL();
        public BrowseStudent()
        {
            InitializeComponent();
        }

        private void BrowseStudent_Load(object sender, EventArgs e)
        {
            AddTree();
        }
        
        private void tvwDpart_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.tvwDpart.SelectedNode == null || e.Node.Nodes.Count != 0) { return; }
            else
            {
                int id = Convert.ToInt32(this.tvwDpart.SelectedNode.Tag);
                this.dgvStudent.DataSource = studentBLL.SelectStudentInfomation(id);
            }
        }

        private void AddTree()
        {
            // 建立根节点
            TreeNode root = this.tvwDpart.Nodes.Add(Constant.SCHOOL_NAME);
            List<College> colleges = collegeBLL.SelectAll();
            // 遍历院系表
            foreach (College c in colleges)
            {
                TreeNode cnode = new TreeNode(c.Name);
                cnode.Tag = c.Id;
                root.Nodes.Add(cnode);
                // 获得班级
                List<Class> classes = classBLL.SelectByDepart(c.Id);
                foreach (Class cls in classes)
                {
                    TreeNode classNode = new(cls.Name);
                    classNode.Tag = cls.Id;
                    cnode.Nodes.Add(classNode);
                }
            }
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
