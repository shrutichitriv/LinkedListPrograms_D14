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
            //LinkedList l = new LinkedList();//Create Linked list Object
            //l.Add(56);//Add Linked list Data
            //l.Add(70);
            //l.Display();
            //l.insertbetween(56, 30);//Call Insert Between function
            //l.Display();

            //LL5
            //LinkedList l = new LinkedList();//Create LinkedList Object
            //l.Add(56);//AddData Into List
            //l.Add(30);
            //l.Add(70);
            //Console.WriteLine("Before Pop First Element Is");
            //l.Display();
            //Console.WriteLine("After Pop First Element Is");
            //l.popfirst();//pop First Element Function
            //l.Display();

            //LL6
            //LinkedList l = new LinkedList();//Create Linked list Objects
            //l.add(56);
            //l.add(30);
            //l.add(70);
            //Console.WriteLine("----------------------------------");
            //l.Display();
            //Console.WriteLine("----------------------------------");
            //l.poplast();//Call Poplast Element function
            //l.Display();

            //LL7
            //LinkedList l = new LinkedList();//create linked list objects
            //l.Add(56);//add data int the linkedlist
            //l.Add(30);
            //l.Add(70);
            //l.Display();//all display function
            //Console.WriteLine("after searching link list are");
            //Console.WriteLine("enter the element you have to search:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //l.Searchlinkedlist(a);//call search function to call linked list
            //l.Display();

            //LL8
            //LinkedList list = new LinkedList();//Create Linked List Object
            //list.Add(56);//Add Data Using Linked list
            //list.Add(30);
            //list.Add(70);
            //list.Display();
            //list.insertwithkey(30, 40);
            //Console.WriteLine("After Insertion Of 40 After 30:");
            //list.Display();

            //LL9
            LinkedList list = new LinkedList();//Create Object
            list.Add(56);
            list.Add(30);
            list.Add(40);
            list.Add(70);
            list.Display();
            Console.Write("Enter The Element You Have To Delete:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Previous Element Of That Element You Have To Delete:");
            int b = Convert.ToInt32(Console.ReadLine());
            list.delete(b, a);
            list.Display();
            list.size();


        }
    }
}
