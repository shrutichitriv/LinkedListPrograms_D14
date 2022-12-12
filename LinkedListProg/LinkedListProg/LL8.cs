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
        internal void Add(int data) //Add Data Into The Linked List
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
            Console.WriteLine(node.data + ":Inserted Succesfully");

        }
        internal void insertwithkey(int value, int data) //Add Data Between Two Values
        {
            Node node = head;
            while (node.data != value)
            {
                node = node.next;
            }
            Node newnode = new Node(data);
            Node temp;
            temp = node.next;
            node.next = newnode;
            newnode.next = temp;
        }
        internal void Display()//Display Data Into The LinkedList
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
    }
}
