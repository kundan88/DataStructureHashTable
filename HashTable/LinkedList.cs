using System;

namespace HashTable
{
    internal class LinkedList<K, V> where K : IComparable
    {
        public MyMapNode<K, V> head;
        public MyMapNode<K, V> tail;

        public LinkedList()
        {
            head = null;
            tail = null;
        }
        internal MyMapNode<K, V> Search(K key)
        {
            MyMapNode<K, V> temp = head;
            while (temp != null)
            {
                if (temp.key.Equals(key))
                    return temp;
                else
                {
                    temp = temp.next;
                }
            }
            return null;
        }
        public void Append(MyMapNode<K, V> node)
        {
            if (head == null && tail == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.next = node;
                tail = node;
            }
        }
    }
}

