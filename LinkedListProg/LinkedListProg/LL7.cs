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
        internal void Add(int data)//Add Data Into LinkedList
        {
            Node node = new Node(data);
            if (this.head == null)
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
        internal string Searchlinkedlist(int data)//Search LinkList Data
        {
            while (this.head != null)
            {
                if (this.head.data == data)
                {
                    Console.WriteLine("Element Found");
                    break;
                }
                this.head = this.head.next;

            }
            return "Element Not Found";
        }
        internal void Display()//Dislay LinkedList Element
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List Is Empty");
            }
            else
            {
                Console.WriteLine("Value In Linked List Are");
                while (temp != null)
                {
                    Console.WriteLine(temp.data + "");
                    temp = temp.next;
                }
            }
        }
    }
}
