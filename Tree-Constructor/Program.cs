using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new string[] { "(1,2)", "(3,2)", "(2,12)", "(5,2)" };    
            Console.WriteLine(TreeConstructor(input));
            Console.ReadKey();
        }

        static bool TreeConstructor(string[] strArr)
        {
            var nodeList = new List<Node>();
            foreach (var item in strArr)
            {
                var parsedItem = parse(item);
                if(!addChildAndCheck(parsedItem[1], nodeList))
                    return false;
            }
            return true;
        }

        static bool addChildAndCheck(int parent, List<Node> nodeList)
        {
            foreach (var item in nodeList)
            {
                if (item.id == parent)
                {
                    item.amountOfChids++;
                    if (item.amountOfChids > 2)
                        return false;
                    return true;
                }
            }
            nodeList.Add(new Node(parent, 1));
            return true;
        }

        static int[] parse(string item)
        {
            var output = new int[2];
            item = item.Remove(0, 1);
            item = item.Remove(item.Length - 1);
            var itemArr = item.Split(',');
            output[0] = int.Parse(itemArr[0]);
            output[1] = int.Parse(itemArr[1]);
            return output;
        }
    }
}
