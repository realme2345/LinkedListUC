using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{/// <summary>
/// Linked List
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
           CustomLinkedList customLinkedList = new CustomLinkedList();//creating a object
            customLinkedList.AddFront(70);
            customLinkedList.AddFront(30);
            customLinkedList.AddFront(56);
            customLinkedList.Display();
        }
    }
}
