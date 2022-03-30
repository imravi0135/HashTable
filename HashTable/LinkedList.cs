﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void DeleteNode(K data)
        {
            if (head == null)
            {
                Console.WriteLine("Empty");
            }
            else
            {

                MyMapNode<K, V> node = Search(data);

                if (node == null)
                {
                    Console.WriteLine("Not found");
                }
                else if (node == head)
                {
                    head = head.next;
                    if (node == tail)
                    {
                        tail = null;
                    }
                }
                else
                {
                    MyMapNode<K, V> nodeBefore = null;
                    MyMapNode<K, V> temp = head;
                    while (temp != null)
                    {
                        if (temp.next == node)
                        {
                            nodeBefore = temp;
                            break;
                        }
                        temp = temp.next;
                    }
                    nodeBefore.next = node.next;
                    if (node == tail)
                    {
                        tail = nodeBefore;
                    }
                    else
                    {
                        node.next = null;
                    }
                }
            }
        }
    }
}
