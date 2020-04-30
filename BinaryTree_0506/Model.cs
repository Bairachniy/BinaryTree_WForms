using BinaryTreeDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree_0506
{
    class Model
    {
        //BinaryTree<int> vs;
        //MYBinaryTreeNode<int>  _mainNode;
        //private string _left = "Left";
        //private string _right="Right";

        //public Model(MYBinaryTreeNode<int> root)
        //{
        //    vs = new BinaryTree<int>();
        //    _mainNode = root;
        //}
        //public MYBinaryTreeNode<int> GetTree { get { return _mainNode; } }

        public MYBinaryTreeNode<int> root;
        public Model()
        {
            root = null;
        }
        public MYBinaryTreeNode<int> insert(int data)
        {
            MYBinaryTreeNode<int> newItem = new MYBinaryTreeNode<int>(data);
            if (root == null)
            {
                root = newItem;
            }
            else
            {
                MYBinaryTreeNode<int> sub = new MYBinaryTreeNode<int>();
                MYBinaryTreeNode<int> current = root;
                MYBinaryTreeNode<int> parent = null;
                while (current != null)
                {
                    parent = current;
                    if (String.Compare(Convert.ToString(data), current.data) < 0)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newItem;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newItem;
                        }
                    }
                }
            }
            return newItem;

        }
        
    }
}
