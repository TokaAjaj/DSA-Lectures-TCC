using System;

namespace Linked_List_Homework
{
    public class LinkedList
    {
        public Node First { get; set; }

        public void Print()
        {
            Node move = First;
            while (move != null)
            {
                Console.Write(move.Data + "\t");
                move = move.Next;
            }
            Console.WriteLine();
        }

        public void Add(int val)
        {
            Node newNode = new Node(val);

            if (First == null)
            {
                First = newNode;
            }
            else
            {
                Node current = First;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void RemoveKey(int key)
        {
            if (First == null)
            {
                Console.WriteLine("Sorry List is empty. Nothing to remove.");
                return;
            }

            if (First.Data == key)
            {
                First = First.Next;
                return;
            }

            Node current = First;
            Node previous = null;

            while (current != null && current.Data != key)
            {
                previous = current;
                current = current.Next;
            }

            if (current == null)
            {
                Console.WriteLine("Sorry Key not found in the list.");
                return;
            }

            previous.Next = current.Next;
        }

        public void Merge(LinkedList other_list)
        {
            if (other_list.First == null)
            {
                Console.WriteLine("Sorry The other list is empty. Nothing to merge.");
                return;
            }

            if (First == null)
            {
                First = other_list.First;
                return;
            }

            Node current = First;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = other_list.First;
        }

        public void Reverse()
        {
            Node prev = null;
            Node current = First;

            while (current != null)
            {
                Node next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            First = prev;
        }
    }
}
