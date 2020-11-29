using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShopSystem
{
    public partial class ad_menu : Form
    {
        public ad_menu()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = new TreeNode("hello");
            treeView1.SelectedNode.Nodes.Add(node);
        }
    }
}
