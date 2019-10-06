using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*Given a binary tree, find the lowest common ancestor(LCA) of two given nodes in the tree.
     * we allow a node to be a descendant of itself
     * Example1:
     * Input:root=[3,5,1,6,2,0,8,null,null,7,4],p=5,q=1
     * Output:3
     * Example2:
     * Input:root=[3,5,1,6,2,0,8,null,null,7,4],p=5,q=4
     * Output:5
     * Note:
     * All of the nodes' values will be unique
     * p and q are different and both values will exist in the binary tree
     */
     public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    public class Solution
    {
        public TreeNode LowestCommonAncestor(TreeNode root,TreeNode p,TreeNode q)
        {
            return Find(root, p, q);
        }
        private TreeNode Find(TreeNode current, TreeNode p,TreeNode q)
        {
            if (current == null || current == p || current == q)
                return current;
            TreeNode left = Find(current.left, p, q);
            TreeNode right = Find(current.right, p, q);
            if (left != null && right != null)
                return current;
            return left != null ? left : right;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
