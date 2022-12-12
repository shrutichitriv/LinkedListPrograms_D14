using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProg
{
    //public class Node
    //{
    //    public int data;
    //    public Node next;

    //    public Node(int data)
    //    {
    //        this.data = data;
    //    }
    //}
    //public class LinkedList
    //{
    //    Node head = null;

    //    internal void Add(int data)//Add Data into the linked list
    //    {
    //        Node node = new Node(data);
    //        if (this.head == null)
    //        {
    //            this.head = node;
    //        }
    //        else
    //        {
    //            Node temp = head;
    //            while (temp.next != null)
    //            {
    //                temp = temp.next;
    //            }
    //            temp.next = node;
    //        }
    //        Console.WriteLine(node.data + "Inserted Data Succesfully");
    //    }
    //    internal void insertbetween(int value, int data)//add data between Two values
    //    {
    //        Node node = head;
    //        while (node.data != value)
    //        {
    //            node = node.next;
    //        }
    //        Node newnode = new Node(data);
    //        Node temp;
    //        temp = node.next;
    //        node.next = newnode;
    //        newnode.next = temp;

    //    }
    //    internal void Display()//display Linked List Data 
    //    {
    //        Node temp = this.head;
    //        if (temp == null)
    //        {
    //            Console.WriteLine("Linked List Is Empty");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Value In Linked List Are");
    //            while (temp != null)
    //            {
    //                Console.WriteLine(temp.data + " ");
    //                temp = temp.next;
    //            }
    //        }

    //    }
    //}
}
