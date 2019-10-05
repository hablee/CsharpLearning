using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /*Given a binary search tree(BST), find the lowest common ancestor(LCA)
     * of two given nodes in the BST
     * 
     * Example:
     * Input:root=[6,2,8,0,4,7,9,null,null,3,5],p=2,q=8
     * Output:6
     * 
     * Example:root=[6,2,8,0,4,7,9,null,null,3,5],p=2,q=4
     * Input:2
     * 
     * Notes:
     * All of notes' values will be unique.
     * p and q are different and both values will exist in the BST
     * 
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
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root.val == p.val||root.val==q.val)
                    return root;
            if (root.val > p.val && root.val < q.val)
                return root;
            if (root.val < p.val && root.val > q.val)
                return root;
            if(root.val<p.val&&root.val<q.val)
            {
                return LowestCommonAncestor(root.right, p, q);
            }
            return LowestCommonAncestor(root.left, p, q);
    }
        class Program
        {
            static void Main(string[] args)
            {
                
            }
        }
    }
}
