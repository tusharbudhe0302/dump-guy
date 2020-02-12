using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{
    class TreeNodeBST
    {
        public TreeNodeBST left;
        public TreeNodeBST right;
        public int info;
        public TreeNodeBST(int x)
        {
            info = x;
            left = null;
            right = null;
        }
    }
    class IsCompleteBST
    {
        public TreeNodeBST root;
        public IsCompleteBST()
        {
            root = null;
        }
        public bool CheckIsCompleteBST(TreeNodeBST root)
        {
            Queue<TreeNodeBST> q = new Queue<TreeNodeBST>();
            bool isBST = false;
            q.Enqueue(root);
            while (q.Count > 0)
            {
                TreeNodeBST temp = q.Peek();
                q.Dequeue();
                if (temp == null)
                {
                 
                    isBST = true;
                }
                else
                {
                    Console.WriteLine(temp.info);
                    if (isBST) return false;
                    q.Enqueue(temp.left);
                    q.Enqueue(temp.right);
                }
            }
            return true;
        }
    }
}
