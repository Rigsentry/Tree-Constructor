using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Constructor
{
    class Node
    {
        public int id { get; set; }
        public int amountOfChids { get; set; }

        public Node(int id, int amountOfChids)
        {
            this.id = id;
            this.amountOfChids = amountOfChids;
        }

    }
}
