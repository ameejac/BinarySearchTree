using System;
using System.Collections.Generic;
using System.Linq;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //uc1 inserting the nodes in binary tree
            BinaryTree<int> binaryTree = new BinaryTree<int>(56);
            binaryTree.add(23);
            binaryTree.add(15);
            binaryTree.add(30);
            binaryTree.add(70);
            binaryTree.add(60);
            binaryTree.add(63);
            binaryTree.add(16);
            binaryTree.add(67);
            binaryTree.Display();
            binaryTree.GetSize();
            bool result = binaryTree.IfExist(67, binaryTree);
            Console.WriteLine(result);
        }
    }
}
