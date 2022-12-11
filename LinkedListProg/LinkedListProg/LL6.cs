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

        internal void add(int data)//Add Data Into Linkedlist
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                if (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine(node.data + "Inserted Succesfully");
        }
        internal void poplast()//Pop Last Element From LinkedList
        {
            Node node = head;

            while (node.next.next == null)
            {
                node = node.next;
            }
            node.next = null;
            Console.WriteLine("Remoe Last Node Succesfully");
        }
        internal void Display()//Display LinkedList Elements
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List Are Empty");
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
