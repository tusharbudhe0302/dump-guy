using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{ 
    class values
    {
        public int min, max;
    }
    class VerticalOrderOfBinaryTree
    {
        values val = new values();
        public IList<IList<int>> getListOfLevelOrder(TreeNode root)
        {
            var outerList = new List<IList<int>>();
            getMaxMin(root, val, val,0);
            for(int lowCount = val.min; lowCount < val.max; lowCount++)
            {
                List<int> innerList = new List<int>();
                PrintVirtualOrder(innerList,  root,  lowCount,  0);
                outerList.Add(innerList);
            }
            return outerList;
        }
        public void getMaxMin(TreeNode root, values min, values max, int hd)
        {
            if (root == null)
                return;
            if (hd < min.min) min.min = hd;
            else if (hd > max.max) max.max = hd;
            getMaxMin(root.left, min, max, hd - 1);
            getMaxMin(root.right, min, max, hd +1);
        }
        public void PrintVirtualOrder(List<int> innerList,TreeNode root,int lowCount, int hd)
        {
            if (root == null)
                return;
            if(hd== lowCount)
            {
                innerList.Add(root.val);
            }
            PrintVirtualOrder(innerList,root.left, lowCount, hd - 1);
            PrintVirtualOrder(innerList,root.right, lowCount,  hd + 1);
        }

        Dictionary<int, int> map = new Dictionary<int, int>();
        public void PrintVerticalOrderOfBESTQeue(TreeNode root)
        {
            getMaxMinVerticalOrderOfBESTQeue(root, 0, 0, 0);
            var list = map.Keys.ToList();
            //list.Sort();
            //for(int lowCt = -2; lowCt < 2; lowCt++)
            //{
            //    List<int> lst = new List<int>();
            //   var keys =  map.ContainsValue(lowCt);
            //lis
            //}
        }
       
        public void getMaxMinVerticalOrderOfBESTQeue(TreeNode node,int  min,  int max, int hd)
        {
            if (node == null)
                return;
            if (hd < min)
            {
                min = hd;
                map.Add(node.val, min);
            }
            else if (hd > max)
            {
                max = hd;
                map.Add(node.val, max);
            }
            else
            {
                map.Add(node.val, hd);
            }
            getMaxMinVerticalOrderOfBESTQeue(node.left, min, max, hd - 1);
            getMaxMinVerticalOrderOfBESTQeue(node.right, min, max, hd + 1);
        }
    }
}
