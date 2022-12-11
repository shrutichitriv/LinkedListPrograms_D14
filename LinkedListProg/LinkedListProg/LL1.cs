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
        internal void add(int data)//Add Data In A LinkedList
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
            Console.WriteLine(node.data + ":Inserted SuccessFully");
        }
        internal void Display()//Display Data From LinkedList
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
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
