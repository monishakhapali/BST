using System;

namespace bst
{
    class BinaryTree
    {

        public Node root;

        /* can give min and max value according to your code or  
        can write a function to find min and max value of tree. */

        /* returns true if given search tree is binary  
         search tree (efficient version) */
        public  bool BST
        {
            get
            {
                return isBSTUtil(root, int.MinValue, int.MaxValue);
            }
        }

        /* Returns true if the given tree is a BST and its  
          values are >= min and <= max. */
        public  bool isBSTUtil(Node node, int min, int max)
        {
            /* an empty tree is BST */
            if (node == null)
            {
                return true;
            }

            /* false if this node violates the min/max constraints */
            if (node.data < min || node.data > max)
            {
                return false;
            }

            /* otherwise check the subtrees recursively  
            tightening the min/max constraints */
            // Allow only distinct values  
            return (isBSTUtil(node.left, min, node.data ) && isBSTUtil(node.right, node.data , max));
        }






        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(10);
            tree.root.left = new Node(10);
            tree.root.right = new Node(19);
            tree.root.left.left = new Node(10);
            tree.root.left.left = new Node(-5);

            if (tree.BST)
            {
                Console.WriteLine("IS BST");
            }
            else
            {
                Console.WriteLine("Not a BST");
            }
            Console.ReadLine();
        }

        public class Node
        {
            public int data;
            public Node left, right;

            public Node(int item)
            {
                data = item;
                left = right = null;
            }
        }

    }

}
