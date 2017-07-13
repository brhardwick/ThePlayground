
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Stack
{

	public class Node<T>{
  	public Node<T> Next;
  	public T Value;
  	public Node(T v)
  	{
    	Value = v;
  	}
	  
	}
public class Stack<T>{
  private Node<T> Data;
  public bool Empty {get;set;}
  public Stack()
  {
    
    Empty = true;
    
  }
  
  public void Print()
  {
    Node<T> Temp = Data;
    while(Temp!=null)
      {
        Console.WriteLine(Temp.Value.ToString());
        Temp = Temp.Next;
      }
  }
  
  public void Push(T item)
  {
    Node<T> temp = new Node<T>(item);
    temp.Next = Data;
    Data = temp;
    Empty = false;
    return;
  }
  
  public T Pop()
  {
    if(Empty)
    return default(T);
    
    T temp = Data.Value;
    Data = Data.Next;
    if(Data == null)
    Empty = true;
    return temp;
  }
 
}

public class Paranthesis
{
  string Curr {get; set;}
  
  public Paranthesis(string ParanthesisString)
  {
    Curr = ParanthesisString;
  }
  
  public bool IsProper()
  {
    if(Curr.Length == 0)
    return true;
    
    Stack<char> S = new Stack<char>();
    for(int x = 0; x < Curr.Length; x++)
    {
      if(Curr[x]=='(')
      {
        S.Push('(');
      }
      if(Curr[x]==')')
      {
        if(S.Empty)
          return false;
        else
          S.Pop();
      }
    }
    
    
    if(S.Empty)
      return true;
    else
      return false;
  }
}

public class ParanthesisFactory
{
  List<string> ValidParans;
  public ParanthesisFactory(int NumberToCreate)
  {
    ValidParans = new List<string>();
    for(int x = 1; x <= NumberToCreate; x++)
    {
      ValidParans.AddRange(GenerateStrings(x));
    }
    
  }
  
  private List<string> GenerateStrings(int NumberToCreate)
  {
    List<string> Temp = new List<string>();
    for(int x = 0; x < Math.Pow(2,NumberToCreate); x++)
    {
      string ParanString = "";
      
      string s = Convert.ToString(x,2).PadLeft(NumberToCreate,'0');
      
      var Characters = s.ToCharArray();
      for(int y = 0; y < Characters.Length; y++)
      {
        
        if(Characters[y]=='1')
          ParanString+="(";
        else
          ParanString+=")";
        
      }
      Paranthesis PeeTest = new Paranthesis(ParanString);
      if(PeeTest.IsProper())
      {
        Console.WriteLine(ParanString);  
        Temp.Add(ParanString);
      }
      
    }
    return Temp;
  }
  
}

public static class Program{
  
  
    public static void Main()
    {
      
      ParanthesisFactory pf = new ParanthesisFactory(20);    
  
    }
  }
}