using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinaryTree<T> where T : IComparable<T>
        {
            public T nodeData { get; set; }
            public BinaryTree<T> leftTree { get; set; }
            public BinaryTree<T> rightTree { get; set; }
            public  int leftCount;
            public  int rightCount;
            bool result = false;
            public BinaryTree(T nodeData)
            {
                this.nodeData = nodeData;
                this.leftTree = null;
                this.rightTree = null;

            }
        //uc1 inserting the elements in binarysearchtree
        public void add (T item)
        {
            T currentNodevalue = this.nodeData;
            int value = currentNodevalue.CompareTo(item);
            if((value) > 0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new BinaryTree<T>(item);
                    Console.WriteLine("adding item" + item);
                }
                else
                {
                    this.leftTree.add(item);
                }
            }
            else
            {
                if(this.rightTree ==null)
                {
                    this.rightTree = new BinaryTree<T>(item);
                    Console.WriteLine("adding item:" + item);
                }
                else
                {
                    this.rightTree.add(item);
                }
                
            }
        }
        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();
            }
            Console.WriteLine(this.nodeData.ToString());

            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }
        }
        public void GetSize()
        {
            Console.WriteLine("size" + ""  + (1+ this.leftCount + this.rightCount));
        }
        //uc3 search perticular element in the BST
        public bool IfExist(T element, BinaryTree<T> node)
        {
            if(node ==null)
            {
                return false;
            }
            if(node.nodeData.Equals(element))
            {
                Console.WriteLine("found the element in BST:" + "" + node.nodeData);
                    result = true;
            }
            else
            {
                Console.WriteLine(" current element is{0} in BST:" + node.nodeData);
            }
            if(element.CompareTo(node.nodeData) < 0)
            {
                IfExist(element, node.leftTree);
            }
            if(element.CompareTo(node.nodeData) > 0)
            {
                IfExist(element, node.rightTree);
            }
            return result;
        }
    }

}
