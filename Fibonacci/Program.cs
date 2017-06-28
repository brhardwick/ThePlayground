//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5
//Testing done through rextester.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
  public static class Helpers{
     
        public static void Print(this List<int> Arr)
        {
                foreach(var i in Arr)
                {
                    Console.Write(i.ToString() +",");
                }
            Console.WriteLine();
        }
    }
    
    public class Fib{
      
      public Fib()
      {
      
      }
      
      public int GenerateFibonacciIterative(int K)
      {
        int FibNum = 0;
        List<int> FibNums = new List<int>();
        FibNums.Add(0);
        FibNums.Add(1);
        for(int x = 2 ; x < K+1 ; x++)
        {
            FibNum = FibNums[x-1] + FibNums[x-2];
            FibNums.Add( FibNum );
            
        }
        
        
        return FibNum;
      }
      
      public int GenerateFibonacciRecursive(int K)
      {
        if(K == 0)
        {
          return 0;
        }
        if(K == 1)
        {
          return 1;
        }
        
        return GenerateFibonacciRecursive(K-1) + GenerateFibonacciRecursive(K-2);
        }
      
    }
    public class Program
    {
        public static void Main(string[] args)
        {
           var f = new Fib();
           
           int K = 100;
           Console.WriteLine("f("+K.ToString()+") = "+f.GenerateFibonacciIterative(K).ToString());
           Console.Write(    "f("+K.ToString()+") = " + f.GenerateFibonacciRecursive(K).ToString());
            return;
     
        }
        
       
    }
}