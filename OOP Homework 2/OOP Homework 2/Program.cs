using System;
using System.Collections.Generic;

namespace OOP_Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<NodeClass> NewStack = new Stack<NodeClass>();
            NewStack.Push(new NodeClass("Node Class 1"));
            NewStack.Push(new NodeClass("Node Class 2"));
            NewStack.Push(new NodeClass("Node Class 3"));

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(NewStack.Pop().Data);
            }
            
        }
    }
}