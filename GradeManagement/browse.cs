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
        public BrowseStudent()
        {
            InitializeComponent();
        }

        private void BrowseStudent_Load(object sender, EventArgs e)
        {
            AddTree();
        }
        private DataTable GetStudentInfomation(int classID)
        {
            string sql = "select stuid, tb_student.name,case gender when 'M' THEN '男' when 'F' THEN '女' END as gender" +
                ",case politics when 0 then '中共党员' when 1 then '共青团员' when 2 then '学生' when 3 then '其他' end as politics," +
                " age, location, tb_class.name as className" +
                " from tb_student, tb_class where tb_student.class = tb_class.id and class = @class";
            using (MySqlConnection conn = Utils.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@class", classID);
                MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                mda.Fill(ds);
                
                return ds.Tables[0];
            }
        }
        private void tvwDpart_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.tvwDpart.SelectedNode == null || e.Node.Nodes.Count != 0) { return; }

            else
            {
                int id = Convert.ToInt32(this.tvwDpart.SelectedNode.Tag);
                this.dgvStudent.DataSource = GetStudentInfomation(id);
            }
        }

        private void AddTree()
        {
            // 建立根节点
            TreeNode root = this.tvwDpart.Nodes.Add(Constant.SCHOOL_NAME);
            string sql = "select id, name from tb_college";
            using (MySqlConnection conn = Utils.GetConnection())
            {
                MySqlDataAdapter mda = new(sql, conn);
                DataSet ds = new DataSet();
                mda.Fill(ds, "college");
                DataTable dtCollege = ds.Tables["college"];
                // 遍历院系表
                for (int i = 0; i < dtCollege.Rows.Count; i++)
                {
                    TreeNode cnode = new TreeNode(dtCollege.Rows[i]["name"].ToString());
                    cnode.Tag = dtCollege.Rows[i]["id"].ToString();
                    root.Nodes.Add(cnode);
                    // 获得班级
                    sql = "select id, name from tb_class where depart = @depart";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@depart", dtCollege.Rows[i]["id"].ToString());
                    mda = new MySqlDataAdapter(cmd);
                    mda.Fill(ds, "class");
                    DataTable dtClass = ds.Tables["class"];

                    for (int j = 0; j < dtClass.Rows.Count; j++)
                    {
                        TreeNode classNode = new(dtClass.Rows[j]["name"].ToString());
                        classNode.Tag = dtClass.Rows[j]["id"].ToString();
                        cnode.Nodes.Add(classNode);
                    }
                    ds.Tables["class"].Clear();
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
