using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{/// <summary>
/// Linked list
/// </summary>
    class CustomLinkedList //Adding the elements form last to first 
    {
        public Node head;
        public void AddFront(int new_data) // creating method for a class
        {
            Node new_node=new Node(new_data); // Creting a object for Node.class
            // when we want to add any node at the front , we want the head to point to it.
            new_node.next=this.head;
            // the previous head node is now the second node of linked list 
            this.head=new_node;
            Console.WriteLine("inserted into list" +" " + new_node.data);
        }
        public void Display()//this method is for displaying the elements in linked list
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
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
