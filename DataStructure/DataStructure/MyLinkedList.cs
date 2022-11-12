﻿using DataStrucure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class MyLinkedList
    {
        public Node head;
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            Console.WriteLine("{0} is inserted into LinkedList", newNode.data);
        }
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.next = this.head;
            this.head = newNode;
            Console.WriteLine("{0} is inserted into LinkedList", newNode.data);
        }
        public void Display()
        {
            Console.WriteLine("Displaying Nodes:");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}