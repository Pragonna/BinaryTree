
using System;

namespace BinaryTree.Console.Helpers
{
    public class BinaryHelper
    {
        static public void ConsolePrint(ICustomBinaryTree binaryTree)
        {
            if (binaryTree == null) throw new Exception("Binary can not be null");
            if (binaryTree.Root == null) throw new Exception("First Node is null reference");

            GetNodes(binaryTree.Root);

            System.Console.ReadLine();
        }

        static void GetNodes(Node root, string space=" ",string rootPosition="-",string parentId="-",string parentValue="-")
        {
            if (root == null) return;

            space+=space;

            System.Console.WriteLine($"{space}Root Id:{root.Id.ToString()}");
            System.Console.WriteLine($"{space}Root Value:{root.Value.ToString()}");
            System.Console.WriteLine($"{space}Root ParentId: {parentId}");
            System.Console.WriteLine($"{space}Root ParentValue: {parentValue}");
            System.Console.WriteLine($"{space}Root Position: {rootPosition}");
            System.Console.WriteLine("_________________________________________________________________________________");

            if (root.Right != null)
                GetNodes(root.Right,space,"Right",root.Id.ToString(),root.Value.ToString());

            if (root.Left != null)
                GetNodes(root.Left,space,"Left", root.Id.ToString(), root.Value.ToString());
        }
        
    }
}
