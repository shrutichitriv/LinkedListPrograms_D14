using System;

namespace LinkedListProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LL1
            //LinkedList list=new LinkedList();
            //list.add(56);
            //list.add(30);
            //list.add(70);
            //list.Display(); 

            //LL2
            //LinkedList L=new LinkedList();
            //L.Add(70);//Add Data Into LinkedList
            //L.Add(30);
            //L.Add(56);
            //L.Display();//Display Function Call

            //LL3
            //LinkedList l = new LinkedList();//create linkedlist object
            //l.add(56);//add data into list
            //l.add(30);
            //l.add(70);
            //l.Display();//call display

            //LL4
            LinkedList l = new LinkedList();//Create Linked list Object
            l.Add(56);//Add Linked list Data
            l.Add(70);
            l.Display();
            l.insertbetween(56, 30);//Call Insert Between function
            l.Display();
        }
    }
}
