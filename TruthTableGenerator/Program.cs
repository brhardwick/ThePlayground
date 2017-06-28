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
    
    public class TruthTable
    {
        public List<List<int>> Result {get;set;}
        public int max { get; private set;}
        public int size {get; private set;}
        public TruthTable(int Size)
        {
            
            size = Size;
            max = Convert.ToInt32(Math.Pow(2,size));
            Result = new List<List<int>>(max);
            for(int x = 0 ; x < max ; x++)
            {
                    string s = Int2Binary(x);
                    Result.Add(Binary2IntList(s));
            }
            
        }
        
        public void PrintResult()
        {
            foreach(List<int> l in Result)
            {
              l.Print();   
            }
        }
        
        private string Int2Binary(int x)
        {
            return Convert.ToString(x,2).PadLeft(size,'0');
        }
        private List<int> Binary2IntList(string s)
        {
            List<int> temp = new List<int>(s.Length);
            
            foreach(var i in s.ToCharArray())
            {
                int tempint;
                if(int.TryParse(i.ToString(),out tempint))
                      temp.Add(tempint);
                   
                   else
                       return null;
            }
            return temp;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            string s = "AGUSTINA";
            TruthTable t = new TruthTable(s.Length);
            var map = t.Result;
            
            foreach(var Y in map)
            {
                string temp = "";
                for(int x = 0 ; x < Y.Count ; x++)
                {
                    if(Y[x]==1)
                        temp+=s[x];
                        
                }
                Console.WriteLine(temp);
            }   
            
            
            return;
     
        }
        
       
    }
}