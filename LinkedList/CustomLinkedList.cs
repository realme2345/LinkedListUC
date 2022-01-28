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
            Console.WriteLine("Displaying Data");
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
        public void SortAscending() //this used for ascending the values in linked list
        {
            Node temp = this.head;
            Node firstVal = null;
            int val = 0;
            while (temp != null)
            {
                firstVal = temp.next;
                while (firstVal != null)
                {
                    if (temp.data>firstVal.data)
                    {
                        val = firstVal.data;
                        firstVal.data = temp.data;
                        temp.data = val;
                    }
                    firstVal = firstVal.next;
                }
                temp = temp.next;
            }
            Console.WriteLine("Sorted the Linked List :");
        }
    }
}
