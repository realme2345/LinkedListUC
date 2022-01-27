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
            customLinkedList.AddLast(56);
            customLinkedList.AddLast(30);
            customLinkedList.AddLast(70);
            customLinkedList.Display();
            int res=customLinkedList.search(30);
            if (res == 0)
            {
                Console.WriteLine("{0} is not present", res);
            }
            else
            {
                Console.WriteLine("{0} is present", res);
            }

        }
    }
}
