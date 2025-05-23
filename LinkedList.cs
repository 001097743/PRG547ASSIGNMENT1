using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG547ASSIGNMENT1
{
    class LinkedListNode<T>
    {
        public T Value { get; set; }
        public LinkedListNode<T> Previous { get; set; }
        public LinkedListNode<T> Next { get; set; }
        public LinkedListNode(T value) { Value = value; }
        public override string ToString() { return $"Value: {Value}, Next: {Next};"; }
    }

    class SinglyLinkedList<T> : ICollection<T>
    {
        public LinkedListNode<T> Head { get; set; }
        public LinkedListNode<T> Tail { get; set; }
        public int Count { get; set; }
        public void Add(T item) { AddFirst(item); }
        public void AddFirst(T value) { AddFirst(new LinkedListNode<T>(value)); }
        public void AddLast(T value) { AddLast(new LinkedListNode<T>(value)); }

        public virtual void AddFirst(LinkedListNode<T> node)
        {
            LinkedListNode<T> temp = Head;
            Head = node;
            Head.Next = temp;
            Count++;
            if (Count == 1) Tail = Head;
        }
        public virtual void AddLast(LinkedListNode<T> node)
        {
            if (Count == 0) { Head = node; }
            else { Tail.Next = node; }
            Tail = node;
            Count++;
        }

        public virtual void RemoveFirst()
        {
            if (Count != 0)
            {
                Head = Head.Next;
                Count--;
                if (Count == 0) Tail = null;
            }
        }
        public virtual void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    LinkedListNode<T> current = Head;
                    while (current.Next != Tail)
                    {
                        current = current.Next;
                    }
                    current.Next = null;
                    Tail = current;
                }
                Count--;
            }
        }


        public virtual bool Remove(T item)
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null) { Tail = previous; }
                        Count--;
                    }
                    else { RemoveFirst(); }
                    return true;
                }
            }
            return false;
        }

        public bool IsReadOnly { get { return false; } }

        public void Clear()
        {
            Head = Tail = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class DoublyLinkedList<T> : SinglyLinkedList<T>
    {
        public override void AddFirst(LinkedListNode<T> node)
        {
            LinkedListNode<T> temp = Head;
            Head = node;
            Head.Next = temp;
            if (Count == 0) { Tail = Head; }
            else { temp.Previous = Head; }
            Count++;
        }
        public override void AddLast(LinkedListNode<T> node)
        {
            if (Count == 0) { Head = node; }
            else { Tail.Next = node; node.Previous = Tail; }
            Tail = node;
            Count++;
        }
        public override void RemoveFirst()
        {
            if (Count != 0)
            {
                Head = Head.Next;
                Count--;
                if (Count == 0) Tail = null;
                else { Head.Previous = null; }
            }
        }
        public override void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1) { Head = Tail = null; }
                else
                {
                    Tail.Previous.Next = null;
                    Tail = Tail.Previous;
                }
                Count--;
            }
        }
        public override bool Remove(T item)
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null) { Tail = previous; }
                        else { current.Next.Previous = previous; }
                        Count--;
                    }
                    else { RemoveFirst(); }
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }
    }
}
