using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To DataStractures");
            CustomLinkedList linkedList = new CustomLinkedList();
            linkedList.Append(56);
            linkedList.Append(30);
            linkedList.Append(70);
            linkedList.Display();
            Console.ReadLine();
        }
    }
}
