using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlgorithmApp.Algorithms.LinkedList
{
    public class MyQueue
    {
        public class Node
        {
            public Node(Node next, int value)
            {
                Next = next;
                Value = value;
            }

            public Node Next { get; internal set; }
            public int Value { get; }
        }

        private Node m_Head;
        private Node m_Tail;

        public void Enqueue(int item)
        {
            Node node = new Node(null, item);

            if (m_Tail == null)
            {
                m_Head = node;
                m_Tail = node;
            }
            else
            {
                m_Tail.Next = node;
                m_Tail = node;
            }
        }

        public bool TryPeek(out int item)
        {
            if (m_Head == null)
            {
                item = default(int);

                return false;
            }

            item = m_Head.Value;

            return true;
        }

        public int Peek()
        {
            if (m_Head == null)
                throw new InvalidOperationException("Queue is empty.");

            return m_Head.Value;
        }

        public bool TryDequeue(out int item)
        {
            if (m_Head == null)
            {
                item = default(int);

                return false;
            }

            item = m_Head.Value;
            m_Head = m_Head.Next;

            return true;
        }

        public int Dequeue()
        {
            if (m_Head == null)
                throw new InvalidOperationException("Queue is empty.");

            int item = m_Head.Value;
            m_Head = m_Head.Next;

            return item;
        }


    }

}
