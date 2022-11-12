﻿using DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the LinkedList Program\n");

            MyLinkedList linkedList = new MyLinkedList();
            Console.WriteLine("Please choose an option");
            Console.WriteLine("\n1. Add element at last position \n2. Add element at first position " +
                "\n3. Add element at last position using Append method\n4. Insert element at perticular position" +
                "\n5. Delete first element of Linkedlist\n6. Delete Last Element of Linkedlist\n7.Find Node with value" +
                "\n8. Insert After value\n9. Delete particular value\n10. Ordered or sorted Linkedlist");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Add elements into Linkedlist using AddLast Method:");
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(70);
                    linkedList.Display();
                    break;
                case 2:
                    Console.WriteLine("Add elements into Linkedlist using AddFirst Method:");
                    linkedList.AddFirst(70);
                    linkedList.AddFirst(30);
                    linkedList.AddFirst(56);
                    linkedList.Display();
                    break;
                case 3:
                    Console.WriteLine("Add elements into Linkedlist using Append Method:");
                    linkedList.Append(56);
                    linkedList.Append(30);
                    linkedList.Append(70);
                    linkedList.Display();
                    break;
                case 4:
                    Console.WriteLine("insert element at particular position:");
                    linkedList.Append(56);
                    linkedList.Append(70);
                    linkedList.Insert(1, 30);
                    linkedList.Display();
                    break;
                case 5:
                    Console.WriteLine("Delete First Element:");
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(70);
                    linkedList.Display();
                    linkedList.DeleteFirstNode();
                    linkedList.Display();
                    break;
                case 6:
                    Console.WriteLine("Delete last Element");
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(70);
                    linkedList.Display();
                    Console.WriteLine("\nLast element {0} is deleted", linkedList.DeleteFLastNode());
                    linkedList.Display();
                    break;
                case 7:
                    Console.WriteLine("Find Element");
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(70);
                    linkedList.Display();
                    linkedList.Find(30);
                    break;
                case 8:
                    Console.WriteLine("Insert After Value");
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(70);
                    linkedList.Display();
                    linkedList.InsertAfter(30, 40);
                    linkedList.Display();
                    break;
                case 9:
                    Console.WriteLine("Delete particular value");
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(70);
                    linkedList.InsertAfter(30, 40);
                    linkedList.Display();
                    linkedList.DeleteElement(40);
                    linkedList.Size();
                    linkedList.Display();
                    break;
                case 10:
                    Console.WriteLine("Sorted linkedlist");
                    linkedList.OrderedLinkedlist(56);
                    linkedList.OrderedLinkedlist(30);
                    linkedList.OrderedLinkedlist(40);
                    linkedList.OrderedLinkedlist(70);
                    linkedList.Display();
                    break;
                default:
                    Console.WriteLine("Please enter the correct option");
                    break;
            }

            Console.ReadLine();
        }
    }
}

//UC-10
//Ability to create Ordered Linked List in ascending order of data entered in following sequence 56, 30, 40,and 70
//- Refactor the code to create SortedLinkedList Class
//- Create Node that takes data that is Comparable
//- Perform Sorting during the add method call
//- Final Sequence: 30->40->56->70

//Result
//Welcome to the LinkedList Program

//Please choose an option

//1. Add element at last position
//2. Add element at first position
//3. Add element at last position using Append method
//4.Insert element at perticular position
//5. Delete first element of Linkedlist
//6. Delete Last Element of Linkedlist
//7.Find Node with value
//8. Insert After value
//9. Delete particular value
//10. Ordered or sorted Linkedlist
//10
//Sorted linkedlist
//56 is inserted into ordered Linkedlist
//30 is inserted into ordered Linkedlist
//40 is inserted into ordered Linkedlist
//70 is inserted into ordered Linkedlist
//Displaying Nodes:
// 30  40  56  70