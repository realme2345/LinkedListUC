using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{/// <summary>
/// Linked list
/// </summary>
    class CustomLinkedList
    {
        public Node head;
        public void AddLast(int new_data) // creating method for a class
        {
            Node new_node=new Node(new_data); // Creting a object for Node.class
            if (this.head == null)
            {
                this.head=new_node;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next=new_node;
            }
            Console.WriteLine("inserted into list" +" " + new_node.data);
        }
        public Node GetLastNode()  
        {
            Node temp=this.head;
            while (temp.next != null)
            {
                temp=temp.next;
            }
            return temp;
        }
        public void Display()
        {
            Console.WriteLine("Displaying Names");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
