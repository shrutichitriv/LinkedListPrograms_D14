using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProg
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
        }
    }
    public class LinkedList
    {
        Node head = null;

        internal void Add(int data)// Create Linked To Add Data
        {
            Node node = new Node(data);
            if (this.head == null)// Here Check HeAD==NULL
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine(node.data + "Inserted Succesfully");
        }
        internal void popfirst()//This Function Pop First Node From Linked List
        {
            this.head = this.head.next;
            Console.WriteLine("First Element Is Removed");
        }
        internal void Display()// Here Display Accepeted Linked
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List Is Empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.data + "");
                    temp = temp.next;
                }
            }
        }
    }
}
