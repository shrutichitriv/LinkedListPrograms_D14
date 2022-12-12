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
            Console.WriteLine(node.data + "Inserted Succesfuly");
        }
        internal void delete(int value, int data)//Delete Data From LinkedList
        {
            Node node = head;
            while (node.data != value)
            {
                node = node.next;
            }
            node.next = node.next.next;
        }
        internal void Display()//Display Data From Linked list
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList Is Empty");
            }
            else
            {

                Console.WriteLine("Values In LinkedList Are:");
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
        internal void size()//Show Size
        {
            int a = 0;
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList Is Empty");
            }
            else
            {
                while (temp != null)
                {
                    a++;
                    temp = temp.next;
                }
                Console.WriteLine("Size Is:" + a);
            }
        }
    }
}
