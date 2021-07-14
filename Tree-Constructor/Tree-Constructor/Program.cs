using System;
using System.Collections.Generic;

namespace Tree_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> treeValues = new Dictionary<int, int>();
            treeValues.Add(1, 2);
            treeValues.Add(3, 2);
            treeValues.Add(2, 12);
            treeValues.Add(5, 2);
            System.Console.WriteLine(treeValidator(treeValues));
        }
        public static bool treeValidator(Dictionary<int, int> tree)
        {
            int parentcount = 0;
            Dictionary<int, int> tracker = new Dictionary<int, int>();
            foreach (KeyValuePair<int, int> node in tree)
            {
                if (tracker.ContainsValue(node.Value))
                {
                    parentcount++;
                    if (parentcount > 1)
                    {
                        return false;
                    }
                }
                tracker.Add(node.Key, node.Value);
            }
            return true;
        }
    }
}    
