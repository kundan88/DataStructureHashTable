using System;
using System.Collections.Generic;

namespace HashTable
{
    internal class HashTable<K, V> where K : IComparable
    {
        private readonly int _size;
        readonly List<LinkedList<K, V>> bucketList;
        public HashTable(int size)
        {
            this._size = size;
            bucketList = new List<LinkedList<K, V>>(size);
            for (int i = 0; i < _size; i++)
            {
                bucketList.Add(null);
            }
        }
        protected int GetBucketPosition(K key)
        {
            int position = key.GetHashCode() % _size;
            return Math.Abs(position);
        }
        public V Get(K key)
        {
            int position = GetBucketPosition(key);
            LinkedList<K, V> linkedList = bucketList[position];
            if (linkedList == null)
            {
                return default;
            }
            MyMapNode<K, V> myMapNode = linkedList.Search(key);
            return (myMapNode == null) ? default : myMapNode.value;
        }

        public void Add(K key, V value)
        {
            int position = GetBucketPosition(key);
            LinkedList<K, V> linkedList = bucketList[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<K, V>();
                bucketList[position] = linkedList;
            }
            MyMapNode<K, V> myMapNode = linkedList.Search(key);
            if (myMapNode == null)
            {
                myMapNode = new MyMapNode<K, V>(key, value);
                linkedList.Append(myMapNode);
            }
            else myMapNode.value = value;
        }
    }
}

