using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinaryTreeDLL;

namespace BinaryTree_0506
{
    public partial class Form1 : Form
    {
        //MYBinaryTreeNode<int> node;
        BinaryTree<int> tree = new BinaryTree<int>();
        //Model model = new Model();
        void ShowNode(MYBinaryTreeNode<int> node, TreeNode treeNode)
        {
            treeNode.Text += node.data;
            if (node.Left != null)
            {
                ShowNode(node.Left, treeNode.Nodes.Add($"Left:{node.Left.Value} "));
            }
            if (node.Right != null)
            {
                ShowNode(node.Right, treeNode.Nodes.Add($"Right:{node.Right.Value} "));
            }
        }
        void DisplayTree(BinaryTree<int> tree)
        {
            ShowNode(tree._head, treeView2.Nodes.Add($"Root:{tree._head.Value} "));
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MYBinaryTreeNode<int> node = new MYBinaryTreeNode<int>(Int32.Parse(textBox1.Text));
           // tree.Add(Int32.Parse(textBox1.Text));
            
               // treeView1.Nodes.Add(Convert.ToString(node.Value));
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tree.Add(Int32.Parse(textBox2.Text));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView2.Nodes.Clear();
            //foreach (var i in tree)
            //{
            //    //model.insert(i);
            //    treeView2.Nodes.Add(Convert.ToString(model.insert(i).Value));

            //}
            DisplayTree(tree);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    tree.Add(Int32.Parse(textBox1.Text));
        //    listBox1.Items.Add(tree);
        //}
    }
}
