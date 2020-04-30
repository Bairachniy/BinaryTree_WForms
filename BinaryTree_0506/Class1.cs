using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeDLL
{
    public class MYBinaryTreeNode<TNode>:IComparable<TNode> where TNode:IComparable<TNode>
    {
        public MYBinaryTreeNode(TNode value)
        {
            Value = value;
        }
        public TNode Value
        {
            get;
            private set;
        }
        public MYBinaryTreeNode<TNode> Right { get; set; }
        public MYBinaryTreeNode<TNode> Left { get; set; }
        public int CompareTo(TNode other)
        {
            return Value.CompareTo(other);
        }

        public int CompareNode(MYBinaryTreeNode<TNode> other)
        {
            return Value.CompareTo(other.Value);
        }

       
    }

    public class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        private MYBinaryTreeNode<T> _head;

        private int _count;

        #region Добавление нового узла дерева

        public void Add(T value)
        {
            // Первый случай: дерево пустое     

            if (_head == null)
            {
                _head = new MYBinaryTreeNode<T>(value);
            }

            // Второй случай: дерево не пустое, поэтому применяем рекурсивный алгорит 
            //                для поиска места добавления узла        

            else
            {
                AddTo(_head, value);
            }
            _count++;
        }

        // Рекурсивный алгоритм 

        private void AddTo(MYBinaryTreeNode<T> node, T value)
        {
            // Первый случай: значение добавляемого узла меньше чем значение текущего. 

            if (value.CompareTo(node.Value) < 0)
            {
                // если левый потомок отсутствует - добавляем его          

                if (node.Left == null)
                {
                    node.Left = new MYBinaryTreeNode<T>(value);
                }
                else
                {
                    // повторная итерация               
                    AddTo(node.Left, value);
                }
            }
            // Второй случай: значение добавляемого узла равно или больше текущего значения      
            else
            {
                // Если правый потомок отсутствует - добавлем его.          

                if (node.Right == null)
                {
                    node.Right = new MYBinaryTreeNode<T>(value);
                }
                else
                {
                    // повторная итерация

                    AddTo(node.Right, value);
                }
            }
        }

        #endregion

        #region Нумератор

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Количество узлов в дереве

        public int Count
        {
            get
            {
                return _count;
            }
        }

        #endregion
    }

}
