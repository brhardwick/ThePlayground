
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LinkedListTesting
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



   
   
       public LinkedList Sort(LinkedList a , LinkedList b, bool verbose = false)
       {
         if(verbose) Print(a, "A: ", true);
         if(verbose) Print(b, "B: ",true);
         if(a==null)
         {
           b.next = null;
           return b;
         }
         if(b==null)
         {
           a.next = null;
            return a;
         }
         
         LinkedList temp = null;
         if(a.val<=b.val)
         {
           
           temp = a;
           temp.next = Sort(a.next,b);
         }
         else
         {
           temp = b;
           temp.next = Sort(a,b.next);
         }
         
         return temp;
       }

      public LinkedList MergeSort(LinkedList node, bool verbose = false) 
      {
        if(verbose) Print(node,"Splitting ",true);
        
        if(node == null | node.next == null)
          return node;
        LinkedList a = null;
        LinkedList b = FindCenter(node);
        
        
        var chaser = node;
        
        while(chaser.val != b.val)
        {
          var temp = a;
          a = new LinkedList((int)chaser.val);
          a.next = temp;
          
          chaser = chaser.next;
          
        }
        //a = Reverse(a);
        
        if(verbose) Print(a,"A ",true);
        if(verbose) Print(b,"B ",true);
        
        var left = MergeSort(a);
        
        if(verbose) Print(left,"left ",true);
        
        var right = MergeSort(b);
        if(verbose) Print(right,"right ",true);
        
        var sorted = Sort(left,right, verbose);
        if(verbose) Print(sorted,"sorted ",true);
        
        return sorted;
        
      }
      public LinkedList FindCenter(LinkedList node)
      {
        LinkedList fastnode = node;
        LinkedList slownode = node;
        
        while(fastnode!=null)
        {
          
          if(fastnode.next==null)
            {
              
              break;
            }
          fastnode = fastnode.next.next;
          slownode = slownode.next;
          
        }
        return slownode;
      }
        public void Print(LinkedList node, string message = null, bool createnewline = false)
        {

            
            if(message!=null)
            Console.Write(message);
            
            int x = 0;
            if(node==null)
            Console.Write("null,");
            while (node != null)
            {
              if(x ==100)
              break;
                Console.Write(node.val.ToString() + ",");
                node = node.next;
                x++;
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
            f.Insert(21);
            f.Insert(12);
            f.Insert(34);
            f.Insert(14);
            f.Insert(54);
            f.Insert(76);
            f.Insert(33);
            f.Insert(20);
            f.Insert(1);
            
            Console.Write("Linked List: "); f.Print(f.Root);
            Console.WriteLine();
            
            //var l = f.Sort(f.Root,f2.Root);
            f.Print(f.MergeSort(f.Root,false), "Sorted: ", true);
            //f.Print(l);
            return;

        }


    }
}