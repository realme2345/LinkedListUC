using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{/// <summary>
/// Linked list
/// </summary>
    class CustomLinkedList //Adding the elements to linked list by using th e append method
    {
        public Node head;
        public void AddLast(int new_data) // creating method for a class
        {
            Node new_node = new Node(new_data); // Creting a object for Node.class
            if (this.head == null)
            {
                this.head = new_node; //assigning the elemnts to the head
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = new_node;
            }
            Console.WriteLine("inserted into list" + " " + new_node.data);
        }
        public Node GetLastNode() //this method for getting the last node reference
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
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
       public int DeleteLastNode()  //this methos is used for deleting the firstnode
        {
            Node newNode = this.head;
            if(this.head== null)
            {
                return 0;
            }
            if(this.head.next == null)
            {
                this.head = null;
                return 0;
            }
            while(newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            int lastDeleteNode = newNode.next.data;
            newNode.next=null;
            return lastDeleteNode;
        }
    }
}
