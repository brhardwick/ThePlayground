//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5
//Testing done through rextester.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
  public static class Helpers
    {

        public static void Print(this List<int> Arr)
        {
            foreach (var i in Arr)
            {
                Console.Write(i.ToString() + ",");
            }
            Console.WriteLine();
        }
    }

    public class LinkedList
    {
        public int? val { get; set; }
        public LinkedList next { get; set; }
        public LinkedList()
        {
            val = null;

        }
        public LinkedList(int v)
        {
            val = v;
        }
    }

    public class LinkedListFun
    {
        public LinkedList Root { get; set; }
        public void Insert(int val)
        {
            if (Root == null)
                Root = new LinkedList(val);
            else
            {
                var temp = Root;
                Root = new LinkedList(val);
                Root.next = temp;
            }
        }

        public LinkedList Reverse(LinkedList node, bool verbose = false)
        {
            LinkedList prevnode = null;
            LinkedList nextnode = null;
            LinkedList currnode = node;

            while (currnode != null)
            {
                if(verbose) Print(currnode, "currnode is ", true);
                if(verbose) Print(prevnode, "prevnode is ", true);
                if(verbose) Print(nextnode, "nextnode is ", true);

                if(verbose) Print(currnode.next,"Setting nextnode to currnode.next",true);
                nextnode = currnode.next;
                
                if(verbose) Print(prevnode,"Setting currnode.next to prevnode ",true);
                if(verbose) Console.WriteLine("Our current node has been pushed onto the structure");
                currnode.next = prevnode;
                
                if(verbose) Print(currnode,"Setting prevnode to currnode",true);
                prevnode = currnode;
                if(verbose) Print(currnode,"Setting currnode to prevnode",true);
                currnode = nextnode;
                if(verbose) Console.WriteLine("----------------");
            }
            node = prevnode;
            return node;
        }

        public void Print(LinkedList node, string message = null, bool createnewline = false)
        {

            
            if(message!=null)
            Console.Write(message);
            while (node != null)
            {
                Console.Write(node.val.ToString() + ",");
                node = node.next;
            }

            if(createnewline)
            Console.WriteLine();
            
        }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedListFun f = new LinkedListFun();
            f.Insert(10);
            f.Insert(11);
            f.Insert(12);
            f.Insert(13);
            f.Insert(14);
            f.Insert(15);
            Console.Write("Linked List: "); f.Print(f.Root);
            Console.WriteLine();
            var R = f.Reverse(f.Root);
            Console.Write("Reversed List: "); f.Print(R);
            return;

        }


    }
}