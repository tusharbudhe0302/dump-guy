using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{
    public class TreeNodeSerDesiralize
    {
        public int val;
        public TreeNodeSerDesiralize left;
        public TreeNodeSerDesiralize right;
        public TreeNodeSerDesiralize(int x) { val = x; }
    }
    public class SerDesiralizeBT
    {
        string separator;
        public SerDesiralizeBT()
        {
            separator = Guid.NewGuid().ToString();
        }

        // Encodes a tree to a single string.
        public string serialize(TreeNodeSerDesiralize root)
        {
            string retVal = separator;
            if (root == null)
            {
                return retVal;
            }
            retVal += root.val;
            retVal += serialize(root.left);
            retVal += serialize(root.right);
            return retVal;
        }

        // Decodes your encoded data to tree.
        public TreeNodeSerDesiralize deserialize(string data)
        {
            var localData = data;
            return deserialize(ref localData);
        }
        public TreeNodeSerDesiralize deserialize(ref string data)
        {
            TreeNodeSerDesiralize root = null;
            
            // If reached the end of the string data
            if (data.IndexOf(separator, separator.Length) == -1)
            {
                return root;
            }
            // Calculate Value
            var val = data.Substring(separator.Length, data.Substring(separator.Length).IndexOf(separator));

            // If no value present
            if (string.IsNullOrEmpty(val))
            {
                return root;
            }
            // Evaluate Root
            root = new TreeNodeSerDesiralize(GetValue<int>(val));
            // Evaluate Left
            data = data.Substring(data.IndexOf(separator, separator.Length));
            root.left = deserialize(ref data);
            // Evaluate Right
            data = data.Substring(data.IndexOf(separator, separator.Length));
            root.right = deserialize(ref data);
            return root;
        }
        public static T GetValue<T>(String value)
        {
            return (T)Convert.ChangeType(value, typeof(T));
        }
    }

    // Your SerDesiralizeBT object will be instantiated and called as such:
    // SerDesiralizeBT codec = new SerDesiralizeBT();
    // codec.deserialize(codec.serialize(root));
}
