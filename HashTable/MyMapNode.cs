using System;

namespace HashTable
{
    public class MyMapNode<K, V> where K : IComparable
    {
        public K key;
        public V value;
        public MyMapNode<K, V> next;

        public MyMapNode(K key, V value)
        {
            this.key = key;
            this.value = value;
            next = null;
        }
    }
}

