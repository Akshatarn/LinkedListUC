using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class CustomList
    {
        public Node head;
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }                
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }
        public void AddFirst(int data)      //UC2 for adding
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
            Console.WriteLine($"{newNode.data} is added into the list.");
        }
        public void Append(int data)
        {
            AddLast(data); // UC3
        }
        public void InsertInBetween(int insertAfter, int data, int insertBefore)       //InsertBetweenNodes() UC4.
        {
            Node newNode = new Node(data);
            bool isFound = false;
            Node temp = head;
            if (temp == null)
                Console.WriteLine("Linked List is empty");
            else
            {
                while (temp != null)
                {
                    if (temp.data == insertAfter && temp.next.data == insertBefore)
                    {
                        newNode.next = temp.next;
                        temp.next = newNode;
                        Console.WriteLine($"{newNode.data} insertion done between {temp.data} and {newNode.next.data}.");
                        isFound = true;
                        break;
                    }
                    temp = temp.next;
                }
            }
            if (!isFound)
                Console.WriteLine($"{data} node is not present.");
        }
        public void RemoveFirst()      // UC5 
        {
            if (head == null)
                Console.WriteLine("LinkedList is emty");
            else
            {
                int deletedNode = head.data;
                head = head.next;
                Console.WriteLine($"{deletedNode} is removed from Linkedlist");
            }
        }
        public void RemoveLast()        // UC6
        {
            Node temp = head;
            if (head == null)
                Console.WriteLine("LinkedList is emty");
            else if (temp.next == null)
            {
                int data = temp.data;
                head = null;
                Console.WriteLine($"{data} is deleted");
            }
            else
            {
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                int lastDeletedNode = temp.next.data;
                temp.next = null;
                Console.WriteLine($"{lastDeletedNode} node is deleted");
            }
        }
        public void SearchNode(int data)        //UC7.
        {
            bool isFound = false;
            Node temp = head;
            if (temp == null)
                Console.WriteLine("Linked List is empty");
            else
            {
                while (temp != null)
                {
                    if (temp.data == data)
                    {
                        Console.WriteLine($"{temp.data} node is present");
                        isFound = true;
                        break;
                    }
                    temp = temp.next;
                }
            }
            if (!isFound)
                Console.WriteLine($"{data} node is not present.");
        }
        public void InsertAfter(int insertAfter, int data)       // UC8.
        {
            Node newNode = new Node(data);
            bool isFound = false;
            Node temp = head;
            if (temp == null)
                Console.WriteLine("Linked List is empty");
            else
            {
                while (temp != null)
                {
                    if (temp.data == insertAfter)
                    {
                        newNode.next = temp.next;
                        temp.next = newNode;
                        Console.WriteLine($"{newNode.data} insertion done after {temp.data}.");
                        isFound = true;
                        break;
                    }
                    temp = temp.next;
                }
            }
            if (!isFound)
                Console.WriteLine($"{data} node is not present.");
        }
        public void Display()
        {
            Console.Write("Displaying Nodes ");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
            Console.WriteLine();
        }


    }
}
