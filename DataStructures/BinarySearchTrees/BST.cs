using CommonDataStructures;
using DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTrees
{
    public class BST<T> where T : IComparable<T>
    {
        public BST(CommonDataStructures.Node<T> root = null)
        {
            Root = root;
        }

        public CommonDataStructures.Node<T> Root { get; set; }

        // check if value is bigger or smaller than root
        // go left or right accordingly
        // repeat for child element
        // find the first null child element and put the new node there
        public void Insert(T value, CommonDataStructures.Node<T> node)
        {
            if (node == null)
            {
                node = new CommonDataStructures.Node<T>(value);
                Root = node;
                return;
            }

            if (node.Value.CompareTo(value) > 0)
            {
                if (node.LeftChild == null)
                {
                    node.LeftChild = new CommonDataStructures.Node<T>(value);
                    return;
                }
                Insert(value, node.LeftChild);
            }
            else
            {
                if (node.RightChild == null)
                {
                    node.RightChild = new CommonDataStructures.Node<T>(value);
                    return;
                }

                Insert(value, node.RightChild);
            }
        }

        public bool Contains(T value, CommonDataStructures.Node<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.Value.CompareTo(value) == 0)
            {
                return true;
            }

            if (node.Value.CompareTo(value) > 0)
            {
                return Contains(value, node.LeftChild);
            }
            else
            {
                return Contains(value, node.RightChild);
            }

        }

        public CommonDataStructures.Node<T> Search(T value, CommonDataStructures.Node<T> node)
        {
            if (node == null)
            {
                return null;
            }
            if (node.Value.CompareTo(value) == 0)
            {
                return node;
            }

            if (node.Value.CompareTo(value) > 0)
            {
                return Search(value, node.LeftChild);
            }
            else
            {
                return Search(value, node.RightChild);
            }

        }

    }
}