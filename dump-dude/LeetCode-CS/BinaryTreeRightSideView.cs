using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{
    class Max_Values
    {
        private int max;

        public int Max { get => max; set => max = value; }
    }
    class BinaryTreeRightSideView
    {
        Max_Values maxNum = new Max_Values();
        List<int> innerList = new List<int>();
        public void PrintVirtualOrder(TreeNode root, Max_Values max, int hd)
        {
            if (root == null)
                return;
            if (hd > max.Max)
            {
                innerList.Add(root.val);
            }
            PrintVirtualOrder(root.right, max, hd + 1);
            PrintVirtualOrder(root.left, max, hd - 1);
        }
        public void execute(TreeNode root)
        {
            PrintVirtualOrder(root, maxNum, 0);
        }
    }
}
