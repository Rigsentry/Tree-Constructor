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

            List<String> arrayList = new List<string>();
            List<String> parentList = new List<string>();

            //arraylist.add("(1,2)");
            //arraylist.add("(2,4)");
            //arraylist.add("(7,2)");

            //arrayList.Add("(1,2)");
            //arrayList.Add("(2,4)");
            //arrayList.Add("(5,7)");
            //arrayList.Add("(7,2)");
            //arrayList.Add("(9,5)");

            arrayList.Add("(1,2)");
            arrayList.Add("(3,2)");
            arrayList.Add("(2,12)");
            arrayList.Add("(5,2)");


            foreach (string pair in arrayList)
            {
                parentList.Add(pair.Substring(pair.LastIndexOf(',') + 1));
            }
            var binary = true;
            if(parentList.Where(x => x.Count() > 2).Any())
            {
                binary = false;
            }
            Console.WriteLine(binary.ToString());
            Console.Read();
        }
    }
}
