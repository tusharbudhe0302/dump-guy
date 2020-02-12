using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    class SmallestSubtreeWithAllDeepestNodes
    {
  
         public TreeNode subtreeWithAllDeepest(TreeNode root)
        {
            int depthOfCompleteTree = depth(root);
            TreeNode result = GetDepthNode(root, 1, depthOfCompleteTree);
            return result;
        }
        private TreeNode GetDepthNode(TreeNode iterateNode,int depth,int target)
        {
            if (iterateNode == null) return null;
            if (depth == target) return iterateNode;
            TreeNode left = GetDepthNode(iterateNode.left, depth + 1, target);
            TreeNode right = GetDepthNode(iterateNode.right, depth + 1, target);
            if (left != null && right != null) return iterateNode;
            if (left == null) return right;
             return left;
        }
        
        private int depth(TreeNode node)
        {
            if (node == null) return 0;
            int left = depth(node.left);
            int right = depth(node.right);
            return 1 + Math.Max(left, right);
        }
        
    }
}
