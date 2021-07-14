using System;
using System.Collections.Generic;

namespace Tree_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = new string[] { "(1,2)", "(2,4)", "(5,7)", "(7,2)", "(9,5)" };

            Dictionary<int, int> numberCount = new Dictionary<int, int>();

            Console.WriteLine(TreeConstructor(input));

            Boolean TreeConstructor(string[] input)
            {
                foreach (var node in input)
                {
                    char parentNumber = node[3];
                    if (!numberCount.ContainsKey(parentNumber))
                    {
                        numberCount.Add(parentNumber, 1);
                    }
                    else
                    {
                        numberCount[parentNumber] += 1;
                    }

                if (numberCount.ContainsValue(3))
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
