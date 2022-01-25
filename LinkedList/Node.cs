using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{/// <summary>
/// Linked list
/// </summary>
    class Node
    {
        public int data;
        public Node next;
        public Node(int d) // creating Constructer
        {
            data = d;
            next = null;
        }
    }
}
