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
        public void AddPosition(int position, int new_data) //this method is used for adding the valuein particular position
        {
            Node temp = this.head;
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            if (position == 1)
            {
                Node new_node = new Node(new_data);
                new_node.next = this.head;
                this.head = new_node;
            }
            else
            {
                while (position--!= 0)
                {
                    if (position == 1)
                    {
                        Node new_node = new Node(new_data);
                        new_node.next = temp.next;
                        temp.next = new_node;
                        break;
                    }
                    temp = temp.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            Console.WriteLine("Inserted Value is " + temp.next.data);
        }
    }
}
