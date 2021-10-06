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
        
    }

}
