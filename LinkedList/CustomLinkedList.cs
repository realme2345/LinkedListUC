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
        public  void deleteNode(int value) //this method for deleting the particular value from linked list
        {
            // Store head node
            Node temp = this.head, prev = null;

            // If head node itself holds the key to be deleted
            if (temp != null &&
                temp.data == value)
            {
                // Changed head
                this.head = temp.next;
                Console.WriteLine(temp.data);
            }

            // Search for the key to be  deleted, keep track of the previous node as we need
            // to change temp.next
            while (temp != null &&
                   temp.data != value)
            {
                prev = temp;
                temp = temp.next;
                Console.WriteLine("{0} Number is not present",value);
                break;
            }
            // If key was not present in linked list
            if (temp == null)
                return ;

            // Unlink the node from linked list
            prev.next = temp.next;
        }
    }
}
